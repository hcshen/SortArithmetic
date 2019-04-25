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
        /// 冒泡排序
        /// </summary>
        /// <param name="arrayVal"></param>
        public static void BubbleSort(int[] arrayVal)
        {
            //极值的置尾
            //for (int i=0;i<arrayVal.Length;i++)
            //{
            //    for (int j= 0; j < arrayVal.Length - 1-i;j++)
            //    {
            //        if (arrayVal[j]>arrayVal[j+1])
            //        {
            //            int temp = arrayVal[j];
            //            arrayVal[j] = arrayVal[j+1];
            //            arrayVal[j+1] = temp;
            //        }
            //    }
            //}
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
    }
}
