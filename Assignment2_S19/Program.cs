/* 
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
    Author: ISM6225 - Goup 2 
    Name : Kirti Tiwari, Vidya Sagar Reddy Gunnala, David Lam
    Date: 1/31/2019
    Comments: Assignment2_S19
    GitHub URL: https://github.com/Kirti26T/Assignment2_S19
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
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.WriteLine("------------------------------------------------");

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1,2,3 };
            Console.WriteLine(balancedSums(arr));
            Console.WriteLine("------------------------------------------------");

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            //int[] arr1 = { 7, 2, 5, 3, 5, 3 };
            //int[] brr  = { 7, 2, 5, 4, 6, 3, 5, 3 };
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3, 8, 7 };
            Console.WriteLine(findMedian(arr2));
            Console.WriteLine("------------------------------------------------");

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            //int[] arr3 = { 5, 4, 3, 2};
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2016;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadLine();

            /*
             ------------------------------------------------------------------------------------------------------------
             Group-reflection:
             Overall, the assignment is quite a good introduction about algorithms and problem solving. 
             It really forces students to think on algorithms since there were couple questions really challenging on the logic, 
             those problems were a good practice for us to familiarize ourselves with problem solving and algorithms. 
             This is also a good chance for us as students to learn to work as a team using GitHub as source control tool. 
             It will be helpful if we have an optional bonus question to practice more problems as well as make up for any missing points if needed. 
             ------------------------------------------------------------------------------------------------------------
            */

        }

        //displayArray
        static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        } //end displayArray

        // bubblesort method to sort the arrays
        static void bubblesort(int[] bs_arr)
        {
            //Loop through array to comapre adjacent elements
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int j = 0; j < bs_arr.Length - i - 1; j++)
                {
                    //compare the adjacent elements, swap if the next element is less
                    if (bs_arr[j] > bs_arr[j + 1])
                    {
                        int temp = bs_arr[j];
                        bs_arr[j] = bs_arr[j + 1];
                        bs_arr[j + 1] = temp;
                    } // end if
                }// end for
            } // end for
        } // end bubblesort

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

        // Complete the maximumToys function below.
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
                //Array.Sort(prices);

                //printing the array after bubble sort
                for (int i = 0; i < prices.Length; i++)
                {
                    Console.Write(" " + prices[i]);
                }
                Console.WriteLine(" ");

                // check for valid inputs
                if (k > 0 && prices.Length > 0)
                {
                    // initialize count to 0 
                    int count = 0;
                    // Loop through array
                    for (int i = 0; i < prices.Length; i++)
                    {
                        // if element is less than or equal to money, set money = money - that element value 
                        // and inscrease count by 1 
                        if (prices[i] <= k)
                        {
                            k -= prices[i];
                            count++;
                        } // end if
                    } // end for
                    // Display result
                    Console.WriteLine("The maximum toys that can be bought are:");
                    return count;
                } // end if
                else // display error message if invalid inputs
                {
                    Console.WriteLine("Please enter a appropriate value for money");
                } // end else
            }
            catch
            {
                Console.WriteLine("Exception occured while executing maximumtoys() ! ");
            } // end catch

            return 0;
        } // end maximumToys

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            try
            {
                // Intinalize count  = 0 use to check for sum mactch later
                int count = 0;

                // Initialize n as list size -1
                int n = arr.Count - 1;

                // check for  valid imput 
                if (n >= 0)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        // set sum1 and sum2 to be 0 as sum  of left and right of array
                        int sum1 = 0;
                        int sum2 = 0;

                        // Based on the index get the sum of the left elemnts of the array
                        for (int j = 0; j < i; j++)
                        {
                            sum1 += arr[j];

                        }//end of for loop to calculate sum of left elements

                        // Based on the index get the sum of the right elemnts of the array
                        for (int k = i + 1; k <= n; k++)
                        {
                            sum2 += arr[k];

                        }//end of for loop to calculate sum of right elements

                         // Compare sum of both the sides derived above
                        if (sum1 == sum2)
                        {
                            count++; // Increment count by 1 if the sum matches
                        }
                    }//end of for loop for which calculates sum and compares
                    
                    // If count >0 then return "YES" else "NO" to show if the element is found or not.
                    if (count != 0)
                    {
                        return "YES";
                    } // end if
                    else
                    {
                        return "NO";
                    } // en else
                } // end if
                // display error message if invalid inputs
                else
                {
                    Console.WriteLine("Please provide at least one element in the array !");

                } // end else

                // return default result
                return "";

            } // end try 
            catch
            {
                Console.WriteLine("Exception occured while executing balancedSums() ! ");
            } // end catch

            // return default result
            return "";
        } // end balancedSums

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            try
            {
                bubblesort(brr); // Sort array brr by calling bubble sort method
                int b_len = brr.Length; //get length of the array brr

                // check difference between maximum and minimum numbers of the array
                int minnum = brr[0];
                int maxnum = brr[b_len - 1];
                int Diff = maxnum - minnum;
                //Console.WriteLine("Diff is :" + Diff);

                // if the difference between max and min numbers of the array is < 101 
                // end the length of the original array is more than the length of the missing array
                // then execute below statements
                if (Diff < 101 && brr.Length > arr.Length)
                {
                    bubblesort(arr); // Sort array arr by calling bubble sort method
                    int a_len = arr.Length; // get length of array arr

                    List<int> numbers = new List<int>(); // create list for storing indexes for the numbers which are available in arr and brr
                    List<int> unq_num = new List<int>(); // create list for storing unique number
                    int[] missing_num = new int[b_len - a_len]; // array to store missing numbers

                    int counter = 0; // Initialize Counter to be 0

                    for (int i = 0; i < b_len; i++)// start of i loop for brr
                    {
                        int index = 1;// set index to 1
                        int flag = 0;
                        for (int j = 0; j < a_len; j++) // start of j loop for arr
                        {
                            if (!numbers.Contains(index)) // check if index of the number from array brr is already in the list
                            {
                                if (brr[i] == arr[j]) // check if element is present in both the arrays 
                                {
                                    numbers.Add(index);// if yes then add the index to numbers list so that the element at that position is not considered again
                                    flag = 1;// set flag to 1
                                }// end of if for comparision of the numbers in 2 arrays
                                break;
                            }// end of if for numbers list in which indexes are added
                            index++;
                        }// end of j loop for arr
                      
                        if (flag == 0) // check for the remaining elements of brr for which no match was found or frequency dint match. flag will be 0 for them
                        {
                            missing_num[counter] = brr[i];// add those number to missing_num array
                            counter++;// increment counter to add next number
                        }// end of if for adding missing numbers
                    }// end of i loop for brr

                    /*--------to remove duplicate values of missing numbers-----------*/
                    int[] freq = new int[missing_num.Length];
                    for (int k = 0; k < missing_num.Length; k++)
                    {
                        freq[k] = -1;// Set frequency to -1
                    }

                    // to check if the number is repeated in the array and set frequency to 0
                    for (int k = 0; k < missing_num.Length; k++)
                    {
                        int count = 1;
                        for (int p = k + 1; p < missing_num.Length; p++)
                        {
                            if (missing_num[k] == missing_num[p]) // To check if the number occurs again in the array
                            {
                                count = count + 1;
                                freq[p] = 0; // Set freq to 0 if the number is found again
                            }// end of if for comparing numbers and set freq to 0 if the number is found again
                        }// end of for loop 
                    } // end of for loop


                    /*----------load unique numbers only-----------*/
                    for (int k = 0; k < missing_num.Length; k++)//start of for loop for unique numbers
                    {
                        if (freq[k] != 0) // check for unique numbers
                        {
                            unq_num.Add(missing_num[k]);// add the numbers to the list unq_num

                        }// end of if got adding unique numbers
                    }//end of for loop for unique numbers
                    return unq_num.ToArray(); // change list to array
                }
                else // if the difference between max and min numbers of the array brr is > 100 then display below message to the user
                {
                    Console.WriteLine("Differnce between Maximum and Minimun numbers in the array is " + Diff + " which is greater than 100. Please enter elemnets having difference less than or equal to 100");
                } // end of else for differnce > 100
            } // end try
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while computing computeFrequency():" + e.Message);
            } // end catch
            // return default result
            return new int[] { };
        } // end missingNumbers

        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                // check for valid input, then apply logic
                if (grades.Length > 0)
                {
                    // loop through array 
                    for (int j = 0; j < grades.Length; j++)
                    {
                        //If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
                        //Otherwise If grade less than 38, no rounding occurs 
                        if (grades[j] >= 38 && grades[j] % 5 > 2)
                        {
                            grades[j] += 5 - grades[j] % 5; //round grade up to the next multiple of 5.
                        } // end if
                    } // end for
                      // return grades as  result
                    return grades;
                } // end if
                else
                {
                    Console.WriteLine("Please provide a valid input !!!");
                } // end else

            } // end try
            catch
            {
                Console.WriteLine("Exception occured while computing grades");
            } // end catch

            // return default result
            return new int[] { };
        } // end gradingStudents

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            try
            {
                // find the middle element in the sorted array
                // check for valid input 
                if (arr.Length > 0)
                {
                    /*--------------Step 1: sort array -----------------*/
                    // declare mid as middle element in the sorted array
                    int mid;
                    bubblesort(arr); // array is already sorted up to here 

                    /*--------------Step 2: find the middle element in the sorted array -----------------*/
                    // return middle element in the sorted array as result 
                    Console.WriteLine();
                    return mid = arr[arr.Length / 2];
                } // end if
                else
                {
                    Console.WriteLine("Please provide a valid input !");
                } // end else
                
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
                // check for valid input
                if (arr.Length > 1)
                {
                    /*--------------Step 1: sort array -----------------*/
                    bubblesort(arr); // array is already sorted up to here 

                    /*--------------Step 2: find the closest numbers-----------------*/
                    // declare a list to hold result sets
                    List<int> result = new List<int> { };

                    // initialize minDiff by substrating index element 0 from 1 in the array
                    int minDiff = arr[1] - arr[0];

                    // start a loop from index element 2 to find  differences of adjacent  pairs to find the minimum difference
                    for (int i = 2; i < arr.Length; i++)
                    {
                        if (arr[i] - arr[i - 1] < minDiff)
                        {
                            // assign new value if minDiff if there is
                            minDiff = arr[i] - arr[i - 1];
                        } // end if
                    } // end for

                    // Loop through array and check for minimum difference equal to minDiff
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        // if adjacent  pairs equal to minDiff , add that pair to the result list
                        if (arr[j + 1] - arr[j] == minDiff)
                        {
                            result.Add(arr[j]);
                            result.Add(arr[j + 1]);
                        } // end if
                    } // end for

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
        } // end closestNumbers

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
                        } // end if
                    } // end if
                    //Use Julian calendar
                    else if (year >= 1700 && year <= 1917)
                    {
                        //leap year if divisible by 4
                        if (year % 4 == 0)
                        {
                            arrDays[1] = 29;
                        } // end if
                   } // end else if
                   // 1918 : special year with Feb has 15 days (29 - 14 = 15)
                    else
                    {
                        arrDays[1] = 15;
                    } // end else
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
                        } // end if
                    }
                   //subtract to get the result, with an offset of 1
                    int dayOfMonth = (arrDays[currMonth] - (sumDays - dayToFind)) - 1;

                    // Format Day, add 0 if dayOfMonth < 10
                    if (dayOfMonth < 10)
                    {
                        day = "0" + dayOfMonth.ToString();
                    } // en if
                    else
                    {
                        day = dayOfMonth.ToString();
                    } // end else

                    // Format Month , add 0 if currMonth < 10
                    if (currMonth < 10)
                    {
                        month = "0" + currMonth.ToString();
                    } // end if
                    else
                    {
                        month = currMonth.ToString();
                    } // end else

                    // return result in DD.MM.YYYY format
                    Console.WriteLine();
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
