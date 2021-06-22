using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceP2P.Models
{
    public class UserStatsRet
    {
        public int registerDays { get; set; }
        public object firstOrderDays { get; set; }
        public object payMethodCount { get; set; }
        public object avgReleaseTimeOfLatest30day { get; set; }
        public object avgPayTimeOfLatest30day { get; set; }
        public string finishRateLatest30day { get; set; }
        public string completedOrderNumOfLatest30day { get; set; }
        public object completedBuyOrderNumOfLatest30day { get; set; }
        public int completedSellOrderNumOfLatest30day { get; set; }
        public object completedOrderTotalBtcAmountOfLatest30day { get; set; }
        public object completedOrderNum { get; set; }
        public object completedBuyOrderNum { get; set; }
        public object completedSellOrderNum { get; set; }
        public object completedBuyOrderTotalBtcAmount { get; set; }
        public object completedSellOrderTotalBtcAmount { get; set; }
        public object completedOrderTotalBtcAmount { get; set; }
    }
}
