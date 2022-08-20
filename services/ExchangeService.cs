using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BinanceAPI.db;
using BinanceAPI.models;
using BinanceAPI.utils;
using CryptoExchange.Net.CommonObjects;

namespace BinanceAPI.services
{
    public abstract class ExchangeService
    {
        public abstract int ID { get; }
        public abstract string Name { get; }

        public string DatabasePath { get; set; }

        public void UpdateProductsStat()
        {
            IsActive = true;
            Task.Run(() =>
            {
                ProcessProducts();
            });
        }

        public void Suspend()
        {
            IsActive = false;
        }

        protected bool IsActive { get; set; } = false;
         
        protected void CommitProduct(Product product)
        {
            List<Kline> klines = GetKlines(product.symbol, 1, 5);
            if (klines.Count > 0)
            {
                CalcProductStats(product, klines);
                ReportProduct(product);
                SaveProduct(product);
            }
        }


        private void ReportProduct(Product p)
        {

            Msg.Send(p.exchange, p.symbol,
                $"volatility={p.volatility};\tliquidity={p.liquidity};");
        }

        private void CalcProductStats(Product p, List<Kline> klines)
        {
            int i = 0, c1 = 0, c2 = 0;
            double v = 0, d = 0;

            if (klines.Count == 0)
            {
                p.volatility = -1;
                p.liquidity = -1;
                return;
            }

            double R = (double)klines.Average(k => k.ClosePrice)!;
            double H = (double)klines.Max(k => k.HighPrice)!;
            double L = (double)klines.Min(k => k.LowPrice)!;

            foreach (Kline k in klines)
            {
                ++i;

                double x = 100 * ((double)k.ClosePrice! - R);
                d += Math.Pow(x / (double)R, 2);

                c1 += k.Volume > 0 ? 1 : 0;
                c2 += k.HighPrice - k.LowPrice > 0 ? 1 : 0;

                v += (double)k.Volume!;
            }
            var cnt1 = 100 * c1 / i;
            var cnt2 = 100 * c2 / i;
            var cnt3 = (int)(100 * (H - L) / R);

            var volatility = Math.Round(Math.Sqrt((double)d / i) * 100, 2);
            var liquidity = Math.Round(Math.Log10((double)v / i) * 100, 2);
            if (liquidity == double.NegativeInfinity)
            {
                liquidity = 0;
            }

            p.volatility = volatility;
            p.liquidity = liquidity;
        }

        public void SaveProduct(Product p)
        {
            if (!File.Exists(DatabasePath))
            {
                return;
            }

            using (CryptoAlertDb db = new(DatabasePath))
            {
                try
                {
                    Product? db_product = db.Products!.FirstOrDefault(product => product.symbol == p.symbol && product.exchange == p.exchange);
                    if (db_product != null)
                    {
                        db.Products!.Remove(db_product);
                    }
                    db.Products!.Add(p);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Msg.Send(p.exchange, p.symbol, ex.Message);
                    if (ex.InnerException != null)
                        Msg.Send(p.exchange, p.symbol, ex.InnerException.Message);
                }
            }
        }

        protected abstract Product ToProduct(Object p);
        protected abstract void ProcessProducts();
        protected abstract List<Kline> GetKlines(
            string symbol,int IntervarInMinutes, int PeriodInDays);
    }
}
