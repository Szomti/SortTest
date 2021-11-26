using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        long fastestSortTimeMS = long.MaxValue;
        long slowestSortTimeMS = long.MinValue;
        int executeAmountVal = 1;
        string filePath = string.Empty;

        private void instertSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Insertion Sort";
            sortType = "insert";
        }

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Bubble Sort";
            sortType = "bubble";
        }

        private void doubleBubbleSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Bidirectional Bubble Sort";
            sortType = "doubleBubble";
        }

        private void quickSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Quick Sort";
            sortType = "quick";
        }

        private void heapSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Heap Sort";
            sortType = "heap";
        }

        private void merchSort_Click(object sender, EventArgs e)
        {
            currentSort.Text = "Merge Sort";
            sortType = "merge";
        }

        internal static class RandomNumbers
        {
            private static Random r;

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
                r = new Random();
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                amountOfNumbers = (File.ReadAllLines(filePath).Length);
            }
            else
            {
                amountOfNumbers = 10000;
            }
            int[] tabForSort = new int[amountOfNumbers];
            int[] p = new int[amountOfNumbers];
            if (sortType == "heap")
            {
                tabForSort = new int[amountOfNumbers + 1];
            }
            int i; // variable for "for"
            int j; // variable for "for"
            int k;
            int m;
            int ii;
            int currentNumber;
            int positionMin;
            int positionMax;
            int currentPosition;
            int piwot;
            if (executeAmount.Text != null || executeAmount.Text != "")
            {
                executeAmountVal = int.Parse(executeAmount.Text);
            }
            else
            {
                executeAmountVal = 1;
            }
            void desort()
            {
                if (loaded)
                {
                    stateOfApp.Text = "File:\n"+Path.GetFileName(filePath);
                    using (TextReader reader = File.OpenText(filePath))
                    {
                        for (ii = 0; ii < File.ReadAllLines(filePath).Length; ii++)
                        {
                            int numberFromFile = int.Parse(reader.ReadLine());
                            tabForSort[ii] = numberFromFile;
                        }
                    }
                }
                else
                {
                    stateOfApp.Text = "File:\n" + "Not Found";
                    RandomNumbers.Seed();
                    for (i = 0; i < amountOfNumbers; i++)
                    {
                        tabForSort[i] = RandomNumbers.NextNumber() % amountOfNumbers;
                    }
                }
            }

            var stopwatch = new Stopwatch();
            void sortTime(long sortingTimeMS)
            {
                sortingTime.Text = "Time: " + (sortingTimeMS).ToString() + " ms";
                if (sortingTimeMS < fastestSortTimeMS)
                {
                    fastestSortTime.Text = "Fastest\n" + currentSort.Text + "\nTime: " + sortingTimeMS + " ms";
                    fastestSortTimeMS = sortingTimeMS;
                }
                if (sortingTimeMS > slowestSortTimeMS)
                {
                    slowestSortTime.Text = "Slowest\n" + currentSort.Text + "\nTime: " + sortingTimeMS + " ms";
                    slowestSortTimeMS = sortingTimeMS;
                }
                stopwatch.Restart();
            }
            if (sortType=="insert") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
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
                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }

            if (sortType=="bubble") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
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
                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }
            if (sortType== "doubleBubble") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
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
                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }
            if (sortType== "quick") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
                    void quickSort(int left, int right)
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
                            quickSort(left, j - 1);
                        }
                        if (j + 1 < right)
                        {
                            quickSort(j + 1, right);
                        }
                    }
                    quickSort(0, amountOfNumbers - 1);
                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }
            if(sortType == "heap") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
                    for (i = 2; i <= amountOfNumbers; i++)
                    {
                        j = i;
                        k = j / 2;
                        currentNumber = tabForSort[i];
                        while ((k > 0) && (tabForSort[k] < currentNumber))
                        {
                            tabForSort[j] = tabForSort[k];
                            j = k;
                            k = j / 2;
                        }
                        tabForSort[j] = currentNumber;
                    }
                    for (i = amountOfNumbers; i > 1; i--)
                    {
                        (tabForSort[1], tabForSort[i]) = (tabForSort[i], tabForSort[1]);
                        j = 1;
                        k = 2;
                        while (k < i)
                        {
                            if ((k + 1 < i) && (tabForSort[k + 1] > tabForSort[k]))
                            {
                                m = k + 1;
                            }
                            else
                            {
                                m = k;
                            }
                            if (tabForSort[m] <= tabForSort[j])
                            {
                                break;
                            }
                            (tabForSort[j], tabForSort[m]) = (tabForSort[m], tabForSort[j]);
                            j = m;
                            k = j + j;
                        }
                    }

                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }
            if(sortType == "merge") {
                for (ii = 0; ii < executeAmountVal; ii++)
                {
                    desort();
                    stopwatch.Start();
                    void MergeSort(int i_p, int i_k)
                    {
                        int i_s;
                        int i1;
                        int i2;
                        int i;

                        i_s = (i_p + i_k + 1) / 2;
                        if (i_s - i_p > 1)
                        {
                            MergeSort(i_p, i_s - 1);
                        }
                        if (i_k - i_s > 0)
                        {
                            MergeSort(i_s, i_k);
                        }
                        i1 = i_p;
                        i2 = i_s;
                        for (i = i_p; i <= i_k; i++)
                        {
                            p[i] = ((i1 == i_s) || ((i2 <= i_k) && (tabForSort[i1] > tabForSort[i2]))) ? tabForSort[i2++] : tabForSort[i1++];
                        }
                        for (i = i_p; i <= i_k; i++)
                        {
                            tabForSort[i] = p[i];
                        }
                    }
                    MergeSort(0, amountOfNumbers - 1);
                    stopwatch.Stop();
                    sortTime(stopwatch.ElapsedMilliseconds);
                }
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            switch (loaded)
            {
                case true:
                    loadFile.ForeColor = Color.Red;
                    loaded = false;
                    stateOfApp.Text = "File:\n" + "Not Found";
                    break;
                case false:
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                        }
                    }
                    loadFile.ForeColor = Color.Green;
                    loaded = true;
                    stateOfApp.Text = "File:\n" + Path.GetFileName(filePath);
                    break;
            }
        }
    }
}
