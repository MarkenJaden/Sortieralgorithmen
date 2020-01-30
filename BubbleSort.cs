using System;
using System.Collections.Generic;
using System.Text;

namespace Sortieralgorithmen
{
    class BubbleSort
    {
        public bool start(int i)
        {
            if (sortBubbleSort(generateRandomnumbers(i)))
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

        public bool sortBubbleSort(int[] arr)
        {
            int t1 = 0;

            for (int i = 0; i < arr.Length; i++) //Solange i kleiner ist als die Länge der zu sortierenden Zahlen           V
            {                                                                                                              //Um durch alle stellen durchzugehen
                for (int j = 0; j < arr.Length - 1; j++) //Solange j kleiner ist als die Länge der sortierenden Zahlen -1   ^
                {
                    if (arr[j] > arr[j + 1]) //Falls das Array an der Stelle j größer ist als das Array an der Stelle j +1
                    {
                        t1 = arr[j + 1]; //Zahl wird temporär gespeichert, damit diese bei den folgenden Schritten nicht verschwindet
                        arr[j + 1] = arr[j]; //Zahl die offensichtlich größer ist als die darauf folgende wird eins nach vorn gesetzt
                        arr[j] = t1; //Zahl die temporär gespeichert wurde wird auf die Stelle, welche im vorherigen Schritt auf eine andere Stelle gesetzt wurde, gesetzt
                    }
                }
            }
            print(arr);
            return true;
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
