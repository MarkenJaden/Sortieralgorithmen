using System;
using System.Collections;

namespace Sortieralgorithmen
{
    class BogoSort
    {

        public bool start(int i)
        {
            if (sortBogoSort(generateRandomnumbers(i)))
            {
                return true;
            }
            return false;
        }

        public bool sortBogoSort(int[] i)
        {
            int counter = 0;
            Console.WriteLine("Sortiert werden " + i.Length + " Elemente...");
            while (!isSorted(i))
            {
                shuffle(i); //Würfelt die Zahlen so lange durcheinander und überprüft sie anschließend bis es passt
                counter++;
                Console.WriteLine("Counter: " + counter);
            }
            Console.WriteLine("Lösung gefunden! (insgesamt " + counter + " Versuche)");
            print(i);
            return true;
        }

        public int[] generateRandomnumbers(int size)
        {
            int[] i = new int[size];
            Random random = new Random();
            for (int j = 0; j <= size - 1; j++)
            {
                int num = random.Next();
                Console.WriteLine("Zufallszahl " + j + ": " + num);
                i[j] = num;
            }
            return i;
        }

        private void print(int[] i)
        {
            foreach (int j in i)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
        }

        private void shuffle(int[] i)
        {
            Random random = new Random();
            for (int j = 0; j < i.Length; j++)
            {
                int index1 = (int)(random.NextDouble() * i.Length),
                    index2 = (int)(random.NextDouble() * i.Length);
                int a = i[index1];
                i[index1] = i[index2];
                i[index2] = a;
            }
        }

        private bool isSorted(int[] i)
        {
            for (int j = 0; j < i.Length - 1; j++)
            {
                if (i[j] > i[j + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
