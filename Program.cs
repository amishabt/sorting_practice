using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    /*
Author: Amisha Bhagat
Date: 2/28/2024
Comments: This C# Console Application code demonstrates sorting. No input
   is required for the script. It will execute without 
   input against two pre-populated arrays. 
*/
    internal class Program
    {
       
        static void Main(string[] args)

        {
            int[] given = { 3, 62, 5, 16, 4, 10 };
            Console.WriteLine("");
            Console.WriteLine("Here is the array after the sorting: ");
            sort(given);
            for (int i = 0; i < given.Length; i++) {
                Console.Write("  " + given[i]);
            }
            Console.WriteLine("");
        }

           
        

        static void sort(int[] given)
        {
            for (int i = 0; i < given.Length-1; i++)
            {
                for (int j = i; j < given.Length; j++)
                {
                    if (given[i] > given[j])
                    {
                        // Here you will swap temp and bs_arr[x]
                        // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                        int temp = given[i];
                        given[i] = given[j];
                        given[j] = temp;
                    } 
                }
            }
        }
    }
}
