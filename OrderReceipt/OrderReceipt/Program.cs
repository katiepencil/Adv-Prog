using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string custName, streetAddress, custCity, custState; 
            int custZip, orderSize;
            double priceBlender = 39.95, salesTax = 0.07, amountDue, totalDueWithTax, taxDue;

            Console.WriteLine("Welcome to Magic Blender Company! \nPlease type your name, then hit 'enter'.");
            custName = Console.ReadLine();

            Console.WriteLine("\nPlease type your street address, then hit 'enter'.");
            streetAddress = Console.ReadLine();

            Console.WriteLine("\nPlease type your city, then hit 'enter'.");
            custCity = Console.ReadLine();

            Console.WriteLine("\nPlease type your state, then hit 'enter'.");
            custState = Console.ReadLine();

            Console.WriteLine("\nPlease type your zip, then hit 'enter'.");
            custZip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease type the number of blenders you want to order, then hit 'enter'.");
            orderSize = Convert.ToInt32(Console.ReadLine());

            amountDue = orderSize * priceBlender;
            taxDue = amountDue * salesTax;
            totalDueWithTax = amountDue + taxDue;

            Console.WriteLine("\n\nThank you for your order! Here is your receipt:");
            Console.WriteLine("\n{0} \n{1} \n{2}, {3}  {4}", custName, streetAddress, custCity, custState, custZip);

            Console.WriteLine("\nYou have ordered {0} blenders at {1} each.", orderSize, priceBlender.ToString("c"));
            Console.WriteLine("\nSub-total:{0, 15} \nTax:{1, 21} \n______________________ \n\nDue:{2, 21}", amountDue.ToString("c"), taxDue.ToString("c"), totalDueWithTax.ToString("c"));
            Console.WriteLine("\n\nPlease press any key to exit.");
            Console.ReadKey();


        }
    }
}
