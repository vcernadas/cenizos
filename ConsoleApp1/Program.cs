using ClassLibrary1;
using ClassLibrary1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppDatabase db = new AppDatabase("public");
                Candle candle = new Candle(1, "test1", "test2", DateTime.UtcNow, DateTime.UtcNow, 1, 2, 2, 1, 1, 1);
                db.Candles.Add(candle);
                int res = db.SaveChanges();
                Console.Out.Write(res);
            }
            catch (Exception e)
            {
                Console.Out.Write(e.Message);
            }

            //Class1 miCalse = new Class1();
        }
    }
}
