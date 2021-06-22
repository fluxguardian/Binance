using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceP2P.Models
{
    public class TradeMethodCommissionRate
    {
        public string tradeMethodIdentifier { get; set; }
        public string tradeMethodName { get; set; }
        public string commissionRate { get; set; }
    }
}
