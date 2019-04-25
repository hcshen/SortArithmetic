using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = {2,10,8,1,4,3,6,5,11 };
            //Sort.BubbleSort(arry);
            Sort.SelectionSort(arry);
            for (int i=0;i<arry.Length;i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.ReadKey();
        }
    }
}
