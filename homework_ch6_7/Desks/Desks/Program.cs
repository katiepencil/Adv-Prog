using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    class Program
    {
        static public void Main(string[] args)
        {
            displayResults();
            Console.WriteLine("\n\nPlease hit any key to exit.");
            Console.ReadKey();
        }

        static public void displayResults()
        {
            int numDrawers = numberOfDrawers();
            string chosenWood = typeWood();
            int yourCost = costOfDesk(chosenWood, numDrawers);
            Console.WriteLine("\nYou ordered {0} drawers made of {1}.", numDrawers, chosenWood);
            Console.WriteLine("\nYour desk will cost {0}.", yourCost.ToString("c"));
        }

        static public int numberOfDrawers()
        {
            int numDrawers;
            Console.WriteLine("Enter the number of drawers, then hit 'enter'.");
            numDrawers = Convert.ToInt16(Console.ReadLine());
            return numDrawers;
        }

        static public string typeWood()
        {
            string chosenWood;
            Console.WriteLine("\nWhat kind of wood? \nEnter 'm' for mahogany, 'o' for oak, 'or 'p for pine. \n\nThen hit 'enter'.");
            chosenWood = Convert.ToString(Console.ReadLine());
            switch (chosenWood)
            {
                case "m": chosenWood = "Mahogany"; break;
                case "o":chosenWood = "Oak"; break;
                case "p":chosenWood = "Pine";break;
                default:break;
            }
            return chosenWood;
        }

        static public int costOfDesk(string chosenWood, int numDrawers)
        {
            int yourCost;
            int basePrice;
                        switch (chosenWood)
            {
                case "Pine":   basePrice = 100;   break;
                case "Oak": basePrice = 140; break;
                default: basePrice = 180; break;
            }
            yourCost = (basePrice + (numDrawers * 30));
            return yourCost;
        }
    }
}
