namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama  
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? 


            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            //Obtengo el n�mero de palabras que forma el telegrama  
            numPalabras = CalculateSpaces(textoTelegrama);

            //Si el telegrama es ordinario 
            if (tipoTelegrama == 'o')
            {
                if (numPalabras < 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else
            //Si el telegrama es urgente 
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras < 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        //CALCULAR EL N�MERO DE PALABRAS
        public static int CalculateSpaces(string txt)
        {
            int numPalabras = 0;

            for (int i = 0; i <= txt.Length-1; i++)
            {
                char c = txt[i];

                if (c==' ')
                {
                    numPalabras++;
                }
            }
            return numPalabras;
        }
    }
}
