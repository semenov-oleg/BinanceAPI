﻿using Binance.Net.Clients;
using Binance.Net.Objects.Models.Spot;
using BinanceAPI.models;
using BinanceAPI.utils;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinanceAPI.services
{
    public class BinanceService : ExchangeService
    {
        public override int ID => 1;
        public override string Name => "Binance";

        BinanceClient client = new();
        protected override Product ToProduct(object p)
        {
            BinanceProduct binanceProduct = (BinanceProduct)p;
            return new Product()
            {
                symbol = binanceProduct.Symbol,
                exchange = ID,
                baseasset = binanceProduct.BaseAsset,
                quoteasset = binanceProduct.QuoteAsset
            };
        }

        protected override void ProcessProducts()
        {
            var r = client.SpotApi.ExchangeData.GetProductsAsync().Result;
            if (r.Success)
            {
                foreach (var p in r.Data)
                {
                    if (p.Status == "TRADING")
                    {
                        CommitProduct(ToProduct(p));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        protected override List<Kline> GetKlines(string symbol, int IntervarInMinutes, int PeriodInDays)
        {
            List<Kline> klines = new List<Kline>();

            int m = IntervarInMinutes % 60;
            int h = (IntervarInMinutes - m) / 60;
            TimeSpan klInterval = new TimeSpan(h, m, 0);

            var r = client.SpotApi.CommonSpotClient
                .GetKlinesAsync(symbol, klInterval,
                    DateTime.Now.AddDays(-1 * PeriodInDays), DateTime.Now).Result;
            if (r.Success)
            {
                klines = r.Data.ToList();

                if (klines.Count == 0)
                {
                    Msg.Send(1, $"GetProductStat({symbol})", "i==0");
                }
            }
            else
            {
                Msg.Send(1, $"GetProductStat({symbol})", r.Error!.Message);
            }
            return klines;
        }
    }
}
