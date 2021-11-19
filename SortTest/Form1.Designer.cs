
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
            // 
            // currentSort
            // 
            this.currentSort.Location = new System.Drawing.Point(457, 16);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

