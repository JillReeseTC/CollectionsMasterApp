using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Create an integer Array of size 50
            int[] array50 = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                array50[i] = rand.Next(0, 50);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Print the first number of the array
            Console.WriteLine($"First number of the array is: {array50[0]}.");

            //Print the last number of the array
            Console.WriteLine($"Last number of the array is: {array50[array50.Length - 1]}.");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter(array50);
            Console.WriteLine("-----------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(array50);
            foreach (var item in array50)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //Print the first number of the array
            Console.WriteLine($"First number of the array is: {array50[0]}.");

            //Print the last number of the array
            Console.WriteLine($"Last number of the array is: {array50[array50.Length - 1]}.");
            Console.WriteLine();


            Console.WriteLine("---------REVERSE CUSTOM------------");

            int[] reverseArray50 = new int[50];
           for (int i = array50.Length - 1; i > -1; i--)
            {
                reverseArray50[49 - i] = array50[i];  
            }

            //Print the first number of the array
            Console.WriteLine($"Last number of the array is: {array50[array50.Length - 1]}.");
            Console.WriteLine($"First number of the reverse array is: {reverseArray50[0]}.");

            //Print the last number of the array
            Console.WriteLine($"First number of the array is: {array50[0]}.");
            Console.WriteLine($"Last number of the reverse array is: {reverseArray50[reverseArray50.Length - 1]}.");
            Console.WriteLine();

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three: ");
            
            List<int> threeKillList = new List<int>();

            for (int i = 0; i < array50.Length; i++)
            {
                if ((array50[i] % 3 == 0) && (array50[i] != 0))
                {
                    threeKillList.Add(array50[i]);
                    array50[i] = 0;
                }
            }
            Console.WriteLine($"ThreeKillList output numbers: ");
            foreach (var num3 in threeKillList)
            {
                Console.Write($"{num3} ");
            }
            Console.WriteLine();

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array50);
            for (int counter = 0; counter < array50.Length -1; counter++)
            {
                Console.Write($"{array50[counter]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
