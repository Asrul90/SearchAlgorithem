﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithem
{
     class Program
    {
        // array to be searched
        int[] arr = new int[20];
        // 
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("eter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20 ))
                    break;
                else
                    Console.WriteLine("\nArray shaould have minumun 1 and maximunm 20 elements.\n");
            }
            // accept array elements 
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("enter array elements");
            Console.WriteLine("------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searhed
                Console.Write("\nEnter elements wants you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = 0;

                //obtain the index of the midle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid = 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item > arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else 

            }
        }
        
            

        static void Main(string[] args)
        {
        }
    }
}
