using ClassLibrary;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahr_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbFahrenheit.Text, out double fahrenheit))
            {
                txbFahrenheitToFahrenheit.Text = fahrenheit.ToString();
                txbFahrenheitToCelsius.Text = ConverterFahrenheit.ConvertFahrToCelsius(fahrenheit);
                txbFahrenheitToKelvin.Text = ConverterFahrenheit.ConverterFahrToKelvin(fahrenheit);
            }
            else
            {
                MessageBox.Show("Ingresa correctamente el valor");
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbCelsius.Text, out double celsius))
            {
                txbCelsiusToCelsius.Text = celsius.ToString();
                txbCelsiusToFahrenheit.Text = ConverterCelsius.ConverterCelsiusToFahr(celsius);
                txbCelsiusToKelvin.Text = ConverterCelsius.ConverterCelsiusToKelvin(celsius);
            }
            else
            {
                MessageBox.Show("Ingresa correctamente el valor");
            }
        }

        private void ConvertKelvin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbCelsius.Text, out double kelvin))
            {
                txbKelvinToKelvin.Text = kelvin.ToString();
                txbKelvinToFahrenheit.Text = ConverterKelvin.ConverterKelvinToFahr(kelvin);
                txbKelvinToCelsius.Text = ConverterKelvin.ConverterKelvinToCelsius(kelvin);
            }
            else
            {
                MessageBox.Show("Ingresa correctamente el valor");
            }
        }
    }
}