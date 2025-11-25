namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras;
            double coste;

            // Leo el contenido del telegrama
            textoTelegrama = txtTelegrama.Text;

            // Número de palabras del telegrama
            numPalabras = textoTelegrama.Length;

            // Determinar si el telegrama es urgente u ordinario
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';   // urgente
            }
            else
            {
                tipoTelegrama = 'o';   // ordinario
            }

            // Calcular precio según tipo y nº de palabras
            if (tipoTelegrama == 'o')   // ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 3.0;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else   // urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 6.0;
                }
                else
                {
                    coste = 0.75 * numPalabras;
                }
            }

            // Mostrar el resultado
            lblResultado.Text = "Coste del telegrama: " + coste.ToString("0.00") + " euros";
        }
    }
}
