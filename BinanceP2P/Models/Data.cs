using System.Collections.Generic;

namespace BinanceP2P.Models
{
    public class Data
    {
        public string orderNumber { get; set; }
        public int advOrderId { get; set; }
        public string advOrderNumber { get; set; }
        public string buyerMobilePhone { get; set; }
        public string sellerName { get; set; }
        public string sellerNickname { get; set; }
        public string sellerMobilePhone { get; set; }
        public object sellerUserNo { get; set; }
        public string buyerNickname { get; set; }
        public string buyerName { get; set; }
        public object buyerUserNo { get; set; }
        public string tradeType { get; set; }
        public string payType { get; set; }
        public string payee { get; set; }
        public string payAccount { get; set; }
        public string payBank { get; set; }
        public string paySubBank { get; set; }
        public string qrCodePath { get; set; }
        public List<PayMethod> payMethods { get; set; }
        public int selectedPayId { get; set; }
        public int orderStatus { get; set; }
        public string asset { get; set; }
        public decimal amount { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public string fiatUnit { get; set; }
        public bool isComplaintAllowed { get; set; }
        public object complaintReason { get; set; }
        public object complaintStatus { get; set; }
        public object complaintDeadline { get; set; }
        public int confirmPayTimeout { get; set; }
        public string remark { get; set; }
        public long createTime { get; set; }
        public long updateTime { get; set; }
        public object notifyPayTime { get; set; }
        public object confirmPayTime { get; set; }
        public object cancelTime { get; set; }
        public long notifyPayEndTime { get; set; }
        public object confirmPayEndTime { get; set; }
        public long allowComplainTime { get; set; }
        public object complainFreezeTime { get; set; }
        public string fiatSymbol { get; set; }
        public string currencyTicketSize { get; set; }
        public string assetTicketSize { get; set; }
        public string priceTicketSize { get; set; }
        public int notifyPayedExpireMinute { get; set; }
        public int confirmPayedExpireMinute { get; set; }
        public string confirmPaidType { get; set; }
        public string quickConfirmAmountUpLimit { get; set; }
        public object currencyRate { get; set; }
        public string idNumber { get; set; }
        public object address { get; set; }
        public bool canCancelComplaintOrder { get; set; }
        public string clientType { get; set; }
        public bool authentication { get; set; }
        public string nickColor { get; set; }
        public string onlineStatus { get; set; }
        public string merchantNo { get; set; }
        public string origin { get; set; }
        public int unreadCount { get; set; }
        public int chatUnreadCount { get; set; }
        public string iconUrl { get; set; }
        public object avgReleasePeriod { get; set; }
        public object avgPayPeriod { get; set; }
        public object expectedPayTime { get; set; }
        public object expectedReleaseTime { get; set; }
        public Taker taker { get; set; }
        public Maker maker { get; set; }
        public object videoUrl { get; set; }
        public object orderComplaintAmount { get; set; }
        public string classify { get; set; }
        public int commissionRate { get; set; }
        public int commission { get; set; }
        public List<TradeMethodCommissionRate> tradeMethodCommissionRates { get; set; }
    }
}
