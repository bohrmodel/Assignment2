

using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int n = 7;
            PrintPatternAnyComplexity(n);
            PrintPatternLinearComplexity(n);
            //Self Reflection - It was easy to do this with nested for loop and the code was concise with simple nested loop.
            //However, attaining linear complexity was difficult as nested for loop gives O(n^2).
            //This one needs more challenge.

            Console.WriteLine("Question 2");
            int[] array1 = new int[] { 1, 3, 5, 4, 7 };
            int result = LongestSubSeq(array1);
            Console.WriteLine(result);
            //Self Reflection - This task was rather easy and it was done with one single for loop. 
            // I had to just update the increase streak so I used to variables.
            //This one needs more challenge.

            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5 };
            PrintTwoParts(array2);
            //Self Reflection - This task was rather easy and simple, just needed to figure out the index that separates the two potential arrays.
            // The key point is that you can do alot of thing as the array goes into only two sub arrays. With 3 or more, it will be way too complicated.
            //This one needs more challenge.

            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            int[] result2 = SortedSquares(array3);
            //Write code to print the result array here
            Console.Write("[ ");
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i]);
                if (i != result2.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
            //Self Reflection - This task was rather moderate.
            // The key point is that you use the Math library to get the absolute values.
            //In addition, you gotta move your first and end index forward and backward to fill the array while sorting at the same time.
            //Usual sort methods require more than O(n), so you had to fill in the array while sorting at the same time.

            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            //Write code to print the result array here
            Console.Write("[ ");
            for (int i = 0; i < intersect1.Length; i++)
            {
                Console.Write(intersect1[i]);
                if (i != intersect1.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
            //Self Reflection - This task was rather moderate and difficult.
            


            Console.WriteLine("Question 6");
            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine(UniqueOccurrences(arr));
            //Self Reflection - This task was rather moderate ~ difficult.
            //It is difficult for this exercise to attain the time complexity of o (n).
            //So you needed to use new data structure or other pre-written methods.
            //It was very challenging.

            /*
            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            List<String> ResultList = Ranges(numbers, lower, upper);
            //Write code to print list here
            */
            //Self Reflection - This task was difficult.
            // I could not complete this. This exercise gives an error so commented it out.



            Console.WriteLine("Question 8");
            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            string[] namesResult = UniqFolderNames(names);
            //Write code to print your result here
            //Self Reflection - This task was difficult.
            // I could not complete this. 


        }

        public static void PrintPatternAnyComplexity(int n)

        {
            try
            {
                //Write your code here;
                string star = "*";

                for (int i = 0; i < n; i ++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();
                }

                //Simple nested for loop does its job to print the triagnle shape with star.
                //Time complexity O (n^2) due to nested for loop.
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void PrintPatternLinearComplexity(int n)

        {
            try
            {
                //Write your code here;



            }
            catch (Exception)
            {

                throw;
            }

        }


        public static int LongestSubSeq(int[] nums)
        {
            try
            {
                //write your code here 
                int increase = 1, increaseToReturn = 1; // Important variable we going to use to determine the int to return.

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i+1] - nums[i] > 0)
                    {
                        increase++;
                    }
                    else
                    {
                        increaseToReturn = increase; // The biggest streak is saved to the variable increaseToReturn.
                        increase = 1; //Reset the variable increase to 1.
                    }
                }

                return increaseToReturn;
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
        public static void PrintTwoParts(int[] array2)
        {
            try
            {
                //Write your code here;
                int sum = 0, half, magicIndex = -1;
                //Variable magicIndex is the last index of the first array if it is separable into two arrays.

                for (int i = 0; i < array2.Length; i++)
                {
                    sum += array2[i];
                }

                if (sum %2 == 1) // if the sum amount of the given array is odd number, then there's no way to split in half. This is to shorten the time for these cases with sum amount being odd number.
                {
                    Console.WriteLine("False");
                }
                else
                {
                    half = sum / 2;
                    sum = 0;

                    for (int i = 0; i <array2.Length; i++)
                    {
                        sum += array2[i];
                        if (sum == half)
                        {
                            magicIndex = i;
                            break;
                        }
                    }
                }

                Console.Write("[ ");
                for (int i = 0; i <= magicIndex; i++)
                {
                    Console.Write(array2[i]); // Printing the element in the first array
                    if (i != magicIndex) // Condition to not print the comma for the last value in each array.
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" ]");

                Console.Write("[ ");

                for (int i = magicIndex + 1; i < array2.Length; i++)
                {
                    Console.Write(array2[i]);// Printing the element in the second array
                    if (i != array2.Length - 1) // Condition to not print the comma for the last value in each array.
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" ]");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static int[] SortedSquares(int[] A)
        {
            try
            {
                //Write Your Code Here
                int legnth = A.Length;

                int[] result = new int[legnth]; 
                //Making new array to store the new elements.

                int end = legnth - 1;
                int start = 0;
                for (int index = A.Length - 1; index >= 0; index--)
                {
                    int first = Math.Abs(A[start]); // variable first contains the absolute value of the beginning value in the given array
                    int last = Math.Abs(A[end]);// variable last contains the absolute value of the ending value in the given array
                    if (first > last)
                    {
                        result[index] = first * first; // Store the square of the first 
                        start++; // we move the first index accordingly.
                    }
                    else
                    {
                        result[index] = last * last;// Store the square of the last 
                        end--;// we move the end index accordingly.
                    }
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
                //Using hashsets.
                HashSet<int> table = new HashSet<int>();
                HashSet<int> result = new HashSet<int>();
                for (int i = 0; i < nums1.Length; i++)
                {
                    table.Add(nums1[i]); // Adding elements. 
                }
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (table.Contains(nums2[i]) && !result.Contains(nums2[i])) result.Add(nums2[i]);
                    //Adding elements if unique
                }


                return result.ToArray(); // Converting the hashset to array and return the array.
            }
            catch
            {
                throw;
            }

            return new int[] { };
        }


        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                //Write your code here;
                // using Enumerable and other methods.
                var counts = arr.ToLookup(x => x).Select(x => x.Count()).ToList();
                return counts.Count() == counts.Distinct().Count();

            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }

    }
}
