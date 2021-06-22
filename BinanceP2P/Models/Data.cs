using System.Collections.Generic;

namespace BinanceP2P.Models
{
    public class Data
    {
        public string orderNumber { get; set; }
        public string advNo { get; set; }
        public string tradeType { get; set; }
        public string asset { get; set; }
        public string fiat { get; set; }
        public string fiatSymbol { get; set; }
        public decimal amount { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public int orderStatus { get; set; }
        public long createTime { get; set; }
        public string currencyTicketSize { get; set; }
        public string assetTicketSize { get; set; }
        public string priceTicketSize { get; set; }
        public string sellerNickname { get; set; }
        public string buyerNickname { get; set; }
        public string makerNickname { get; set; }
        public string makerUserNo { get; set; }
        public long? confirmPayEndTime { get; set; }
        public long? notifyPayEndTime { get; set; }
        public int chatUnreadCount { get; set; }
        public List<PayMethod> payMethods { get; set; }
        public object complaintStatus { get; set; }
        public object canCancelComplaintOrder { get; set; }
    }
}
