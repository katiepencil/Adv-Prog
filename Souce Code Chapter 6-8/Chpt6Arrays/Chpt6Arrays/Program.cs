using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt6Arrays
{
    class Program
    {

        enum Day
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }


        static void Main(string[] args)
        {
            
            //InitializeArray();
           // LoopArray();
           // UsingForeach();
            //UsingForeachWithEnum();
            //SearchArray();
            //FindPriceWithWhileLoop();
            //SearchArrayForRangeMatch();
            TwoDimentionalArray();
            //ThreeDimentionalArray();
            //StringFormat();
        }


        public static void InitializeArray()
        {
            // Numeric fields: 0 - default value
            //Character fields: ‘\u0000’ or null - default value
            //bool fields: false -default value

            int[] myScores = new int[5] { 100, 76, 88, 100, 90 };
            int[] myScores2 = new int[] { 100, 76, 88, 100, 90 };
            int[] myScores3 = { 100, 76, 88, 100, 90 };
        }

        public static void LoopArray()
        {

            int[] myScores = new int[] { 100, 76, 88, 100, 90 };
            for (int i = 0; i < myScores.Length; i++)
            {
                myScores[i] += 3;
            }
        }

        public static void UsingForeach()
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45, 22.22 };
            foreach (double money in payRate)
                Console.WriteLine("{0}", money.ToString("C"));
            Console.ReadLine();
        }

        public static void UsingForeachWithEnum()
        {
            foreach (string day in Enum.GetNames(typeof(Day)))
            {
                Console.WriteLine(day);
            }
            Console.ReadLine();
        }

        public static void SearchArray()
        {
            int[] validValues = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
            double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };

            int itemOrdered;
            double itemPrice = 0;
            bool isValidItem = false;

            Console.WriteLine("Please enter an Item");
            itemOrdered = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < validValues.Length; ++i)
            {
                if (itemOrdered == validValues[i])
                {
                    isValidItem = true;
                    itemPrice = prices[i];
                }
            }
            if (isValidItem)
                Console.WriteLine("Price is {0}", itemPrice);
            else
                Console.WriteLine("Sorry - Item not found");
            Console.ReadLine();
        }

        public static void FindPriceWithWhileLoop()
        {
            int[] validValues = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
            double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };

            int itemOrdered;
            double itemPrice = 0;
            bool isValidItem = false;

            Console.WriteLine("Please enter an Item");
            itemOrdered = Convert.ToInt32(Console.ReadLine());

            //using while loop
            int i = 0;
            while (i < validValues.Length && itemOrdered != validValues[i])
            {
                ++i;
            }
            if (i != validValues.Length)
            {
                isValidItem = true;
                itemPrice = prices[i];
            }

            if (isValidItem)
                Console.WriteLine("Item {0} sells for {1}", itemOrdered, itemPrice.ToString("C"));
            else
                Console.WriteLine("No such item as {0}", itemOrdered);
            Console.ReadLine();
        }

        public static void SearchArrayForRangeMatch()
        {
            int itemsOrdered;
            Console.WriteLine("Please enter an Item");
            itemsOrdered = Convert.ToInt32(Console.ReadLine());

            int[] discountRangeLowLimits = { 1, 13, 50, 100, 200 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            double customerDiscount;

            int i = discountRangeLowLimits.Length - 1;
            while (i > 0 && itemsOrdered < discountRangeLowLimits[i])
                --i;
            customerDiscount = discounts[i];
            Console.WriteLine("For {0} ordered items, the discount is {1}", itemsOrdered, customerDiscount);
            Console.ReadLine();
        }

        public static void BinarySearch()
        {
            int[] numbers = { 122, 246, 234, 454, 6789 };
            string entryString;
            Console.WriteLine("Enter Empoyee ID");

            entryString = Console.ReadLine();
            int id = Convert.ToInt32(entryString);
            int x = Array.BinarySearch(numbers, id);
            if (x < 0)
                Console.WriteLine("ID {0} not found", id);
            else
                Console.WriteLine("ID {0}  found at position {1}", id, x);

        }

        public static void TwoDimentionalArray()
        {
            int[,] rents = { {400, 450, 510},
                             {500, 560, 630},                             
                             {625, 676, 740},                              
                             {1000, 1250, 1600}
                           };
            int floor;
            int bedrooms;
            string inputString;

            Console.WriteLine("Enter the floor on which you want to live");
            inputString = Console.ReadLine();
            floor = Convert.ToInt32(inputString);

            Console.WriteLine("Enter the number of bedrooms you need");
            inputString = Console.ReadLine();
            bedrooms = Convert.ToInt32(inputString);

            Console.WriteLine("The rent is {0} ", rents[floor, bedrooms]);
            Console.ReadLine();
        }

        public static void ThreeDimentionalArray()
        {
            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[, ,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Accessing array elements.
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine("{0} equals {1}", allLength, total);

            // Output:
            // 1
            // 2
            // 3
            // 4
            // 7
            // three
            // 8
            // 12
            // 12 equals 12

        }

        public static void JaggedArray()
        {
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

            /* Output:
               Element(0): 1 3 5 7 9
               Element(1): 2 4 6 8
            */
        }

        public static void StringFormat()
        {
            // Create array of 5-tuples with population data for three U.S. cities, 1940-1950.
            Tuple<string, DateTime, int, DateTime, int>[] cities = 
            { 
            Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277, 
                         new DateTime(1950, 1, 1), 1970358),
            Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995, 
                         new DateTime(1950, 1, 1), 7891957),  
            Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808, 
                         new DateTime(1950, 1, 1), 3620962),  
            Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452, 
                         new DateTime(1950, 1, 1), 1849568) };

            // Display header
            string header = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}\n",
                                          "City", "Year", "Population", "Change (%)");
            Console.WriteLine(header);
            string output;
            foreach (var city in cities)
            {
                output = String.Format("{0,-12}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,14:P1}",
                                       city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                                       (city.Item5 - city.Item3) / (double)city.Item3);
                Console.WriteLine(output);
            }

        }
    }
}
