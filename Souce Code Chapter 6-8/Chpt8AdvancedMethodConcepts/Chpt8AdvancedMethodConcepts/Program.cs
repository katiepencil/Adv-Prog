using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt8AdvancedMethodConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            // Parameter Types : 

            //1. Value parameters - Declared without any modifiers
            int x = 4;
            Console.WriteLine("In Main x is {0}", x);
            DisplayValueParameter(x);   
            Console.WriteLine("In Main x is {0}", x);

            Console.WriteLine("---------------------------------------------------------------------\n \n");



            //2. Reference  parameters - Declared with ref modifier
            int y = 4;
            Console.WriteLine("In Main y is {0}", y);
            DisplayReferenceParameter(ref y);
            Console.WriteLine("In Main y is {0}", y);

            Console.WriteLine("---------------------------------------------------------------------\n \n");

            //3. Output  parameters - Declared with out modifier
            int first, second;
            UseOfOutParameter(out first, out second);
            Console.WriteLine("After UseOfOutParameter first is {0}", first);
            Console.WriteLine("and  second is {0}", second);
            Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------------------\n \n");


            //4. Parameter arrays - Declared with params modifier
            string[] names = { "Mark","Paul","John","James","Ben"};
            DisplayStrings("Ginger");
            DisplayStrings("George", "Maria", "Martha");
            DisplayStrings(names);

            //5. Optional parameter - Make a parameter optional by providing a value for it in the method declaration
            DisplaySize(4,6); // using 2 arguments
            DisplaySize(4, 6, 8); // Using 3 arguments


            // TryParse Method - usage...
            UseofTryParse();


            //Method Overload - Methods are overloaded correctly when they have the SAME identifier but DIFFERENT parameter lists
            DisplayWithBorder("Jemal");


        }


        public static void DisplayValueParameter(int x)
        {
            x = 777;
            Console.WriteLine("In Method x, is {0} ", x);
            Console.ReadLine();
        }

        public static void DisplayReferenceParameter(ref int number)
        {
            number = 888;
            Console.WriteLine("In Method number, is {0} ", number);
            Console.ReadLine();
        }

        public static void UseOfOutParameter(out int one, out int two)
        {
            string s1;
            string s2;
            Console.WriteLine("Enter First Integer");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter Second Integer");
            s2 = Console.ReadLine();

            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s2);
        }

        private static void DisplayStrings(params string[] people)
        {
            foreach (string person in people)            
                Console.WriteLine("{0} ", person);
            Console.WriteLine("\n --------------------------");      
        }

        public static void UseofTryParse()
        {          
            int score;
            Console.WriteLine("Enter your Test Score >>");
            string str = Console.ReadLine();
            int.TryParse(str, out score);
            Console.WriteLine("You entered {0} ", score);
        }

        public static void DisplayWithBorder(string word)
        {
            const int extraStars = 4;
            const string SYMBOL = "*";

            int size = word.Length + extraStars;
            int i;
            for (i = 0; i < size; i++)
                Console.Write(SYMBOL);
            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            Console.ReadLine();

            for (i = 0; i < size; i++)
                Console.Write(SYMBOL);
            Console.WriteLine("\n\n");
            Console.ReadLine();

        }

        public static void DisplayWithBorder(int number)
        {
            // Get the code from Slide...
        }

        public static void DisplaySize(int length, int width, int height = 1)
        {
            int area = length * width * height;
            Console.WriteLine("The Size is {0}", area);
        }
    }
}
