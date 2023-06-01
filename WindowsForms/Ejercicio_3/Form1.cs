using ClassLibrary;

namespace Ejercicio_3
{
    public partial class Converter : Form
    {
        //falta terminar ejercicio

        private string _dollarToEuro;

        public Converter()
        {
            InitializeComponent();
            if (txbCurrentDolar.Text != "1")
            {
                txbCurrentDolar.Text = "1";
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbDolar.Text, out double euro))
            {
                Euro.SetQuote(euro);

                string euroToDollar = Dollar.ConvertCurrencyToDollar();
                string euroToPeso = Peso.ConvertCurrencyToPeso();

                txbEuroToDolar.Text = euroToDollar;
                txbEuroToPeso.Text = euroToPeso;
                txbEuroToEuro.Text = euro.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbDolar.Text, out double dollar))
            {
                Dollar.SetQuote(dollar);

                string dollarToEuro = Euro.ConvertCurrencyToEuro();
                string dollarToPeso = Peso.ConvertCurrencyToPeso();

                txbDolarToEuro.Text = dollarToEuro;
                txbDolarToPeso.Text = dollarToPeso;
                txbDolarToDolar.Text = dollar.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbPeso.Text, out double peso))
            {
                Peso.SetQuote(peso);

                string pesoToDollar = Dollar.ConvertCurrencyToDollar();
                string pesoToEuro = Euro.ConvertCurrencyToEuro();

                txbPesoToDolar.Text = pesoToDollar;
                txbPesoToEuro.Text = pesoToEuro;
                txbPesoToPeso.Text = peso.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }
    }
}