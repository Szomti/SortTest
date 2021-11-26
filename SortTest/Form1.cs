using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            if (sortType== "fast") {
                int[] d = new int[amountOfNumbers];
                int i;
                int j;
                int piwot;

                void Sortuj_szybko(int lewy, int prawy)
                {
                    int i;
                    i = (lewy + prawy) / 2;
                    piwot = d[i];
                    d[i] = d[prawy];
                    for (j = i = lewy; i < prawy; i++)
                    {
                        if (d[i] < piwot)
                        {
                            (d[i], d[j]) = (d[j], d[i]);
                            j++;
                        }
                    }
                    d[prawy] = d[j];
                    d[j] = piwot;
                    if (lewy < j - 1)
                    {
                        Sortuj_szybko(lewy, j - 1);
                    }
                    if (j + 1 < prawy)
                    {
                        Sortuj_szybko(j + 1, prawy);
                    }
                }

                // Program główny
                //---------------

                RandomNumbers.Seed();

                Console.Write("   Sortowanie szybkie\n" + "------------------------\n" + " (C)2005 Jerzy Walaszek \n\n" + "Przed sortowaniem:\n\n");

                // Najpierw wypełniamy tablicę d[] liczbami pseudolosowymi
                // a następnie wyświetlamy jej zawartość

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

                Sortuj_szybko(0, amountOfNumbers - 1);

                // Wyświetlamy wynik sortowania

                Console.Write("{0,4}", "Po sortowaniu:\n\n");
                for (i = 0; i < amountOfNumbers; i++)
                {
                    Console.Write("{0,4}", d[i]);
                }
                Console.Write("{0,4}", "\n");

            }
            //Thread.Sleep(5000); // Delete this line later
            stopwatch.Stop();
        sortingTime.Text = (stopwatch.ElapsedMilliseconds).ToString()+" ms";
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            using (TextReader reader = File.OpenText("test.txt"))
            {
                for(int i=1;i <= File.ReadAllLines("test.txt").Length;i++)
                {
                    int x = int.Parse(reader.ReadLine());
                    Debug.Write(x);
                }
            }
        }
    }
}
