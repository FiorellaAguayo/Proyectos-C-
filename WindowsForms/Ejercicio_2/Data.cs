using ClassLibrary;

namespace Ejercicio_2
{
    public partial class Data : Form
    {
        private Incoming _incoming;
        public Data()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private string[] GetChosenCourses(CheckBox[] options)
        {
            string[] chosenCourses = new string[options.Length];
            int index = 0;

            foreach (CheckBox option in options)
            {
                if (option.Checked)
                {
                    chosenCourses[index] = option.Text;
                    index++;
                }
            }

            Array.Resize(ref chosenCourses, index);
            return chosenCourses;
        }

        private string GetGender(RadioButton[] options)
        {
            string gender = null;
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].Checked)
                {
                    gender = options[i].Text;
                }
            }
            return gender;
        }

        private void btn_Ingreso_Click_1(object sender, EventArgs e)
        {
            string gender = GetGender(new RadioButton[] { rbMale, rbFemale, rbNoBinary });
            if (lstCountry.SelectedIndex == -1)
            {
                MessageBox.Show("\nDebe seleccionar un pais");
            }

            if (!string.IsNullOrWhiteSpace(txbName.Text) && !string.IsNullOrWhiteSpace(txbAddress.Text) && gender != null && lstCountry.SelectedIndex != -1)
            {
                string[] chosenCourses = GetChosenCourses(new CheckBox[] { chkCPP, chkCSharp, chkJavaScript });

                _incoming = new Incoming(chosenCourses, txbAddress.Text, (int)nudAge.Value, gender, txbName.Text, lstCountry.Text);

                string mensaje = _incoming.Mostrar();
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show($"{FieldToComplete(txbName.Text, txbAddress.Text, gender, lstCountry.SelectedIndex)}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        public string FieldToComplete(string name, string address, string gender, int country)
        {
            string message = "";

            if (string.IsNullOrWhiteSpace(name))
            {
                message += "\nNombre";
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                message += "\nDirección";
            }

            if (gender == null)
            {
                message += "\nGenero";
            }

            return $"Se deben completar los siguientes campos: {message}";
        }
    }
}