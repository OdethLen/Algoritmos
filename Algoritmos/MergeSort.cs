namespace Algoritmos
{
    public partial class MergeSort : Form
    {
        public MergeSort()
        {
            InitializeComponent();
            InitializeListView();
        }

        private int[]? numbers;

        private void InitializeListView()
        {
            listViewSteps.View = View.Details;
            listViewSteps.Columns.Add("Descripción", 120);
            listViewSteps.Columns.Add("Arreglo", 300);
            listViewSteps.FullRowSelect = true;
            listViewSteps.GridLines = true;
        }

        // Método para leer los números del TextBox y asignarlos al arreglo
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                numbers = txtInput.Text.Split(',').Select(int.Parse).ToArray();
                if (numbers.Length != 8)
                {
                    MessageBox.Show("Por favor, ingrese exactamente 8 números separados por comas.");
                    return;
                }

                // Uso de la clase externa para mezclar elementos aleatoriamente
                ArrayShuffler.Shuffle(numbers);
                listViewSteps.Items.Clear();
                DisplayArray(numbers, "Arreglo inicial (mezcla aleatoria)");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números separados por comas, sin espacios.");
            }
        }

        private void DisplayArray(int[] array, string description)
        {
            // Crear una copia del arreglo para evitar cambios inesperados
            int[] arrayCopy = (int[])array.Clone();

            var item = new ListViewItem(description);
            item.SubItems.Add(string.Join(", ", arrayCopy));
            listViewSteps.Items.Add(item);
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            listViewSteps.Items.Clear();
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.MergeSort(numbers, 0, numbers.Length - 1, DisplayArray);
        }

        private void btnDirectMerge_Click(object sender, EventArgs e)
        {
            listViewSteps.Items.Clear();
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.DirectMerge(numbers, DisplayArray);
        }

        private void btnNaturalMerge_Click(object sender, EventArgs e)
        {
            listViewSteps.Items.Clear();
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.NaturalMerge(numbers, DisplayArray);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listViewSteps.Items.Clear();
        }

        private void btnBuckSortClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
