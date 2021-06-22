using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceP2P.Models
{
    public class Maker
    {
        public string userNo { get; set; }
        public string userType { get; set; }
        public string nickName { get; set; }
        public UserStatsRet userStatsRet { get; set; }
    }
}
