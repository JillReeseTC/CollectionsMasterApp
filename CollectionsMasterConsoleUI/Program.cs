using System;
using System.Collections.Generic;
using System.Numerics;

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
            Populater(array50);
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

            ReverseArray(array50);

            Console.WriteLine("---------THREE KILLER------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(array50);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array50);
            for (int counter = 0; counter < array50.Length - 1; counter++)
            {
                Console.Write($"{array50[counter]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> mrInts = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"The list capacity is {mrInts.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(mrInts);


            //Print the new capacity
            Console.WriteLine($"The list capacity after poplation is {mrInts.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userNumber = AskNumber();
            NumberChecker(mrInts, userNumber);
            Console.WriteLine();

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(mrInts);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            mrInts.Sort();
            foreach (var itemSort in mrInts)
            {
                Console.WriteLine($"{itemSort} ");
            }
            Console.WriteLine();

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] listArray50 = new int[50];
            int arrayCounter = 0;
            foreach (var listItem in mrInts)
            {
                listArray50[arrayCounter] = listItem;
                arrayCounter++;
            }

            //Clear the list
            mrInts.Clear();

            //However, that clear method may not work well in a method or other scoped area. 
            //A better way to clear it instantly is to re-instantiate:

            mrInts = new List<int>();


            #endregion
        }


        private static void ThreeKiller(int[] numbers)
        {
            Console.WriteLine("Multiple of three: ");

            List<int> threeKillList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 3 == 0) && (numbers[i] != 0))
                {
                    threeKillList.Add(numbers[i]);
                    numbers[i] = 0;
                }
            }
            Console.WriteLine($"ThreeKillList output numbers: ");
            foreach (var num3 in threeKillList)
            {
                Console.Write($"{num3} ");
            }
            Console.WriteLine();
        }


        private static void OddKiller(List<int> numberList)
        {
            Console.WriteLine("Multiple of three: ");

            List<int> oddKillList = new List<int>();
            List<int> evenList = new List<int>();

            foreach (var item in numberList)
            {
                if ((item % 2 == 1) && (item != 0))
                {
                    oddKillList.Add(item);
                    evenList.Add(0);
                }
                else
                {
                    evenList.Add(item);
                }
            }
            Console.WriteLine($"All even output numbers: ");
            foreach (var numEven in evenList)
            {
                Console.Write($"{numEven} ");
            }
            Console.WriteLine();
        }



        private static int AskNumber()
        {
            Console.WriteLine("What number will you search for in the number list?");
            Console.WriteLine($"Enter an integer between 0 and 50: ");
            var s = Console.ReadLine();
            int x;

            do
            {
                if (int.TryParse(s, out x))
                {
                    Console.WriteLine($"You entered a valid integer: {x}");
                }
                else
                {
                    Console.WriteLine($"Invalid Input. Try another integer:");
                    s = Console.ReadLine();
                }
            } while (!((x >= 0) && (x <= 50)));

            return x;
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (var item in numberList)
            {
                if (item == searchNumber)
                {
                    Console.WriteLine("Number is found!");
                }
                else
                {
                    Console.WriteLine("Number is not in list of numbers.");
                }
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (var popct = 0; popct < 50; popct++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
            Console.WriteLine();

        }

        private static void ReverseArray(int[] array)
        {
            int[] reverseArray50 = new int[50];
            for (int i = array.Length - 1; i > -1; i--)
            {
                reverseArray50[49 - i] = array[i];
            }

            //Print the first number of the array
            Console.WriteLine($"Last number of the array is: {array[array.Length - 1]}.");
            Console.WriteLine($"First number of the reverse array is: {reverseArray50[0]}.");

            //Print the last number of the array
            Console.WriteLine($"First number of the array is: {array[0]}.");
            Console.WriteLine($"Last number of the reverse array is: {reverseArray50[reverseArray50.Length - 1]}.");
            Console.WriteLine();
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
