using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {


        private static void MaopaoSort(int[] waitSort)
        {
            int lenth = waitSort.Length;
            for(int i =0;i<lenth;i++)
            {
                for(int j = i + 1;j<lenth;j++)
                {
                    if(waitSort[j] > waitSort[i] )
                    {
                        int temp = waitSort[j];
                        waitSort[j] = waitSort[i];
                        waitSort[i] = temp;
                    }
                }
            }
            string mes = "";
        }


        private static void SelectSort(int [] array)
        {
            int pos;
            for (int i = 0;i<array.Length;i++)
            {
                pos = i;
                for(int j = i+1;j<array.Length;j++)
                {
                    if(array[pos] < array[j])
                    {
                        pos = j;
                    }
                }
                if(pos != i)
                {
                    int temp = array[pos];
                    array[pos] = array[i];
                    array[i] = temp;
                }
            }
        }

        private static void InsetSort(int [] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    if(array[k] > array[k-1])
                    {
                        int temp = array[k];
                        array[k] = array[k - 1];
                        array[k - 1] = temp;
                    }
                }
            }
        }

        public static void Qsort(int[] num, int left, int right)
        {
            if (left < right)
            {
                int p = partition(num, left, right);
                Qsort(num, left, p - 1);
                Qsort(num, p + 1, right);
            }

        }

        public static int partition(int[] num, int left, int right)
        {
            int pivot = num[left];
            while (right > left)
            {
                while (left < right && num[right] >= pivot)
                {
                    right--;
                }
                exchenge(num, left, right);
                while (left < right && num[left] <= pivot)
                {
                    left++;
                }
                exchenge(num, left, right);
            }
            return left;
        }

        public static void exchenge(int[] num, int m, int n)
        {
            int temp = num[m];
            num[m] = num[n];
            num[n] = temp;
        }
        static void Main(string[] args)
        {
            int[] waitSort = { 1, 0, 12, 13, 14, 5, 6, 7, 8, 9, 10 };
            MaopaoSort(waitSort);

            int[] waitSort1 = { 1, 0, 12, 13, 14, 5, 6, 7, 8, 9, 10 };
            SelectSort(waitSort1);
        }
    }
}
