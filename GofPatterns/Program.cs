using System;

namespace GofPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy
            //Bank bank = new OneHundredPercentReliability();
            //int money = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(bank.TransferMoney(money));

            //ChainOfResponsibility
            //Shop shop = new Shop();
            //Console.WriteLine("What do you want to buy? sword, axe, amulet?");
            //string product = Console.ReadLine();
            //Console.WriteLine("It won't be cheap! Don't spare money. (enter amount of money)");
            //int money = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(shop.GetTheJobDone(money, product));

            //Facade
            //TheWeather weather = new TheWeather();
            //Console.WriteLine(weather.CheckTheWeather());

            //Observer
            //Observer observer = new Observer();
            //Console.WriteLine(observer.WinLottery());

            //Clone
            //Prototype prototype = new ConcretePrototype1(1, "white", "Dolly sheep");
            //Prototype clone = prototype.Clone();
            //Console.WriteLine(clone.Id + " " + clone.Name + " " + clone.Color);
            //prototype = new ConcretePrototype2(2, "black", "Molly sheep");
            //clone = prototype.Clone();
            //Console.WriteLine(clone.Id + " " + clone.Name + " " + clone.Color);
        }
    }

}

