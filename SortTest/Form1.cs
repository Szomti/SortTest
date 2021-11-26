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
        bool loaded = false;

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

        private int amountOfNumbers = 10000;

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
            if (loaded)
            {
                amountOfNumbers = (File.ReadAllLines("test.txt").Length);
            }
            int[] tabForSort = new int[amountOfNumbers];
            int i;
            int j;
            int x;
            int pmin;
            int pmax;
            int p;
            int piwot;
            if (loaded)
            {
                using (TextReader reader = File.OpenText("test.txt"))
                {
                    for (int ii = 0; ii <= File.ReadAllLines("test.txt").Length; ii++)
                    {
                        int numberFromFile = int.Parse(reader.ReadLine());
                        Debug.Write(numberFromFile);
                        tabForSort[ii] = numberFromFile;
                    }
                }
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (sortType=="insert") {
                if (!loaded)
                {
                    RandomNumbers.Seed();
                    for (i = 0; i < amountOfNumbers; i++)
                    {
                        tabForSort[i] = RandomNumbers.NextNumber() % 100;
                    }
                }

                for (j = amountOfNumbers - 2; j >= 0; j--)
                {
                    x = tabForSort[j];
                    i = j + 1;
                    while ((i < amountOfNumbers) && (x > tabForSort[i]))
                    {
                        tabForSort[i - 1] = tabForSort[i];
                        i++;
                    }
                    tabForSort[i - 1] = x;
                }
            }

            if (sortType=="bubble") {
                if (!loaded)
                {
                    RandomNumbers.Seed();
                    for (i = 0; i < amountOfNumbers; i++)
                    {
                        tabForSort[i] = RandomNumbers.NextNumber() % 100;
                    }
                }

                for (j = 0; j < amountOfNumbers - 1; j++)
                {
                    for (i = 0; i < amountOfNumbers - 1; i++)
                    {
                        if (tabForSort[i] > tabForSort[i + 1])
                        {
                            (tabForSort[i], tabForSort[i + 1]) = (tabForSort[i + 1], tabForSort[i]);
                        }
                    }
                }
            }
            if (sortType== "doubleBubble") {
                if (!loaded)
                {
                    RandomNumbers.Seed();
                    for (i = 0; i < amountOfNumbers; i++)
                    {
                        tabForSort[i] = RandomNumbers.NextNumber() % 100;
                    }
                }

                pmin = 0;
                pmax = amountOfNumbers - 2;
                do
                {
                    p = -1;
                    for (i = pmin; i <= pmax; i++)
                    {
                        if (tabForSort[i] > tabForSort[i + 1])
                        {
                            (tabForSort[i], tabForSort[i + 1]) = (tabForSort[i + 1], tabForSort[i]);
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
                        if (tabForSort[i] > tabForSort[i + 1])
                        {
                            (tabForSort[i], tabForSort[i + 1]) = (tabForSort[i + 1], tabForSort[i]);
                            p = i;
                        }
                    }
                    pmin = p + 1;
                } while (p >= 0);
            }
            if (sortType== "fast") {

                void fastSort(int left, int right)
                {
                    int i;
                    i = (left + right) / 2;
                    piwot = tabForSort[i];
                    tabForSort[i] = tabForSort[right];
                    for (j = i = left; i < right; i++)
                    {
                        if (tabForSort[i] < piwot)
                        {
                            (tabForSort[i], tabForSort[j]) = (tabForSort[j], tabForSort[i]);
                            j++;
                        }
                    }
                    tabForSort[right] = tabForSort[j];
                    tabForSort[j] = piwot;
                    if (left < j - 1)
                    {
                        fastSort(left, j - 1);
                    }
                    if (j + 1 < right)
                    {
                        fastSort(j + 1, right);
                    }
                }

                if (!loaded)
                {
                    RandomNumbers.Seed();
                    for (i = 0; i < amountOfNumbers; i++)
                    {
                        tabForSort[i] = RandomNumbers.NextNumber() % 100;
                    }
                }

                fastSort(0, amountOfNumbers - 1);
            }
            //Thread.Sleep(5000); // Delete this line later
            stopwatch.Stop();
            sortingTime.Text = "Time: "+(stopwatch.ElapsedMilliseconds).ToString()+" ms";
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            switch (loaded)
            {
                case true:
                    loadFile.ForeColor = Color.Red;
                    loaded = false;
                    break;
                case false:
                    loadFile.ForeColor = Color.Green;
                    loaded = true;
                    break;
            }
        }
    }
}
