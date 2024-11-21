namespace Algoritmos
{
    partial class CountingSort
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
            components = new System.ComponentModel.Container();
            txtInput = new TextBox();
            lblValues = new Label();
            btnSort = new Button();
            timer = new System.Windows.Forms.Timer(components);
            dgvOutput = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lblTimeElapsed = new Label();
            cBOrden = new ComboBox();
            label1 = new Label();
            btnCountingSortClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOutput).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 15F);
            txtInput.Location = new Point(12, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(521, 41);
            txtInput.TabIndex = 0;
            // 
            // lblValues
            // 
            lblValues.AutoSize = true;
            lblValues.Location = new Point(12, 9);
            lblValues.Name = "lblValues";
            lblValues.Size = new Size(51, 20);
            lblValues.TabIndex = 1;
            lblValues.Text = "Values";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(199, 85);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // dgvOutput
            // 
            dgvOutput.AllowUserToAddRows = false;
            dgvOutput.AllowUserToDeleteRows = false;
            dgvOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutput.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvOutput.EnableHeadersVisualStyles = false;
            dgvOutput.Location = new Point(12, 120);
            dgvOutput.Name = "dgvOutput";
            dgvOutput.RowHeadersWidth = 51;
            dgvOutput.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOutput.Size = new Size(809, 396);
            dgvOutput.TabIndex = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 500;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(536, 89);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(179, 20);
            lblTimeElapsed.TabIndex = 301;
            lblTimeElapsed.Text = "Tiempo de ordenamiento";
            // 
            // cBOrden
            // 
            cBOrden.FormattingEnabled = true;
            cBOrden.Location = new Point(564, 43);
            cBOrden.Name = "cBOrden";
            cBOrden.Size = new Size(151, 28);
            cBOrden.TabIndex = 302;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(564, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 303;
            label1.Text = "Orden";
            // 
            // btnCountingSortClose
            // 
            btnCountingSortClose.Location = new Point(360, 522);
            btnCountingSortClose.Name = "btnCountingSortClose";
            btnCountingSortClose.Size = new Size(94, 29);
            btnCountingSortClose.TabIndex = 304;
            btnCountingSortClose.Text = "Close";
            btnCountingSortClose.UseVisualStyleBackColor = true;
            btnCountingSortClose.Click += btnCountingSortClose_Click;
            // 
            // CountingSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 579);
            Controls.Add(btnCountingSortClose);
            Controls.Add(label1);
            Controls.Add(cBOrden);
            Controls.Add(lblTimeElapsed);
            Controls.Add(dgvOutput);
            Controls.Add(btnSort);
            Controls.Add(lblValues);
            Controls.Add(txtInput);
            Name = "CountingSort";
            Text = "Counting Sort";
            ((System.ComponentModel.ISupportInitialize)dgvOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblValues;
        private Button btnSort;
        private System.Windows.Forms.Timer timer;
        private DataGridView dgvOutput;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label lblTimeElapsed;
        private ComboBox cBOrden;
        private Label label1;
        private Button btnCountingSortClose;
    }
}