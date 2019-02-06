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
            
            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            /*
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
            */
            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            
            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3, 8, 7};
            Console.WriteLine(findMedian(arr2));
            
            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            //int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2016;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadLine();

        }

        static void displayArray(int []arr)
        {
            Console.WriteLine();
            foreach(int n in arr)
            {
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
        static int maximumToys(int[] prices, int k)
        {
            try
            {
                //printing the original array
                Console.WriteLine("Here is the array that will be used to execute bubble sort algorithm:");
                for (int i = 0; i < prices.Length; i++)
                {
                    Console.Write(" " + prices[i]);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Here is the array after the execution of bubble sort algoritm:");
                //calling the method for sorting
                bubblesort(prices);
                //printing the array after bubble sort
                for (int i = 0; i < prices.Length; i++)
                {
                    Console.Write(" " + prices[i]);
                }
                Console.WriteLine(" ");
                if (k > 0)
                {
                    int count = 0;
                    for (int i = 0; i < prices.Length; i++)
                    {
                        if (prices[i] <= k)
                        {
                            k -= prices[i];
                            count++;
                        }

                    }
                    Console.WriteLine("The maximum toys that can be bought are:");
                    return count;
                }
                else
                {
                    Console.WriteLine("Please enter a appropriate value for money");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while executing maximumtoys() ! ");
            } // end catch
            return 0;
        }
        static void bubblesort(int[] bs_arr)
        {
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int j = 0; j < bs_arr.Length - i - 1; j++)
                {
                    if (bs_arr[j] > bs_arr[j + 1])
                    {
                        int temp = bs_arr[j];
                        bs_arr[j] = bs_arr[j + 1];
                        bs_arr[j + 1] = temp;
                    }
                }
            }
        }

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
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                
               for (int j = 0; j < grades.Length; j++)
               {
                    if (grades[j] >= 38 && grades[j] % 5 > 2)
                    {
                          grades[j] += 5 - grades[j] % 5;
                    }
           
               }
               return grades;     
            }
            catch
            {
                Console.WriteLine("Exception occured while computing grades");
            }
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            try
            {
                // check for valid input 
                if (arr.Length > 0)
                {
                    /*--------------Step 1: sort array -----------------*/
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

                    /*--------------Step 2: find the middle element in the sorted array -----------------*/
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

        //Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            try
            {
                if (arr.Length > 0)
                {
                    /*--------------Step 1: sort array -----------------*/
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

                    /*--------------Step 2: find the closest numbers-----------------*/
                    // declare a list to hold result sets
                    var result = new List<int> { };
                    // initialize minDiff by substrating index element 0 from 1 in the array
                    int minDiff = arr[1] - arr[0];
                  // start a loop from index element 2 to find  differences of adjacent  pairs to find the minimum difference
                    for (int i = 2; i < arr.Length; i++)
                    {
                        if (arr[i] - arr[i - 1] < minDiff)
                        {
                            // assign new value if minDiff if there is
                            minDiff = arr[i] - arr[i - 1];
                        }
                    }
                    // Loop through array and check for minimum difference equal to minDiff
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        // if adjacent  pairs equal to minDiff , add that pair to the result list
                        if (arr[j + 1] - arr[j] == minDiff)
                        {
                            result.Add(arr[j]);
                            result.Add(arr[j + 1]);
                        }
                    }
                    // return result list as an array
                    return result.ToArray();
                } // end if
                else
                {
                    Console.WriteLine("Please provide a valid input ! ");
                } // end else
            } // end try
            // catch bad input
            catch
            {
                Console.WriteLine("Exception occured while computing closestNumbers() !");
            } // end catch

            // return emty array as default
            return new int[] { };
        } //closestNumbers

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            try
            {
                // Check for valid input, if input is valid, apply logic
                if (year >= 1700 && year <= 2700)
                {
                    // initialize the 256th day of programer
                    int dayToFind = 256;
                    // initialize array arrDays to hold days in 12 months
                    int[] arrDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                   //Use Gregorian calendar
                    if (year >= 1919 && year <= 2700)
                    {
                        // leap year if divisible by 400, or divisible by 4 but not 100
                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        {
                            arrDays[1] = 29;
                        }
                    }
                    //Use Julian calendar
                    else if (year >= 1700 && year <= 1917)
                    {
                        //leap year if divisible by 4
                        if (year % 4 == 0)
                        {
                            arrDays[1] = 29;
                        }
                   }
                   // 1918 : special year with Feb has 15 days (29 - 14 = 15)
                    else
                    {
                        arrDays[1] = 15;
                    }
                    //sum of the days in each month  
                    int sumDays = 0;
                    //keep memory of which month we are in, not 0 indexing
                    int currMonth = 0;
                   // Initialize day & month for storing result
                    String day = "";
                    String month = "";

                    for (int i = 0; i < arrDays.Length; i++)
                    {
                        //Add sumDays with this currtMonth
                        sumDays += arrDays[i];
                        currMonth += 1;
                        //If dayToFind exceed, so it is the month .
                        if (sumDays > dayToFind)
                        {
                            break;
                        }
                    }
                   //subtract to get the result, with an offset of 1
                    int dayOfMonth = (arrDays[currMonth] - (sumDays - dayToFind)) - 1;
                    // Format Day
                    if (dayOfMonth < 10)
                    {
                        day = "0" + dayOfMonth.ToString();
                    }
                    else
                    {
                        day = dayOfMonth.ToString();
                    }
                    // Format Month
                    if (currMonth < 10)
                    {
                        month = "0" + currMonth.ToString();
                    }
                    else
                    {
                        month = currMonth.ToString();
                    }
                   // return result in DD.MM.YYYY format
                    return day + "." + month + "." + year;
                } // end if
                // display error message if input is invalid
                else
                {
                    Console.WriteLine("Please enter a valid year beetwem 1700 and 2700 !!!");
                } // end else
            }
            catch
            {
                Console.WriteLine("Exception occured while computing closestNumbers() !");
            } // end catch
            return "";
        } // end dayOfProgrammer
    }
}
