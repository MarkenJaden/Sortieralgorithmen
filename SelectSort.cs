using System;
using System.Diagnostics;
using System.Globalization;

namespace Sortieralgorithmen
{
    class SelectSort
    {
        bool ChoseSort = false;
        CultureInfo culture = new CultureInfo("de-DE", false);
        Stopwatch stopWatch = new Stopwatch();

        public SelectSort()
        {
            while (!ChoseSort)
            {
                Console.WriteLine("Welchen Sortieralgorithmus möchtest du starten?");
                Console.WriteLine();
                Console.WriteLine("1 - BogoSort");
                Console.WriteLine();
                Console.WriteLine("2 - EasySort (QuickSort)");
                Console.WriteLine();
                Console.WriteLine("3 - SelectionSort");
                Console.WriteLine();
                Console.WriteLine("4 - BubbleSort");
                Console.WriteLine();
                Console.WriteLine("5 - QuickSort (naja, fast)");
                Console.WriteLine();

                String sort = Console.ReadLine();
                try
                {
                    switch (Int32.Parse(sort)) //Zahl, geht schneller und ist weniger aufwendig für den Rechner
                    {
                        case 1:
                            startBogoSort();
                            break;
                        case 2:
                            startEasySort();
                            break;
                        case 3:
                            startSelectionSort();
                            break;
                        case 4:
                            startBubbleSort();
                            break;
                        case 5:
                            startQuickSort();
                            break;
                    }
                }
                catch (Exception e) //Falls keine Zahl eingegeben wurde, überprüfe die Buchstaben
                {
                    if (culture.CompareInfo.IndexOf(sort, "bog", CompareOptions.IgnoreCase) >= 0)
                    {
                        startBogoSort();
                    }
                    else if (culture.CompareInfo.IndexOf(sort, "easy", CompareOptions.IgnoreCase) >= 0)
                    {
                        startEasySort();
                    }
                    else if (culture.CompareInfo.IndexOf(sort, "sel", CompareOptions.IgnoreCase) >= 0)
                    {
                        startSelectionSort();
                    }
                    else if (culture.CompareInfo.IndexOf(sort, "bub", CompareOptions.IgnoreCase) >= 0)
                    {
                        startBubbleSort();
                    }
                    else if (culture.CompareInfo.IndexOf(sort, "qui", CompareOptions.IgnoreCase) >= 0)
                    {
                        startQuickSort();
                    }
                    else
                    {
                        Console.WriteLine("Du hast keinen gültigen Sortieralgorithmus angegeben. Bitte gib einen Sortieralgorithmus ein.");
                    }

                }

            }
        }

        //In eigene Methoden aufgeteilt um doppelten Code zu vermeiden
        public int numbers()
        {
            ChoseSort = true;
            Console.WriteLine("Wie viele Zahlen sollen generiert werden?");
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        public void writeTime() //Zusatzaufgabe 2
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Zeit: " + elapsedTime);
            stopWatch.Reset();
        }

        public void startBogoSort()
        {
            BogoSort bg = new BogoSort();
            stopWatch.Start();
            if (bg.start(numbers()))
            {
                ChoseSort = false;
            }
            stopWatch.Stop();
            writeTime();
        }

        public void startEasySort()
        {
            EasySort es = new EasySort();
            stopWatch.Start();
            if (es.start(numbers()))
            {
                ChoseSort = false;
            }
            stopWatch.Stop();
            writeTime();
        }

        public void startSelectionSort()
        {
            SelectionSort ss = new SelectionSort();
            stopWatch.Start();
            if (ss.start(numbers()))
            {
                ChoseSort = false;
            }
            stopWatch.Stop();
            writeTime();
        }

        public void startBubbleSort()
        {
            BubbleSort bs = new BubbleSort();
            stopWatch.Start();
            if (bs.start(numbers()))
            {
                ChoseSort = false;
            }
            stopWatch.Stop();
            writeTime();
        }

        public void startQuickSort()
        {
            QuickSort qs = new QuickSort();
            stopWatch.Start();
            if (qs.start(numbers()))
            {
                ChoseSort = false;
            }
            stopWatch.Stop();
            writeTime();
        }
    }
}
