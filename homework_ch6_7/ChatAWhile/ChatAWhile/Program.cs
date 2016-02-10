using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourCode;
            double yourRate = 0;
            double callLength;
            double yourCost;
            int[] areaCode = {262, 414, 608, 715, 815, 920};
            double[] ratePerMinute = {.07, 0.10, .05, .16, .24, .14 };
            bool isValidItem = false;

            Console.WriteLine ("Please enter the area code for your call, then press enter.");
            yourCode = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine ("Please enter the length of your call in minutes, then press enter.");   
            callLength = Convert.ToDouble(Console.ReadLine ());

            for (int x = 0; x < areaCode.Length; ++x)
            {
                if (yourCode == areaCode[x])
                {
                    isValidItem = true;
                    yourRate = ratePerMinute[x];
                }
             }

            if (isValidItem)
            {
                yourCost = yourRate * callLength;
                Console.WriteLine("Your call will cost {0}", yourCost.ToString("c"));
            }
            else
            {
                Console.WriteLine("Sorry! Try another area code."); 
            }
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
