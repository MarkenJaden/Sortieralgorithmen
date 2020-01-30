using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sortieralgorithmen
{
    class QuickSort
    {
        public bool start(int i)
        {
            int[] arr = generateRandomnumbers(i);
            if (sortQuickSort(arr,0,arr.Length-1)) //Damit die Startbedingung erfüllt ist
            {
                return true;
            }
            return false;
        }

        public int[] generateRandomnumbers(int size)
        {
            int[] i = new int[size];
            Random random = new Random();
            for (int x = 0; x <= size - 1; x++)
            {
                int num = random.Next();
                Console.WriteLine("Zufallszahl " + x + ": " + num);
                i[x] = num;
            }
            return i;
        }

        public bool sortQuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end); //Sortieren der Hälfte

                sortQuickSort(arr, start, i - 1); //Hälfte in Hälfte teilen um die Hälfte zu sortieren
                                                  //und dabei immer wieder in Hälften teilen, indem die selbe Methode erneut aufgerufen wird, bis Bedingung der if-Anweisung erfüllt
                sortQuickSort(arr, i + 1, end); //Hälfte in Hälfte teilen um die Hälfte zu sortieren
            }
            //print(arr);
            return true;
        }

        public int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
        private void print(int[] i)
        {
            foreach (int x in i)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
        }
    }
}
