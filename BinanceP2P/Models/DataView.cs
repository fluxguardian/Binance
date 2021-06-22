using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceP2P.Models
{
    public class DataView : BindableBase
    {
        public DataView(Data data)
        {
            this.orderNumber = data.orderNumber;
            this.advNo = data.advNo;
            this.tradeType = data.tradeType;
            this.asset = data.asset;
            this.fiat = data.fiat;
            this.fiatSymbol = data.fiatSymbol;
            this.amount = data.amount;
            this.price = data.price;
            this.totalPrice = data.totalPrice;
            this.orderStatus = data.orderStatus;
            this.createTime = data.createTime;
            this.currencyTicketSize = data.currencyTicketSize;
            this.assetTicketSize = data.assetTicketSize;
            this.priceTicketSize = data.priceTicketSize;
            this.sellerNickname = data.sellerNickname;
            this.buyerNickname = data.buyerNickname;
            this.makerNickname = data.makerNickname;
            this.makerUserNo = data.makerUserNo;
            this.confirmPayEndTime = data.confirmPayEndTime;
            this.notifyPayEndTime = data.notifyPayEndTime;
            this.chatUnreadCount = data.chatUnreadCount;
            this.payMethods = data.payMethods;
            this.complaintStatus = data.complaintStatus;
            this.canCancelComplaintOrder = data.canCancelComplaintOrder;
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
        public bool notified;
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
