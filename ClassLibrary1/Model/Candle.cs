using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model { 
    public class Candle {
        Int32 id;
        String currency1;
        String currency2;
        DateTime openTime;
        DateTime closetime;
        Double openPrice;
        Double closeprice;
        Double highPrice;
        Double lowPrice;
        Int32 tradeNumber;
        Double volume;


        public Candle() {}
        public Candle (Int32 id, String currency1, String currency2, DateTime openTime, DateTime closetime, Double openPrice, Double closeprice, Double highPrice, Double lowPrice, Int32 tradeNumber, Double volume) {
            Id = id;
            Currency1 = currency1;
            Currency2 = currency2;
            OpenTime = openTime;
            Closetime = closetime;
            OpenPrice = openPrice;
            Closeprice = closeprice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            TradeNumber = tradeNumber;
            Volume = volume;
        }

        public int Id { get => id; set => id = value; }
        public string Currency1 { get => currency1; set => currency1 = value; }
        public string Currency2 { get => currency2; set => currency2 = value; }
        public DateTime OpenTime { get => openTime; set => openTime = value; }
        public DateTime Closetime { get => closetime; set => closetime = value; }
        public double OpenPrice { get => openPrice; set => openPrice = value; }
        public double Closeprice { get => closeprice; set => closeprice = value; }
        public double HighPrice { get => highPrice; set => highPrice = value; }
        public double LowPrice { get => lowPrice; set => lowPrice = value; }
        public int TradeNumber { get => tradeNumber; set => tradeNumber = value; }
        public double Volume { get => volume; set => volume = value; }
    }
}
