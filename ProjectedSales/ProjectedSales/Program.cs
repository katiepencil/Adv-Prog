using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectedSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double salesIncreaseNextYear = 0.1, SalesNorth = 4000, SalesSouth = 5500;
            
            SalesNorth += SalesNorth * salesIncreaseNextYear;
            SalesSouth += SalesSouth * salesIncreaseNextYear;

            Console.WriteLine("\n\rNext year's projected sales (with an increase of 10%): \nNorth Division = {0} \nSouth Division = {1}.", SalesNorth.ToString("c"), SalesSouth.ToString("c"));
            Console.ReadKey();
        }
    }
}
