using Binance.Net;
using Binance.Net.Objects;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            BinanceClient.SetDefaultOptions(new BinanceClientOptions()
            {
                ApiCredentials = new ApiCredentials("APIKEY", "ZkCeNPdKLjXFn9oQehoQwe226E6Z0iW5IOYcnHzMroE969XVuipu543A84uVkzE1"),
                LogVerbosity = LogVerbosity.Debug,
               //                 LogWriter = Console.Out
            });
            BinanceSocketClient.SetDefaultOptions(new BinanceSocketClientOptions()
            {
                ApiCredentials = new ApiCredentials("APIKEY", "kTGx5jlVkCOvqVa95G1WQ3xa6B1aC5beJiBlQvbzKURvFPcQ4tudS0Hp8JSL3Kkv"),
                LogVerbosity = LogVerbosity.Debug,
                //                LogWriter = Console.Out
            });


            String symbol = "POABTC";
            DateTime? fecha = null;
            
            using (var client = new BinanceClient())
            {
                /*
                while (true)
                {
                    fecha = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, DateTime.UtcNow.Hour, DateTime.UtcNow.Minute, 0);
                    CallResult<BinanceKline[]> klines = client.GetKlines(symbol, KlineInterval.OneMinute, startTime: fecha.Value.AddMinutes(-1), endTime: fecha, limit: 1);
                    if (klines.Success) {
                        foreach (BinanceKline kline in klines.Data) {
                            printKline(kline, symbol);
                        }
                    }
                    Thread.Sleep(60000);
                }
                */
                // Public
                /*
                                var ping = client.Ping();
                                var exchangeInfo = client.GetExchangeInfo();
                                var serverTime = client.GetServerTime();
                                var orderBook = client.GetOrderBook("BNBBTC", 10);
                                var aggTrades = client.GetAggregatedTrades("BNBBTC", startTime: DateTime.UtcNow.AddMinutes(-2), endTime: DateTime.UtcNow, limit: 10);
                */
                DateTime inicio = new DateTime(2018, 4, 7, 14, 30, 0);
                DateTime fin = new DateTime(2018, 4, 7, 16, 15, 0);
                var klines = client.GetKlines(symbol, KlineInterval.FiveMinutes, startTime: inicio, endTime: fin);
                if (klines.Success)
                {
                    foreach (BinanceKline kline in klines.Data)
                    {
                        printKline(kline, symbol);
                    }
                }                
/*
                var price = client.GetPrice("BNBBTC");
                var prices24h = client.Get24HPrice("BNBBTC");
                var allPrices = client.GetAllPrices();
                var allBookPrices = client.GetAllBookPrices();
                var historicalTrades = client.GetHistoricalTrades("BNBBTC");

                // Private

                                var openOrders = client.GetOpenOrders("BNBBTC");
                                var allOrders = client.GetAllOrders("BNBBTC");
                                var testOrderResult = client.PlaceTestOrder("BNBBTC", OrderSide.Buy, OrderType.Limit, 1, price: 1, timeInForce: TimeInForce.GoodTillCancel);
                                var queryOrder = client.QueryOrder("BNBBTC", allOrders.Data[0].OrderId);
                                var orderResult = client.PlaceOrder("BNBBTC", OrderSide.Sell, OrderType.Limit, 10, price: 0.0002m, timeInForce: TimeInForce.GoodTillCancel);
                                var cancelResult = client.CancelOrder("BNBBTC", orderResult.Data.OrderId);
                                var accountInfo = client.GetAccountInfo();
                                var myTrades = client.GetMyTrades("BNBBTC");

                                // Withdrawal/deposit
                                var withdrawalHistory = client.GetWithdrawHistory();
                                var depositHistory = client.GetDepositHistory();
                                var withdraw = client.Withdraw("ASSET", "ADDRESS", 0);
*/
            }

/*
            var socketClient = new BinanceSocketClient();
            // Streams
            var successDepth = socketClient.SubscribeToDepthStream("bnbbtc", (data) =>
            {
                // handle data
            });
            var successTrades = socketClient.SubscribeToTradesStream("bnbbtc", (data) =>
            {
                // handle data
            });

            var successKline = socketClient.  SubscribeToKlineStreamAsync("bnbbtc", KlineInterval.OneMinute, (data) =>
            {
                Console.Out.Write("PAR: " +  data.Data.Symbol + Environment.NewLine);
                Console.Out.Write("OPEN TIME: " + data.Data.OpenTime + Environment.NewLine);
                Console.Out.Write("CLOSE TIME: " + data.Data.CloseTime + Environment.NewLine);
                Console.Out.Write("OPEN: " + data.Data.Open + Environment.NewLine);
                Console.Out.Write("CLOSE: " + data.Data.Close + Environment.NewLine);
                Console.Out.Write("HIGH: " + data.Data.High + Environment.NewLine);
                Console.Out.Write("LOW: " + data.Data.Low + Environment.NewLine);
                Console.Out.Write("TRADES: " + data.Data.TradeCount + Environment.NewLine);
                Console.Out.Write("VOLUME: " + data.Data.Volume + Environment.NewLine);
                Console.Out.Write("=============== " + data.Data.Volume + Environment.NewLine);                
            });

            var successTicker = socketClient.SubscribeToAllSymbolTicker((data) =>
            {
                // handle data
            });
            var successSingleTicker = socketClient.SubscribeToSymbolTicker("bnbbtc", (data) =>
            {
                // handle data
            });

            string listenKey;
            using (var client = new BinanceClient())
                listenKey = client.StartUserStream().Data.ListenKey;

            var successAccount = socketClient.SubscribeToUserStream(listenKey, data =>
            {
                // Hanlde account info data
            },
                data =>
                {
                    // Hanlde order update info data
                });
            socketClient.UnsubscribeAllStreams();
*/
            Console.ReadLine();

        }

        private void printKline(BinanceKline data, String symbol)
        {
            //Console.Out.Write("PAR: " + symbol + Environment.NewLine);
           Console.Out.Write("OPEN TIME: " + data.OpenTime + Environment.NewLine);
            //Console.Out.Write("CLOSE TIME: " + data.CloseTime + Environment.NewLine);
            //Console.Out.Write("OPEN: " + data.Open + Environment.NewLine);
            //Console.Out.Write("CLOSE: " + data.Close + Environment.NewLine);
            //Console.Out.Write("HIGH: " + data.High + Environment.NewLine);
            //Console.Out.Write("LOW: " + data.Low + Environment.NewLine);
            Console.Out.Write("TRADES: " + data.TradeCount + Environment.NewLine);
            Console.Out.Write("VOLUME: " + data.Volume + Environment.NewLine);
            //Console.Out.Write("=============== " + Environment.NewLine);
        }
    }

   

}
