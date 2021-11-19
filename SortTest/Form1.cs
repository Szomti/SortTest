using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
