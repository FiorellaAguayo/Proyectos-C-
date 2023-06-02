using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio_3
{
    public partial class FrmWordCounter : Form
    {
        public FrmWordCounter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string text = rtxtWordCounter.Text;
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCounter = Logic.GetWords(words); // obtengo el diccionario con las palabras y sus contadores
            List<KeyValuePair<string, int>> dictionaryList = Logic.GetList(wordsCounter); // obtengo la lista ordenada de mayor a menor
            //Logic.ShowList(dictionaryList); por si quieor mostrar toda la lista
            Logic.ShowTopList(dictionaryList); // muestro top 3 de las palabras con mas repeticiones
        }
    }
}