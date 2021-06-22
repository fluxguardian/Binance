using System.Collections.Generic;

namespace BinanceP2P.Models
{
    public class PayMethod
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string tradeMethodName { get; set; }
        public string tradeMethodShortName { get; set; }
        public string tradeMethodBgColor { get; set; }
        public List<Field> fields { get; set; }
        public string iconUrlColor { get; set; }
        public object tradeMethodTips { get; set; }
    }
}
