using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void changeArr(int[] arr) 
        {
            arr = new int[] { 10, 20, 30 };
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            changeArr(arr);
            Console.WriteLine(arr[0]);

        }
    }
}
