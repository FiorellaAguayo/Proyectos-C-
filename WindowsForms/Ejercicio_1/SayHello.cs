using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class SayHello : Form
    {
        public SayHello(string name, string lastName, string favoriteSubjet)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            string text = lblTitle.Text;
            Font italicFont = new Font(lblTitle.Font, FontStyle.Italic);

            lblTitle.Font = italicFont;
            lblTitle.Text = text;

            lblPresentation.Text = $"Soy {name} {lastName} y mi materia favorita es {favoriteSubjet}.";
        }
    }
}