namespace Algoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBucketSort_Click(object sender, EventArgs e)
        {
            BucketSort sort = new BucketSort();
            sort.Show();
        }

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            CountingSort sort = new CountingSort();
            sort.Show();
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            MergeSort sort = new MergeSort();
            sort.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
