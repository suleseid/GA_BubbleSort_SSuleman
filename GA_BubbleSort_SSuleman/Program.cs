using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BubbleSort_SSuleman
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {

            int size = 15; //Change the size of array as needed
            int minValue = 5; //Change the minValue as needed
            int maxValue = 150; //Change the maxValue as needed

            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

            //To dissplay our array in it's unsorted form

            Console.WriteLine("Unsorted: ");
            PrintArray(randomArray);

            //Lets call our bubble sort method
            BubbleSort(randomArray);

            //Let's display our method after it has been Sorted 

            Console.WriteLine("\nSorted: ");
            PrintArray(randomArray);

        }

        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if(size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }
            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            } 
            return arr;
        }
        //A method that implements the bubble Sort algorithm
       static void BubbleSort(int[] arr)
       {

            //Get the length of the input array
            int arrayLength = arr.Length;

            //To initialize the flag to track whether any swaps occured inthe pass
            bool swapOccured = true;

            //Contiue iteratiing until no swaps occur in a pass
            //using a loop
            while (swapOccured)
            {
                //Reset the swap flag at start of each pass
                swapOccured = false;

                //Iterating through the array elements frrom the first to the second-to-last element 
                //using for loop

                for (int i = 0; i < arrayLength - 1; i++)
                {

                    //Compare the current element with the next element
                    if (arr[i] > arr[i + 1])
                    {
                        //Swap the elementsif they are out of order
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        //The swap flag to true to indicate a swap occured
                        swapOccured = true;
                    }
                }

             // To reduce the size of the array by one after each pass
            // This is because the last element of each pass is already in its correct position

                arrayLength--;
            }
       }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
