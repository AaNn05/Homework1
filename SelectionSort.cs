using System;
using System.Collections.Generic;

namespace Homework1
{
    public static class SortingAlgorithms
    {
        public static void SelectionSort(int[] array)
        {
            SelectionSortHelper(array, array.Length);
        }

        private static void SelectionSortHelper(int[] array, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                int min = i;

                for(int j = i + 1; j < n; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;

            }
        }

        public static void InsertionSort(int[] array)
        {
            InsertionSortHelper(array, array.Length);
        }

        private static void InsertionSortHelper(int[] array, int n)
        {
            for(int i = 1; i < n; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > temp) 
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

    }
}
