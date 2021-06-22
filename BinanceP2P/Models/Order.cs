using System.Collections.Generic;

namespace BinanceP2P.Models
{
    public class Order
    {
        public string code { get; set; }
        public string message { get; set; }
        public string messageDetail { get; set; }
        public List<Data> data { get; set; }
        public int total { get; set; }
        public bool success { get; set; }
    }
}
