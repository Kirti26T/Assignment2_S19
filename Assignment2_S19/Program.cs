/* 
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
    Author: ISM6225 - Goup 2 
    Name : Kirti Tiwari, Vidya Sagar Reddy Gunnala, David Lam
    Date: 1/31/2019
    Comments: Assignment2_S19
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
*/


using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 10, 5, 6, 7 };
            int[] r = rotLeft(a, d);
            displayArray(r);
            /*
            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            */
            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3, 8, 7};
            Console.WriteLine(findMedian(arr2));
            Console.ReadLine();

            //// closest numbers
            //Console.WriteLine("\n\nClosest numbers");
            //int[] arr3 = { 5, 4, 3, 2 };
            //int[] r4 = closestNumbers(arr3);
            //displayArray(r4);

            //// Day of programmer
            //Console.WriteLine("\n\nDay of Programmer");
            //int year = 2017;
            //Console.WriteLine(dayOfProgrammer(year));

        }

        static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            try
            {
                // check for valid input 
                if (d > 0 && a.Length > 0)
                {
                    // Logic
                    // loop through d number left rotation on array
                    for (int i = 0; i < d; i++)
                    {
                        // assign temp to first element of array
                        int temp = a[0];
                        // loop through array from second element to last element
                        for (int j = 1; j < a.Length; j++)
                        {
                            // assign current index element to previous index element
                            a[j - 1] = a[j];
                        }
                        // assign last element of array equal temp
                        a[a.Length - 1] = temp;
                    }
                    return a;
                } // end if
                // Display error message if input is invalid
                else
                {
                    Console.WriteLine("Please provide a valid input ! ");
                } // end else
            } // end try
            catch
            {
                Console.WriteLine("Exception occured while computing rotLeft() ! ");
            } // end catch
            // return empty array as default
            return new int[] {};
        } // end rotLeft

        //// Complete the maximumToys function below.
        //static int maximumToys(int[] prices, int k)
        //{
        //    return 0;
        //}

        //// Complete the balancedSums function below.
        //static string balancedSums(List<int> arr)
        //{
        //    return "";
        //}

        //// Complete the missingNumbers function below.
        //static int[] missingNumbers(int[] arr, int[] brr)
        //{
        //    return new int[] { };
        //}


        //// Complete the gradingStudents function below.
        //static int[] gradingStudents(int[] grades)
        //{
        //    return new int[] { };
        //}

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            try
            {
                // check for valid input 
                if (arr.Length > 0)
                {
                    // First : need to sort array 
                    // Can I use this funtion ?????
                    //Array.Sort(arr);

                    // declare mid as middle element in the sorted array
                    int mid;
                    // declare min_position , temp
                    int min_position, temp;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        // initialize the min_position to the current index of array
                        min_position = i;
                        // check to see if the next element is smaller
                        for (int x = i + 1; x < arr.Length; x++)
                        {
                            // If the next element from the current min_position is smaller
                            if (arr[x] < arr[min_position])
                            {
                                //assign new min_position 
                                min_position = x;
                            }
                        } // End of inner for loop

                        // If the min_position does not equal the current element, swap
                        if (min_position != i)
                        {
                            temp = arr[i];
                            arr[i] = arr[min_position];
                            arr[min_position] = temp;
                        }
                    } // End of outer for loop

                    // array is already sorted up to here 
                    // return middle element in the sorted array as result 
                    return mid = arr[arr.Length / 2];
                }
                else
                {
                    Console.WriteLine("Please provide a valid input !");
                }
                
            } // end try
            catch
            {
                Console.WriteLine("Exception occured while computing findMedian() !");
            } // end catch

            // return 0 as defult 
            return 0;
        } // end findMedian

        //// Complete the closestNumbers function below.
        //static int[] closestNumbers(int[] arr)
        //{
        //    return new int[] { };
        //}

        //// Complete the dayOfProgrammer function below.
        //static string dayOfProgrammer(int year)
        //{
        //    return "";
        //}
    }
}
