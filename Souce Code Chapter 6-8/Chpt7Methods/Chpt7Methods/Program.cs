using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt7Methods
{
    class Program
    {

        static void Main(string[] args) // Main Method with a Parameter List
        {

            // Calling Static Method without referring to an object
            StaticMethod();

            //Non-static methods can not be called by static method - but the reverse is true. You will get Compile time error.
            //NonStaticMethod();

            //Method with single Argument
            double myPurchase = 12.99;
            DisplaySalesTax(myPurchase);
            DisplaySalesTax(35.99);

            //Multiple arugment
            DisplaySalesTax(12.99, 0.07);

            //Method that return value
            double pay = CalPay(40, 50);
            Console.WriteLine("Your total pay is {0} ", pay);
            Console.ReadLine();

            // Paramter List of Main Method
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Values at {0} is ", args[i]);              
            }         

            //

        }

        public static void StaticMethod()
        {
            Console.WriteLine("This is static method");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("This is static method");
            Console.ReadLine();
        }

        public static void DisplaySalesTax(double saleAmount)
        {          
            const double RATE = 0.07;
            double tax = saleAmount * RATE;
            Console.WriteLine("The tax on {0} is {1}", saleAmount, tax.ToString("C"));
            Console.ReadLine();
        }
                
        public static void DisplaySalesTax(double saleAmount, double taxRate)
        {   
            double tax = saleAmount * taxRate;
            Console.WriteLine("The tax on {0} at {1} is {2} ", saleAmount.ToString("C"), taxRate.ToString("P"), tax.ToString("C"));
            Console.ReadLine();
        }

        public static double CalPay(double hrs, double rate)
        {
            return hrs * rate;
        }
    }
}
