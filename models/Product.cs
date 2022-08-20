
using System.ComponentModel.DataAnnotations;

namespace BinanceAPI.models
{
    public class Product
    {
        public Product() { symbol = baseasset = quoteasset = ""; }

        [Key]
        public int Id { get; set; }

        public string symbol { get; set; }
        public int exchange { get; set; }
        public string baseasset { get; set; }
        public string quoteasset { get; set; }
        public double volatility { get; set; }
        public double liquidity { get; set; }
    }
}
