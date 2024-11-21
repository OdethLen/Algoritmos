namespace Algoritmos
{
    partial class MergeSort
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
            listViewSteps = new ListView();
            btnMergeSort = new Button();
            btnMezclaNatural = new Button();
            btnMezclaDirecta = new Button();
            btnIngresar = new Button();
            txtInput = new TextBox();
            lblNumbers = new Label();
            btnClearList = new Button();
            btnBuckSortClose = new Button();
            SuspendLayout();
            // 
            // listViewSteps
            // 
            listViewSteps.FullRowSelect = true;
            listViewSteps.GridLines = true;
            listViewSteps.Location = new Point(395, 16);
            listViewSteps.Margin = new Padding(3, 4, 3, 4);
            listViewSteps.Name = "listViewSteps";
            listViewSteps.Size = new Size(369, 567);
            listViewSteps.TabIndex = 0;
            listViewSteps.UseCompatibleStateImageBehavior = false;
            listViewSteps.View = View.Details;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Location = new Point(265, 83);
            btnMergeSort.Margin = new Padding(3, 4, 3, 4);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(86, 31);
            btnMergeSort.TabIndex = 1;
            btnMergeSort.Text = "Merge";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnMezclaNatural
            // 
            btnMezclaNatural.Location = new Point(265, 165);
            btnMezclaNatural.Margin = new Padding(3, 4, 3, 4);
            btnMezclaNatural.Name = "btnMezclaNatural";
            btnMezclaNatural.Size = new Size(86, 31);
            btnMezclaNatural.TabIndex = 2;
            btnMezclaNatural.Text = "Natural";
            btnMezclaNatural.UseVisualStyleBackColor = true;
            btnMezclaNatural.Click += btnNaturalMerge_Click;
            // 
            // btnMezclaDirecta
            // 
            btnMezclaDirecta.Location = new Point(265, 121);
            btnMezclaDirecta.Margin = new Padding(3, 4, 3, 4);
            btnMezclaDirecta.Name = "btnMezclaDirecta";
            btnMezclaDirecta.Size = new Size(86, 31);
            btnMezclaDirecta.TabIndex = 3;
            btnMezclaDirecta.Text = "Directa";
            btnMezclaDirecta.UseVisualStyleBackColor = true;
            btnMezclaDirecta.Click += btnDirectMerge_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(265, 40);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(78, 40);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(172, 27);
            txtInput.TabIndex = 5;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Location = new Point(13, 45);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(69, 20);
            lblNumbers.TabIndex = 6;
            lblNumbers.Text = "Numbers";
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(265, 225);
            btnClearList.Margin = new Padding(3, 4, 3, 4);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(86, 31);
            btnClearList.TabIndex = 7;
            btnClearList.Text = "Clear list";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnBuckSortClose
            // 
            btnBuckSortClose.Location = new Point(139, 554);
            btnBuckSortClose.Name = "btnBuckSortClose";
            btnBuckSortClose.Size = new Size(94, 29);
            btnBuckSortClose.TabIndex = 8;
            btnBuckSortClose.Text = "Close";
            btnBuckSortClose.UseVisualStyleBackColor = true;
            btnBuckSortClose.Click += btnBuckSortClose_Click;
            // 
            // BS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 600);
            Controls.Add(btnBuckSortClose);
            Controls.Add(btnClearList);
            Controls.Add(lblNumbers);
            Controls.Add(txtInput);
            Controls.Add(btnIngresar);
            Controls.Add(btnMezclaDirecta);
            Controls.Add(btnMezclaNatural);
            Controls.Add(btnMergeSort);
            Controls.Add(listViewSteps);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BS";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewSteps;
        private Button btnMergeSort;
        private Button btnMezclaNatural;
        private Button btnMezclaDirecta;
        private Button btnIngresar;
        private TextBox txtInput;
        private Label lblNumbers;
        private Button btnClearList;
        private Button btnBuckSortClose;
    }
}