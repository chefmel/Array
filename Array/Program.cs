using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {   //Create and initialize in a single line an array with the following values: 1, 1, 2, 3, 5, 8.
            //Then loop through the array and print out each value.


            int[] array = new int []  { 1, 1, 2, 3, 5, 8 };

            foreach (int i in array)
            //print the array to the console

            Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
