using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //caculate average in Array and print to screen number > average
            /*int[] n = new int[5];
            int sum = 0;
            int average = 0;
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("enter your number " + (i+1));
                n[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n.Length; i++)
            {
                sum=sum+n[i];
            }
            average = sum/n.Length;
            Console.WriteLine("Average is: "+average);
            int p = 0;
            for(int i = 0; i < n.Length; i++)
            {
                if (n[i]>average)
                {
                    p++;
                    Console.WriteLine("{0}.number  {1} ",p,n[i]);
                }
            }*/
            //-----------------------------------------//
            //find MIN,MAX
            /*int max = n[0];
            int min = n[0];
            for(int i =0; i<n.Length; i++)
            {
                if (n[i]  > max)
                {
                    max = n[i];
                    Console.WriteLine("max"+n.Max());
                }else if (n[i]<min){
                    min = n[i];
                    Console.WriteLine("min"+n.Min());
                }
            }*/
            //---------------------------------------------//

            //order Number (Sort algorithm)
            Console.WriteLine("How many numbers do you want: ");
            int x = Convert.ToInt32(Console.ReadLine());//convert datatype to int

            int[] n = new int[x];//create new Array
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Please enter your number");
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n.Length; j++)
            {
                for (int i = 0; i < n.Length - 1; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        int temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;
                    }
                    Console.WriteLine("-----------------------");
                    for (int t = 0; t < n.Length; t++)
                    {
                        Console.Write(" " + n[t]);
                    }
                    Console.WriteLine();
                }
            }
            /*Console.WriteLine("-----------------------");
            for(int t = 0; t < n.Length; t++)
            {
                Console.Write(" " + n[t]);
            }
            Console.WriteLine();*/
        }
    }
}
