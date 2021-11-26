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
        private int amountOfNumbers;
        long fastestSortTimeMS = 2147483647;
        long slowestSortTimeMS = -2147483647;

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

        private void heapSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortowanie Przez Kopcowanie";
            sortType = "heap";
        }

        private void merchSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Sortowanie Przez Scalanie";
            sortType = "merge";
        }

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
            else
            {
                amountOfNumbers = 10000;
            }
            int[] tabForSort = new int[amountOfNumbers];
            int i; // variable for "for"
            int j; // variable for "for"
            int currentNumber;
            int positionMin;
            int positionMax;
            int currentPosition;
            int piwot;
            if (loaded)
            {
                using (TextReader reader = File.OpenText("test.txt"))
                {
                    for (int ii = 0; ii < File.ReadAllLines("test.txt").Length; ii++)
                    {
                        int numberFromFile = int.Parse(reader.ReadLine());
                        tabForSort[ii] = numberFromFile;
                    }
                }
            }
            else {
                RandomNumbers.Seed();
                for (i = 0; i < amountOfNumbers; i++)
                {
                    tabForSort[i] = RandomNumbers.NextNumber() % amountOfNumbers;
                }
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (sortType=="insert") {
                for (j = amountOfNumbers - 2; j >= 0; j--)
                {
                    currentNumber = tabForSort[j];
                    i = j + 1;
                    while ((i < amountOfNumbers) && (currentNumber > tabForSort[i]))
                    {
                        tabForSort[i - 1] = tabForSort[i];
                        i++;
                    }
                    tabForSort[i - 1] = currentNumber;
                }
            }

            if (sortType=="bubble") {
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
                positionMin = 0;
                positionMax = amountOfNumbers - 2;
                do
                {
                    currentPosition = -1;
                    for (i = positionMin; i <= positionMax; i++)
                    {
                        if (tabForSort[i] > tabForSort[i + 1])
                        {
                            (tabForSort[i], tabForSort[i + 1]) = (tabForSort[i + 1], tabForSort[i]);
                            currentPosition = i;
                        }
                    }
                    if (currentPosition < 0)
                    {
                        break;
                    }
                    positionMax = currentPosition - 1;
                    currentPosition = -1;
                    for (i = positionMax; i >= positionMin; i--)
                    {
                        if (tabForSort[i] > tabForSort[i + 1])
                        {
                            (tabForSort[i], tabForSort[i + 1]) = (tabForSort[i + 1], tabForSort[i]);
                            currentPosition = i;
                        }
                    }
                    positionMin = currentPosition + 1;
                } while (currentPosition >= 0);
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

                fastSort(0, amountOfNumbers - 1);
            }
            if(sortType == "heap") {
            
            }
            if(sortType == "merge") {
                
            }
            stopwatch.Stop();
            sortingTime.Text = "Time: "+(stopwatch.ElapsedMilliseconds).ToString()+" ms";
            if (stopwatch.ElapsedMilliseconds < fastestSortTimeMS)
            {
                fastestSortTime.Text = "Fastest\n" + currentSort.Text + "\nTime: " + stopwatch.ElapsedMilliseconds + " ms";
                fastestSortTimeMS = stopwatch.ElapsedMilliseconds;
            }
            if (stopwatch.ElapsedMilliseconds > slowestSortTimeMS)
            {
                slowestSortTime.Text = "Slowest\n" + currentSort.Text + "\nTime: " + stopwatch.ElapsedMilliseconds + " ms";
                slowestSortTimeMS = stopwatch.ElapsedMilliseconds;
            }
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
