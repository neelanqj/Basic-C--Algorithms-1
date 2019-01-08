using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1To255();
            PrintOddInBetween1To255();
            PrintOddFrom1To255();

            PrintSum();

            int[] itarr = new int[]{1,3,-5,7,9,13};

            IteratingThroughAnArray(itarr);

            FindMax(itarr);

            GetAverage(itarr);

            // create an array with all numbers between 1 and 255
            List<int> arr = new List<int>();
            for(int i = 1; i<=255;i++) {
                arr.Add(i);
            }

            ArrayWithOddNumbers(arr.ToArray());

            GreaterThanY(arr.ToArray(), 250);

            SquareTheValues(itarr);

            itarr[3] = -10;
            EliminateNegativeNumbers(itarr);

            MinMaxandAverage(itarr);

            ShiftingValuesInAnArray(itarr);

            itarr[3] = -10;
            NumberToString(itarr);
        }

        // Print 1 - 255
        static void Print1To255(){
            Console.WriteLine("Print 1-255");
            for(int i=1; i<=255;i++) {
                Console.WriteLine(i);
            }
        }

        static void PrintOddInBetween1To255() {
            Console.WriteLine("Print Odd In Between 1-255");
            for(int i=2; i<255;i++) {
                if(i%2 != 0)
                    Console.WriteLine(i);
            }
        }

        static void PrintOddFrom1To255() {
            Console.WriteLine("Print Odd From 1-255");
            for(int i=1; i<=255;i++) {
                if(i%2 != 0)
                    Console.WriteLine(i);
            }
        }

        // Print Sum
        static void PrintSum(){
            Console.WriteLine(@"Print the numbers from 0 to 255, but this time, also print the sum of the numbers that have been printed so far. For example, your output should be something like this:
                                New number: 0 Sum: 0
                                New number: 1 Sum: 1
                                New Number: 2 Sum: 3
                                New number: 3 Sum: 6
                                New Number: 255 Sum: ___.
                                Do NOT use an array to do this exercise.");

            int sum = 0;
            for(int i=0; i<=255;i++){
                sum = sum + i;

                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        // Iterating through an Array
        static void IteratingThroughAnArray(int[] vals) {
            Console.WriteLine("Iterating through an Array");
            foreach(int elem in vals) {
                Console.WriteLine(elem);
            }
        }

        // Find Max
        static void FindMax(int[] vals) {
            Console.WriteLine("Find Max");
            int maxVal = vals[0];

            foreach(int elem in vals) {
                if (elem > maxVal)
                    maxVal = elem;
            }

            Console.WriteLine($"The maximum value is {maxVal}");
        }

        static void GetAverage(int[] vals) {
            Console.WriteLine("Get Average.");

            float sumOfArr = vals.Sum();
            float avg = sumOfArr/(float)vals.Length;
            Console.WriteLine($"The average of the array is {avg}");
        }

        static int[] ArrayWithOddNumbers(int[] vals) {
            Console.WriteLine("Array with Odd Numbers");

            List<int> newArray = new List<int>();

            foreach(int elem in vals) {
                if(elem%2 != 0)
                    newArray.Add(elem);
            }

            int[] newArrayFinal = newArray.ToArray();

            foreach(int elem in newArrayFinal) {
                Console.WriteLine(elem);
            }

            return newArrayFinal;
        }

        static int[] GreaterThanY(int[] vals, int y) {
            Console.WriteLine("Greater than Y.");

            List<int> greaterList = new List<int>();
            foreach(int elem in vals) {
                if(elem > y)
                    greaterList.Add(elem);
            }


            foreach(int elem in greaterList) {
                Console.WriteLine(elem);
            }
            return greaterList.ToArray();
        }

        static void SquareTheValues(int[] vals) {
            Console.WriteLine("Square the Values");

            for(int i=0; i< vals.Length; i++) {
                Console.WriteLine($"Old value {vals[i]} and Squared value {vals[i] * vals[i]}");

                vals[i] = vals[i] * vals[i];
            }
        }

        static void EliminateNegativeNumbers(int[] vals) {
            Console.WriteLine("Eliminate Negative Numbers");

            for(int i=0; i<vals.Length; i++) {
                Console.WriteLine($"The number is {vals[i]}");
                if(vals[i] < 0) vals[i] = 0;
                Console.WriteLine($"The number is now {vals[i]}\n\n");
            }
        }

        static void MinMaxandAverage(int[] vals) {
            Console.WriteLine("Min, Max, and Average");

            Console.WriteLine($"Min number {vals.Min()} and the max number is {vals.Max()} and the average number is {vals.Average()}");
        }

        static void ShiftingValuesInAnArray(int[] arr) {
            Console.WriteLine("Shifting the values in an array");
            int oldNum = 0;
            int newNum = 0;
            for (int i = arr.Length-1; i >= 0; i--) {
                 oldNum = arr[i];
                 arr[i] = newNum;
                 newNum = oldNum;
            }

            foreach(int elem in arr) {
                Console.WriteLine(elem);
            }
        }

        static string[] NumberToString(int[] vals) {
            Console.WriteLine("Number to String");
            string[] sVals = new string[vals.Length];

            for(int i=0;i<vals.Length;i++) {
                if( vals[i] < 0)
                    sVals[i] = "Dojo";
                else
                    sVals[i] = vals[i].ToString();
            }

            foreach(string elem in sVals) {
                Console.WriteLine(elem);
            }

            return sVals;
        }
    }
}
