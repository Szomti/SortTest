
namespace SortTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testBtn = new System.Windows.Forms.Button();
            this.currentSort = new System.Windows.Forms.Label();
            this.bubbleSort = new System.Windows.Forms.Button();
            this.doubleBubbleSort = new System.Windows.Forms.Button();
            this.fastSort = new System.Windows.Forms.Button();
            this.instertSort = new System.Windows.Forms.Button();
            this.sortingTime = new System.Windows.Forms.Label();
            this.loadFile = new System.Windows.Forms.Button();
            this.heapSort = new System.Windows.Forms.Button();
            this.mergeSort = new System.Windows.Forms.Button();
            this.fastestSortTime = new System.Windows.Forms.Label();
            this.slowestSortTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(713, 12);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // currentSort
            // 
            this.currentSort.Location = new System.Drawing.Point(376, 16);
            this.currentSort.Name = "currentSort";
            this.currentSort.Size = new System.Drawing.Size(250, 15);
            this.currentSort.TabIndex = 1;
            this.currentSort.Text = "Not Found";
            this.currentSort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bubbleSort
            // 
            this.bubbleSort.Location = new System.Drawing.Point(12, 43);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(200, 25);
            this.bubbleSort.TabIndex = 2;
            this.bubbleSort.Text = "Bąbelkowe";
            this.bubbleSort.UseVisualStyleBackColor = true;
            this.bubbleSort.Click += new System.EventHandler(this.bubbleSort_Click);
            // 
            // doubleBubbleSort
            // 
            this.doubleBubbleSort.Location = new System.Drawing.Point(12, 74);
            this.doubleBubbleSort.Name = "doubleBubbleSort";
            this.doubleBubbleSort.Size = new System.Drawing.Size(200, 25);
            this.doubleBubbleSort.TabIndex = 3;
            this.doubleBubbleSort.Text = "Bąbelkowe Dwukierunkowe";
            this.doubleBubbleSort.UseVisualStyleBackColor = true;
            this.doubleBubbleSort.Click += new System.EventHandler(this.doubleBubbleSort_Click);
            // 
            // fastSort
            // 
            this.fastSort.Location = new System.Drawing.Point(12, 105);
            this.fastSort.Name = "fastSort";
            this.fastSort.Size = new System.Drawing.Size(200, 25);
            this.fastSort.TabIndex = 4;
            this.fastSort.Text = "Szybkie";
            this.fastSort.UseVisualStyleBackColor = true;
            this.fastSort.Click += new System.EventHandler(this.fastSort_Click);
            // 
            // instertSort
            // 
            this.instertSort.Location = new System.Drawing.Point(12, 12);
            this.instertSort.Name = "instertSort";
            this.instertSort.Size = new System.Drawing.Size(200, 25);
            this.instertSort.TabIndex = 5;
            this.instertSort.Text = "Przez Wstawianie";
            this.instertSort.UseVisualStyleBackColor = true;
            this.instertSort.Click += new System.EventHandler(this.instertSort_Click);
            // 
            // sortingTime
            // 
            this.sortingTime.Location = new System.Drawing.Point(663, 48);
            this.sortingTime.Name = "sortingTime";
            this.sortingTime.Size = new System.Drawing.Size(125, 15);
            this.sortingTime.TabIndex = 6;
            this.sortingTime.Text = "Time: 0 ms";
            this.sortingTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadFile
            // 
            this.loadFile.ForeColor = System.Drawing.Color.Red;
            this.loadFile.Location = new System.Drawing.Point(632, 12);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(75, 23);
            this.loadFile.TabIndex = 7;
            this.loadFile.Text = "Load";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // heapSort
            // 
            this.heapSort.Location = new System.Drawing.Point(12, 136);
            this.heapSort.Name = "heapSort";
            this.heapSort.Size = new System.Drawing.Size(200, 25);
            this.heapSort.TabIndex = 8;
            this.heapSort.Text = "Przez Kopcowanie";
            this.heapSort.UseVisualStyleBackColor = true;
            this.heapSort.Click += new System.EventHandler(this.heapSort_Click);
            // 
            // mergeSort
            // 
            this.mergeSort.Location = new System.Drawing.Point(12, 167);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(200, 25);
            this.mergeSort.TabIndex = 9;
            this.mergeSort.Text = "Przez Scalanie";
            this.mergeSort.UseVisualStyleBackColor = true;
            this.mergeSort.Click += new System.EventHandler(this.merchSort_Click);
            // 
            // fastestSortTime
            // 
            this.fastestSortTime.ForeColor = System.Drawing.Color.Green;
            this.fastestSortTime.Location = new System.Drawing.Point(538, 74);
            this.fastestSortTime.Name = "fastestSortTime";
            this.fastestSortTime.Size = new System.Drawing.Size(250, 45);
            this.fastestSortTime.TabIndex = 10;
            this.fastestSortTime.Text = "Fastest\r\nNot Found\r\nTime: 0 ms\r\n";
            this.fastestSortTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // slowestSortTime
            // 
            this.slowestSortTime.ForeColor = System.Drawing.Color.Maroon;
            this.slowestSortTime.Location = new System.Drawing.Point(538, 119);
            this.slowestSortTime.Name = "slowestSortTime";
            this.slowestSortTime.Size = new System.Drawing.Size(250, 45);
            this.slowestSortTime.TabIndex = 11;
            this.slowestSortTime.Text = "Slowest\r\nNot Found\r\nTime: 0 ms\r\n";
            this.slowestSortTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slowestSortTime);
            this.Controls.Add(this.fastestSortTime);
            this.Controls.Add(this.mergeSort);
            this.Controls.Add(this.heapSort);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.sortingTime);
            this.Controls.Add(this.instertSort);
            this.Controls.Add(this.fastSort);
            this.Controls.Add(this.doubleBubbleSort);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.currentSort);
            this.Controls.Add(this.testBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label currentSort;
        private System.Windows.Forms.Button bubbleSort;
        private System.Windows.Forms.Button doubleBubbleSort;
        private System.Windows.Forms.Button fastSort;
        private System.Windows.Forms.Button instertSort;
        private System.Windows.Forms.Label sortingTime;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button heapSort;
        private System.Windows.Forms.Button mergeSort;
        private System.Windows.Forms.Label fastestSortTime;
        private System.Windows.Forms.Label slowestSortTime;
    }
}

