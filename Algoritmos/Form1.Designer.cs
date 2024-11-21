namespace Algoritmos
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
            label1 = new Label();
            btnBucketSort = new Button();
            btnCountingSort = new Button();
            btnMergeSort = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(402, 41);
            label1.TabIndex = 0;
            label1.Text = "Algoritmos de ordenamiento";
            // 
            // btnBucketSort
            // 
            btnBucketSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBucketSort.Location = new Point(97, 140);
            btnBucketSort.Name = "btnBucketSort";
            btnBucketSort.Size = new Size(258, 53);
            btnBucketSort.TabIndex = 1;
            btnBucketSort.Text = "BucketSort";
            btnBucketSort.UseVisualStyleBackColor = true;
            btnBucketSort.Click += btnBucketSort_Click;
            // 
            // btnCountingSort
            // 
            btnCountingSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCountingSort.Location = new Point(97, 199);
            btnCountingSort.Name = "btnCountingSort";
            btnCountingSort.Size = new Size(258, 53);
            btnCountingSort.TabIndex = 2;
            btnCountingSort.Text = "CountingSort";
            btnCountingSort.UseVisualStyleBackColor = true;
            btnCountingSort.Click += btnCountingSort_Click;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMergeSort.Location = new Point(97, 258);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(258, 53);
            btnMergeSort.TabIndex = 3;
            btnMergeSort.Text = "MergeSort";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClose.Location = new Point(97, 317);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(258, 53);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 390);
            Controls.Add(btnClose);
            Controls.Add(btnMergeSort);
            Controls.Add(btnCountingSort);
            Controls.Add(btnBucketSort);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBucketSort;
        private Button btnCountingSort;
        private Button btnMergeSort;
        private Button btnClose;
    }
}
