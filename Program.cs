using System;
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
        }
        
            

        static void Main(string[] args)
        {
        }
    }
}
