using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sortieralgorithmen
{
    class EasySort
    {
        public bool start(int i)
        {
            if (sortEasySort(generateRandomnumbers(i)))
            {
                return true;
            }
            return false;
        }

        public bool sortEasySort(int[] i)
        {
            ArrayList al = new ArrayList();
            al.AddRange(i); //ArrayList erhält alle Elemente vom übergebenen Array
            al.Sort(); //ArrayList wird mithilfe des QuickSort sortiert
            Console.WriteLine("Fertig!");
            foreach (int l in al)
            {
                Console.Write(l + ", ");
            }
            return true;
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
    }
}
