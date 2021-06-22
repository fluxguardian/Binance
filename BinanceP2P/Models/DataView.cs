using DevExpress.Mvvm;
using System;
using System.Collections.Generic;

namespace BinanceP2P.Models
{
    public class DataView : BindableBase
    {
        public DataView(Data data)
        {
            this.orderNumber = data.orderNumber;
            this.advOrderId = data.advOrderId;
            this.advOrderNumber = data.advOrderNumber;
            this.buyerMobilePhone = data.buyerMobilePhone;
            this.sellerName = data.sellerName;
            this.sellerNickname = data.sellerNickname;
            this.sellerMobilePhone = data.sellerMobilePhone;
            this.sellerUserNo = data.sellerUserNo;
            this.buyerNickname = data.buyerNickname;
            this.buyerName = data.buyerName;
            this.buyerUserNo = data.buyerUserNo;
            this.tradeType = data.tradeType;
            this.payType = data.payType;
            this.payee = data.payee;
            this.payAccount = data.payAccount;
            this.payBank = data.payBank;
            this.paySubBank = data.paySubBank;
            this.qrCodePath = data.qrCodePath;
            this.payMethods = data.payMethods;
            this.selectedPayId = data.selectedPayId;
            this.orderStatus = data.orderStatus;
            this.asset = data.asset;
            this.amount = data.amount;
            this.price = data.price;
            this.totalPrice = data.totalPrice;
            this.fiatUnit = data.fiatUnit;
            this.isComplaintAllowed = data.isComplaintAllowed;
            this.complaintReason = data.complaintReason;
            this.complaintStatus = data.complaintStatus;
            this.complaintDeadline = data.complaintDeadline;
            this.confirmPayTimeout = data.confirmPayTimeout;
            this.remark = data.remark;
            this.createTime = data.createTime;
            this.updateTime = data.updateTime;
            this.notifyPayTime = data.notifyPayTime;
            this.confirmPayTime = data.confirmPayTime;
            this.cancelTime = data.cancelTime;
            this.notifyPayEndTime = data.notifyPayEndTime;
            this.confirmPayEndTime = data.confirmPayEndTime;
            this.allowComplainTime = data.allowComplainTime;
            this.complainFreezeTime = data.complainFreezeTime;
            this.fiatSymbol = data.fiatSymbol;
            this.currencyTicketSize = data.currencyTicketSize;
            this.assetTicketSize = data.assetTicketSize;
            this.priceTicketSize = data.priceTicketSize;
            this.notifyPayedExpireMinute = data.notifyPayedExpireMinute;
            this.confirmPayedExpireMinute = data.confirmPayedExpireMinute;
            this.confirmPaidType = data.confirmPaidType;
            this.quickConfirmAmountUpLimit = data.quickConfirmAmountUpLimit;
            this.currencyRate = data.currencyRate;
            this.idNumber = data.idNumber;
            this.address = data.address;
            this.canCancelComplaintOrder = data.canCancelComplaintOrder;
            this.clientType = data.clientType;
            this.authentication = data.authentication;
            this.nickColor = data.nickColor;
            this.onlineStatus = data.onlineStatus;
            this.merchantNo = data.merchantNo;
            this.origin = data.origin;
            this.unreadCount = data.unreadCount;
            this.chatUnreadCount = data.chatUnreadCount;
            this.iconUrl = data.iconUrl;
            this.avgReleasePeriod = data.avgReleasePeriod;
            this.avgPayPeriod = data.avgPayPeriod;
            this.expectedPayTime = data.expectedPayTime;
            this.expectedReleaseTime = data.expectedReleaseTime;
            this.taker = data.taker;
            this.maker = data.maker;
            this.videoUrl = data.videoUrl;
            this.orderComplaintAmount = data.orderComplaintAmount;
            this.classify = data.classify;
            this.commissionRate = data.commissionRate;
            this.commission = data.commission;
            this.tradeMethodCommissionRates = data.tradeMethodCommissionRates;
        }

        public DateTime CreateTime { get => DateTimeOffset.FromUnixTimeMilliseconds(createTime).LocalDateTime; }
        public TimeSpan countdown
        {
            get => GetValue<TimeSpan>();
            set => SetValue(value);
        }
        public decimal Price
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
        public decimal Amount
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
        public int usdt
        {
            get => GetValue<int>();
            set => SetValue(value);
        }
        public decimal actual
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
        public decimal totalUSDT
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
        public decimal percent
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
        public decimal receive
        {
            get => GetValue<decimal>();
            set => SetValue(value);
        }
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
