using System;
using System.Collections.Generic;
using System.Text;

namespace Sortieralgorithmen
{
    class SelectionSort
    {

        public bool start(int i)
        {
            if (sortSelectionSort(generateRandomnumbers(i)))
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

        public bool sortSelectionSort(int[] arr)
        {
            int t1, t2;
            for (int i = 0; i < arr.Length - 1; i++) //solange i kleiner ist als die Länge des Arrays
            {
                t2 = i;
                for (int j = i + 1; j < arr.Length; j++) //solange j kleiner ist als die Länge des Arrays
                {
                    if (arr[j] < arr[t2]) //Falls das Array an der Stelle j kleiner ist als das Array an der Stelle t2
                    {
                        t2 = j; //Vorläufiger Schritt um die Zahlen zu tauschen
                    }
                }
                t1 = arr[t2]; //Zahl wird temporär gespeichert, damit diese bei den folgenden Schritten nicht verschwindet
                arr[t2] = arr[i]; //i wird an die Stelle von t2 gesetzt, weil t2 jetzt j ist
                arr[i] = t1; //Zwischengespeicherte Zahl wird auf die gerade verschobene Stelle i gesetzt, damit die Zahl nicht doppelt im Array ist
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
