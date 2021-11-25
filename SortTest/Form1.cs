using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sortType = "";

        private void instertSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortowanie Przez Wstawianie";
            sortType = "insert";
        }

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortowanie Bąbelkowe";
            sortType = "bubble";
        }

        private void doubleBubbleSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortownie Bąbelkowe Dwukierunkowe";
            sortType = "doubleBubble";
        }

        private void fastSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortowanie Szybkie";
            sortType = "fast";
        }

        private readonly int amountOfNumbers = 10000;

        internal static class RandomNumbers
        {
            private static System.Random r;

            public static int NextNumber()
            {
                if (r == null)
                    Seed();

                return r.Next();
            }

            public static int NextNumber(int ceiling)
            {
                if (r == null)
                    Seed();

                return r.Next(ceiling);
            }

            public static void Seed()
            {
                r = new System.Random();
            }

            public static void Seed(int seed)
            {
                r = new System.Random(seed);
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            ///////////////
            //Random here//
            ///////////////
            stopwatch.Start();
            if (sortType=="insert") {
                int[] d = new int[amountOfNumbers];
                int i;
                int j;
                int x;

                Console.Write(" Sortowanie przez wstawianie\n" + "-----------------------------\n" + "   (C)2005  Jerzy Walaszek\n\n" + "Przed sortowaniem:\n\n");

                // Najpierw wypełniamy tablicę d[] liczbami pseudolosowymi
                // a następnie wyświetlamy jej zawartość

                RandomNumbers.Seed();

                for (i = 0; i < amountOfNumbers; i++)
                {
                    d[i] = RandomNumbers.NextNumber() % 100;
                }
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");

                // Sortujemy

                for (j = amountOfNumbers - 2; j >= 0; j--)
                {
                    x = d[j];
                    i = j + 1;
                    while ((i < amountOfNumbers) && (x > d[i]))
                    {
                        d[i - 1] = d[i];
                        i++;
                    }
                    d[i - 1] = x;
                }

                // Wyświetlamy wynik sortowania

                Console.Write("{0,4}", "Po sortowaniu:\n\n");
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");
            }

            if (sortType=="bubble") {
                int[] d = new int[amountOfNumbers];
                int i;
                int j;

                Console.Write(" Sortowanie babelkowe\n" + "     WERSJA NR 1\n" + "----------------------\n" + "(C)2005 Jerzy Walaszek\n\n" + "Przed sortowaniem:\n\n");

                // Najpierw wypełniamy tablicę d[] liczbami pseudolosowymi
                // a następnie wyświetlamy jej zawartość

                RandomNumbers.Seed();

                for (i = 0; i < amountOfNumbers; i++)
                {
                    d[i] = RandomNumbers.NextNumber() % 100;
                }
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");

                // Sortujemy

                for (j = 0; j < amountOfNumbers - 1; j++)
                {
                    for (i = 0; i < amountOfNumbers - 1; i++)
                    {
                        if (d[i] > d[i + 1])
                        {
                            (d[i], d[i + 1]) = (d[i + 1], d[i]);
                        }
                    }
                }

                // Wyświetlamy wynik sortowania

                Console.Write("{0,4}", "Po sortowaniu:\n\n");
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");
            }
            if (sortType== "doubleBubble") {
                int[] d = new int[amountOfNumbers];
                int i;
                int pmin;
                int pmax;
                int p;

                Console.Write("Dwukierunkowe Sortowanie babelkowe\n" + "----------------------------------\n" + "     (C)2005  Jerzy Walaszek\n\n" + "Przed sortowaniem:\n\n");

                // Najpierw wypełniamy tablicę d[] liczbami pseudolosowymi
                // a następnie wyświetlamy jej zawartość

                RandomNumbers.Seed();

                for (i = 0; i < amountOfNumbers; i++)
                {
                    d[i] = RandomNumbers.NextNumber() % 100;
                }
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");

                // Sortujemy

                pmin = 0;
                pmax = amountOfNumbers - 2;
                do
                {
                    p = -1;
                    for (i = pmin; i <= pmax; i++)
                    {
                        if (d[i] > d[i + 1])
                        {
                            (d[i], d[i + 1]) = (d[i + 1], d[i]);
                            p = i;
                        }
                    }
                    if (p < 0)
                    {
                        break;
                    }
                    pmax = p - 1;
                    p = -1;
                    for (i = pmax; i >= pmin; i--)
                    {
                        if (d[i] > d[i + 1])
                        {
                            (d[i], d[i + 1]) = (d[i + 1], d[i]);
                            p = i;
                        }
                    }
                    pmin = p + 1;
                } while (p >= 0);

                // Wyświetlamy wynik sortowania

                Console.Write("{0,4}", "Po sortowaniu:\n\n");
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");
            }
        //////////////////////
        //Sorting types here//
        //////////////////////
        //Thread.Sleep(5000); // Delete this line later
        stopwatch.Stop();
        sortingTime.Text = (stopwatch.ElapsedMilliseconds).ToString()+" ms";
        }
    }
}
