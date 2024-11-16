namespace AlgoritmoOrderCrlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Convertir los precios ingresados en un arreglo de enteros
            try
            {
                int[] precios = txtEntrada.Text
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // Mostrar los precios antes de ordenar
                txtSalida.Text = "Precios antes de ordenar:\r\n" + string.Join(", ", precios);

                // Ordenar los precios
                OrdenarPorInsercion(precios);

                // Mostrar los precios después de ordenar
                txtSalida.Text += "\r\n\r\nPrecios después de ordenar:\r\n" + string.Join(", ", precios);
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de ingresar números enteros separados por comas o espacios.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para ordenar un arreglo de enteros usando el método de inserción
        private void OrdenarPorInsercion(int[] arreglo)
        {
            for (int i = 1; i < arreglo.Length; i++)
            {
                int valorActual = arreglo[i];
                int j = i - 1;

                // Mover elementos que son mayores que el valor actual hacia la derecha
                while (j >= 0 && arreglo[j] > valorActual)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }

                // Colocar el valor actual en la posición correcta
                arreglo[j + 1] = valorActual;
            }
        }
    }
}
