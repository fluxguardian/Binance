using Binance.API.Csharp.Client;
using Binance.API.Csharp.Client.Models.WebSocket;
using BinanceP2P.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BinanceP2P.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly string token = "1656188113:AAHHb5xfOw39tN9y1w-C6ODSSTPfijpSMRg";
        private readonly string chatId = "1314086379";
        protected IDispatcherService DispatcherService => GetService<IDispatcherService>();
        protected IMessageBoxService MessageBoxService => GetService<IMessageBoxService>(ServiceSearchMode.PreferParents);

        private readonly object _syncLock = new object();
        private readonly BinanceClient binanceClient;
        private readonly ITelegramBotClient botClient;
        public int USDT
        {
            get => GetValue<int>();
            set => SetValue(value);
        }

        public string JsonOrders
        {
            get => GetValue<string>();
            set => OnParseJson(value);// SetValue(value);
        }

        private void OnParseJson(string value)
        {
            try
            {
                Order orders = Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(value);
                if (orders == null)
                {
                    return;
                }
                lock (_syncLock)
                {
                    foreach (Data item in orders.data.Where(i => i.tradeType == "SELL"))
                    {
                        if (!Orders.Any(i => i.orderNumber == item.orderNumber))
                        {
                            Orders.Add(new DataView(item));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public AggregateTradeMessage BTCUSDT
        {
            get => GetValue<AggregateTradeMessage>();
            private set => SetValue(value);
        }

        public AggregateTradeMessage ETHUSDT
        {
            get => GetValue<AggregateTradeMessage>();
            private set => SetValue(value);
        }

        public AggregateTradeMessage BNBUSDT
        {
            get => GetValue<AggregateTradeMessage>();
            private set => SetValue(value);
        }

        public DelegateCommand ClearCommand { get; }
        public DelegateCommand<DataView> BuyCommand { get; }
        public DelegateCommand<DataView> RemoveCommand { get; }
        public ObservableCollection<DataView> Orders
        {
            get => GetValue<ObservableCollection<DataView>>();
            private set => SetValue(value);
        }

        [Obsolete]
        public MainViewModel()
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            botClient = new TelegramBotClient(token);
            botClient.StartReceiving();

            //if (IsInDesignMode)
            {
                ClearCommand = new DelegateCommand(OnClear);
                BuyCommand = new DelegateCommand<DataView>(OnBuy);
                RemoveCommand = new DelegateCommand<DataView>(OnRemove);
            }
            lock (_syncLock)
            {
                Orders = new ObservableCollection<DataView>();
            }

            ApiClient apiClient = new ApiClient("", "");
            binanceClient = new BinanceClient(apiClient, false);

            binanceClient.ListenTradeEndpoint(nameof(BTCUSDT).ToLower(), TradesHandler);
            binanceClient.ListenTradeEndpoint(nameof(ETHUSDT).ToLower(), TradesHandler);
            binanceClient.ListenTradeEndpoint(nameof(BNBUSDT).ToLower(), TradesHandler);

            //_ = Task.Factory.StartNew(async () =>
            //  {
            //      while (true)
            //      {

            //          await Task.Delay(100);
            //      }
            //  }, TaskCreationOptions.RunContinuationsAsynchronously);
        }

        private void TradesHandler(AggregateTradeMessage messageData)
        {
            switch (messageData.Symbol)
            {
                case nameof(BTCUSDT):
                    BTCUSDT = messageData;
                    lock (_syncLock)
                    {
                        DispatcherService?.BeginInvoke(() =>
                        {
                            foreach (DataView item in Orders.Where(i => nameof(BTCUSDT).StartsWith(i.asset)))
                            {
                                item.usdt = USDT;
                                item.Price = BTCUSDT.Price;
                                item.Amount = Math.Truncate(item.amount * 100000) / 100000M;
                                item.totalUSDT = Math.Truncate(item.Price * item.Amount * 10000) / 10000M;
                                item.actual = item.totalUSDT * item.usdt;
                                item.percent = item.actual / item.totalPrice;
                                item.receive = item.actual - item.totalPrice;
                                item.countdown = item.CreateTime.AddMinutes(item.notifyPayedExpireMinute) - DateTime.Now;
                                item.countdown = item.countdown.TotalMilliseconds < 0 ? TimeSpan.FromSeconds(0) : item.countdown;
                            }
                        });
                    }
                    break;

                case nameof(ETHUSDT):
                    ETHUSDT = messageData;
                    lock (_syncLock)
                    {
                        DispatcherService?.BeginInvoke(() =>
                        {
                            foreach (DataView item in Orders.Where(i => nameof(ETHUSDT).StartsWith(i.asset)))
                            {
                                item.usdt = USDT;
                                item.Price = ETHUSDT.Price;
                                item.Amount = Math.Truncate(item.amount * 10000) / 10000M;
                                item.totalUSDT = Math.Truncate(item.Price * item.Amount * 10000) / 10000M;
                                item.actual = item.totalUSDT * item.usdt;
                                item.percent = item.actual / item.totalPrice;
                                item.receive = item.actual - item.totalPrice;
                                item.countdown = item.CreateTime.AddMinutes(item.notifyPayedExpireMinute) - DateTime.Now;
                                item.countdown = item.countdown.TotalMilliseconds < 0 ? TimeSpan.FromSeconds(0) : item.countdown;
                            }
                        });
                    }
                    break;

                case nameof(BNBUSDT):
                    BNBUSDT = messageData;
                    lock (_syncLock)
                    {
                        DispatcherService?.BeginInvoke(() =>
                        {
                            foreach (DataView item in Orders.Where(i => nameof(BNBUSDT).StartsWith(i.asset)))
                            {
                                item.usdt = USDT;
                                item.Price = BNBUSDT.Price;
                                item.Amount = Math.Truncate(item.amount * 1000) / 1000M;
                                item.totalUSDT = Math.Truncate(item.Price * item.Amount * 10000) / 10000M;
                                item.actual = item.totalUSDT * item.usdt;
                                item.percent = item.actual / item.totalPrice;
                                item.receive = item.actual - item.totalPrice;
                                item.countdown = item.CreateTime.AddMinutes(item.notifyPayedExpireMinute) - DateTime.Now;
                                item.countdown = item.countdown.TotalMilliseconds < 0 ? TimeSpan.FromSeconds(0) : item.countdown;
                            }
                        });
                    }
                    break;

                default:
                    break;
            }
        }

        private void OnClear()
        {
            if (MessageBoxService.ShowMessage("Clear all?", "Question", MessageButton.OKCancel) == MessageResult.Cancel)
            {
                return;
            }
            lock (_syncLock)
            {
                Orders = new ObservableCollection<DataView>();
            }
        }

        private void OnBuy(DataView row)
        {
            var fields = row.payMethods.FirstOrDefault()?.fields;
            if (fields == null)
            {
                return;
            }
            botClient.SendTextMessageAsync(chatId, $"Asset: {row.asset}\r\nAmount: ```{row.Amount}```\r\n{string.Join("\r\n", fields.Select(i => i.fieldName + ": ```" + i.fieldValue + "```"))}\r\nTotal Price: ```{Math.Truncate(row.totalPrice)}```", ParseMode.Markdown).Wait();
        }

        private void OnRemove(DataView row)
        {
            lock (_syncLock)
            {
                Orders.Remove(row);
            }
        }
    }
}