using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectedSalesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double salesIncreaseNextYear = 0.1, SalesNorth, SalesSouth;

            Console.WriteLine("Type the sales for the North Division this year, then hit 'enter'.");
            SalesNorth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type the sales for the South Division this year, then hit 'enter'.");
            SalesSouth = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n\rSales this year were... \nNorth Division = {0} \nSouth Division = {1}.", SalesNorth.ToString("c"), SalesSouth.ToString("c"));
            
            SalesNorth += SalesNorth * salesIncreaseNextYear;
            SalesSouth += SalesSouth * salesIncreaseNextYear;

            Console.WriteLine("\n\rNext year's projected sales (with an increase of 10%): \nNorth Division = {0} \nSouth Division = {1}.", SalesNorth.ToString("c"), SalesSouth.ToString("c"));
            Console.WriteLine("\n\nHit any key to exit.");
            Console.ReadKey();
        }
    }
}
