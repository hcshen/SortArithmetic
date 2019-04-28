using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class Sort
    {
        /// <summary>
        /// 冒泡排序1
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void BubbleSort(int[] arrayVal)
        {
            //极值的置尾
            for (int i = 0; i < arrayVal.Length; i++)
            {
                for (int j = 0; j < arrayVal.Length - 1 - i; j++)
                {
                    if (arrayVal[j] > arrayVal[j + 1])
                    {
                        int temp = arrayVal[j];
                        arrayVal[j] = arrayVal[j + 1];
                        arrayVal[j + 1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 冒泡排序2
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void BubbleSort_2(int[] arrayVal)
        {            
            //极值的置顶
            for (int i = 0; i < arrayVal.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayVal.Length; j++)
                {
                    if (arrayVal[i] > arrayVal[j])
                    {
                        int temp = arrayVal[i];
                        arrayVal[i] = arrayVal[j];
                        arrayVal[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void SelectionSort(int[] arrayVal)
        {
            for (int i=0;i<arrayVal.Length;i++)
            {
                int keyindex = i;
                for (int j=keyindex+1;j<arrayVal.Length;j++)
                {
                    if (arrayVal[j]<arrayVal[keyindex])
                    {
                        keyindex = j;
                    }
                }
                int temp = arrayVal[i];
                arrayVal[i] = arrayVal[keyindex];
                arrayVal[keyindex] = temp;
            }

        }
        /// <summary>
        /// 插入排序法1
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void InsertionSort(int[] arrayVal)
        {
            for(int i = 1; i < arrayVal.Length; i++)
            {
                int current = arrayVal[i];
                int insertindex = i;               
                for (int j=i-1;j>=0&&current < arrayVal[j]; j--)
                {
                    arrayVal[j + 1] = arrayVal[j];
                    insertindex = j;
                }               
                arrayVal[insertindex] = current;
            }
        }
        /// <summary>
        /// 插入排序法2
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void InsertionSort_2(int[] arrayVal)
        {
            for (int i = 1; i < arrayVal.Length; i++)
            {
                int current = arrayVal[i];
                int insertindex = i - 1;
                while (insertindex >= 0 && arrayVal[insertindex] > current)
                {
                    arrayVal[insertindex + 1] = arrayVal[insertindex];
                    insertindex--;
                }
                arrayVal[insertindex+1] = current;
            }
        }
    }
}
