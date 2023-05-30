using ClassLibrary;

namespace Ejercicio_1
{
    public partial class Data : Form
    {
        private Person _person;
        public Data()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // establece tama�o fijo del form
        }

        private void btnHello_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbName.Text) && !string.IsNullOrWhiteSpace(txbLastName.Text))
            {
                _person = new Person(txbName.Text, txbLastName.Text, cmbFavoriteSubjet.Text);

                SayHello SayHello = new SayHello(txbName.Text, txbLastName.Text, cmbFavoriteSubjet.Text);
                SayHello.Show();
            }
            else
            {
                MessageBox.Show($"Se deben completar los campos: {FieldToComplete(txbName.Text, txbLastName.Text)}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public string FieldToComplete(string name, string lastName)
        {
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(lastName))
            {
                return "\nNombre\nApellido";
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                return "\nNombre";
            }
            else
            {
                return "\nApellido";
            }
        }

        private void Data_Load_1(object sender, EventArgs e)
        {
            cmbFavoriteSubjet.Items.Add("Ingl�s I");
            cmbFavoriteSubjet.Items.Add("Laboratorio I");
            cmbFavoriteSubjet.Items.Add("Programaci�n I");
            cmbFavoriteSubjet.Items.Add("Matem�tica I");
            cmbFavoriteSubjet.Items.Add("Sistema de Procesamiento de Datos");
            cmbFavoriteSubjet.Items.Add("Arquitectura de Datos");
            cmbFavoriteSubjet.Items.Add("Estad�stica");
            cmbFavoriteSubjet.Items.Add("Metodolog�a de Sistemas");
            cmbFavoriteSubjet.Items.Add("Laboratorio II");
            cmbFavoriteSubjet.Items.Add("Programaci�n II");

            cmbFavoriteSubjet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFavoriteSubjet.SelectedIndex = 0;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}