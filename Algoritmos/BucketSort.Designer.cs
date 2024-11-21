namespace Algoritmos
{
    partial class BucketSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBucketSort = new Button();
            txtOrder = new TextBox();
            lstvOrder = new ListView();
            lstvBucket = new ListView();
            btnBucketSortClose = new Button();
            cbxOrder = new ComboBox();
            SuspendLayout();
            // 
            // btnBucketSort
            // 
            btnBucketSort.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBucketSort.Location = new Point(110, 194);
            btnBucketSort.Name = "btnBucketSort";
            btnBucketSort.Size = new Size(122, 32);
            btnBucketSort.TabIndex = 0;
            btnBucketSort.Text = "Bucket Sort ";
            btnBucketSort.UseVisualStyleBackColor = true;
            btnBucketSort.Click += btnBucketSort_Click;
            // 
            // txtOrder
            // 
            txtOrder.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrder.Location = new Point(27, 132);
            txtOrder.Multiline = true;
            txtOrder.Name = "txtOrder";
            txtOrder.ReadOnly = true;
            txtOrder.ScrollBars = ScrollBars.Vertical;
            txtOrder.Size = new Size(295, 56);
            txtOrder.TabIndex = 1;
            // 
            // lstvOrder
            // 
            lstvOrder.Location = new Point(344, 177);
            lstvOrder.Name = "lstvOrder";
            lstvOrder.Size = new Size(315, 226);
            lstvOrder.TabIndex = 2;
            lstvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lstvBucket
            // 
            lstvBucket.Location = new Point(374, 12);
            lstvBucket.Name = "lstvBucket";
            lstvBucket.Size = new Size(255, 159);
            lstvBucket.TabIndex = 3;
            lstvBucket.UseCompatibleStateImageBehavior = false;
            // 
            // btnBucketSortClose
            // 
            btnBucketSortClose.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBucketSortClose.Location = new Point(110, 243);
            btnBucketSortClose.Name = "btnBucketSortClose";
            btnBucketSortClose.Size = new Size(122, 32);
            btnBucketSortClose.TabIndex = 4;
            btnBucketSortClose.Text = "Close";
            btnBucketSortClose.UseVisualStyleBackColor = true;
            btnBucketSortClose.Click += btnBucketSortClose_Click;
            // 
            // cbxOrder
            // 
            cbxOrder.FormattingEnabled = true;
            cbxOrder.Location = new Point(27, 89);
            cbxOrder.Name = "cbxOrder";
            cbxOrder.Size = new Size(121, 23);
            cbxOrder.TabIndex = 5;
            // 
            // BucketSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 454);
            Controls.Add(cbxOrder);
            Controls.Add(btnBucketSortClose);
            Controls.Add(lstvBucket);
            Controls.Add(lstvOrder);
            Controls.Add(txtOrder);
            Controls.Add(btnBucketSort);
            Name = "BucketSort";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBucketSort;
        private TextBox txtOrder;
        private ListView lstvOrder;
        private ListView lstvBucket;
        private Button btnBucketSortClose;
        private ComboBox cbxOrder;
    }
}