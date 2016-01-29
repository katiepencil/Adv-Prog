using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt1And2
{
    class Program
    {

        static void Main(string[] args)
        {


            /* chapter 1 */

            //Console.ReadLine();
            Initials();
            PersonalInfo();
            TableAndChair();

            /* Chapter 2 */
            DisplayVariableValues();
            CompareStrings();
            InteractiveSalesTax();

            // Programming Exercises - Chapter 2
            //#16.
            Planets.displayPlanet();
            Console.ReadLine();

            //#13.
            Payroll.PayrollPayment();
            Console.ReadLine();

        }

        private static void Initials()
        {
            System.Console.WriteLine("     J   FFFFFF");
            System.Console.WriteLine("     J   F");
            System.Console.WriteLine("     J   FFF");
            System.Console.WriteLine("     J   F");
            System.Console.WriteLine("J    J   F");
            System.Console.WriteLine("JJJJJJ   F");
            System.Console.ReadLine();
        }
        private static void PersonalInfo()
        {
            System.Console.WriteLine("Mary Jones");
            System.Console.WriteLine("mjones@email.com");
            System.Console.WriteLine("921-129-9291");
            System.Console.ReadLine();
        }
        private static void TableAndChair()
        {
            System.Console.WriteLine("X                      X");
            System.Console.WriteLine("X                      X");
            System.Console.WriteLine("X      XXXXXXXXXX      X");
            System.Console.WriteLine("XXXXX  X        X  XXXXX");
            System.Console.WriteLine("X   X  X        X  X   X");
            System.Console.WriteLine("X   X  X        X  X   X");
            System.Console.ReadLine();
        }

        private static void DisplayVariableValues()
        {
            Console.WriteLine("{0, 5}", 4);
            Console.WriteLine("{0, 5}", 56);
            Console.WriteLine("{0, 5}", 789);
            Console.WriteLine("{0, -8}{1, -8}", "Richard", "Lee");
            Console.WriteLine("{0, -8}{1, -8}", "Marcia", "Parker");
            Console.WriteLine("{0, -8}{1, -8}", "Ed", "Tompkins");
            Console.ReadLine();
        }

        private static void CompareStrings()
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Mathew";

            Console.WriteLine(" Compare {0} to {1} : {2} ", name1, name2, String.Equals(name1, name2));
            Console.ReadLine();
            Console.WriteLine(" Compare {0} to {1} : {2} ", name1, name3, String.Equals(name1, name3));
            Console.ReadLine();
        }

        private static void InteractiveSalesTax()
        {

            const double TAX_RATE = 0.06;
            string itemPriceAsString;
            double itemPrice = 0;
            double total;

            Console.WriteLine(" Enter the price of an item >>");
            itemPriceAsString = Console.ReadLine();
            if (!string.IsNullOrEmpty(itemPriceAsString))
                itemPrice = Convert.ToDouble(itemPriceAsString);
            total = itemPrice * TAX_RATE;
            Console.WriteLine("With a Tax rate of {0}, a {1} item costs {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));
            Console.ReadLine();

        }

    }

    public class Planets
    {
        // an enum that contains the name of planets
        enum Planet { MERCURY = 1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE };

        public static void displayPlanet()
        {
            Planet planet;
            int position;
            Console.Write("Enter a number to see the planet at that position >> ");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + position);
            planet = (Planet)position;
            Console.WriteLine("{0} is {1} planet(s) from the sun", planet, (position));
        }
    }

    class Payroll
    {
        public static void PayrollPayment()
        {
            string name, ssn, entry;
            double rate, hours, gross, fed, state, net;
            const double FEDTAX = 0.15;
            const double STATETAX = 0.05;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Security number: ");
            ssn = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            entry = Console.ReadLine();
            rate = Convert.ToDouble(entry);
            Console.Write("Hours worked: ");
            entry = Console.ReadLine();
            hours = Convert.ToDouble(entry);
            gross = rate * hours;
            fed = gross * FEDTAX;
            state = gross * STATETAX;
            net = gross - fed - state;
            Console.WriteLine("\nPayroll Summary for: {0}\nSSN: {1}\nYou worked {2} hours at {3} per hour",
              name, ssn, hours, rate.ToString("C"));
            Console.WriteLine("\nGross pay:           {0, 10}", gross.ToString("c"));
            Console.WriteLine("Federal withholding: {0, 10}", fed.ToString("c"));
            Console.WriteLine("State withholding :  {0, 10}", state.ToString("c"));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Net pay:             {0, 10}", net.ToString("c"));
        }
    }
}
