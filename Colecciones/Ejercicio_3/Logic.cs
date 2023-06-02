using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Logic
    {
        public static Dictionary<string, int> GetWords(string[] words)
        {
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordsCounter.ContainsKey(word))
                {
                    wordsCounter.Add(word, 1); // palabra, inicializo el cont en 1
                }
                else
                {
                    wordsCounter[word]++; // incremento el valor del cont en la palabra
                }
            }

            return wordsCounter;
        }

        // este metodo devuelve 1 cuando el primer elemento es mas grande que el segundo, devuelve -1 cuando el primer elemento es mas chico
        // y 0 cuando son iguales
        public static int CompareNumberRepetitions(KeyValuePair<string, int> firstElement, KeyValuePair<string, int> secondElement)
        {
            return secondElement.Value - firstElement.Value; // ordena de forma descendente
        }

        public static List<KeyValuePair<string, int>> GetList(Dictionary<string, int> wordsCounter)
        {
            List<KeyValuePair<string, int>> dictionaryList = wordsCounter.ToList(); // convierto el diccionario en una lista
            dictionaryList.Sort(Logic.CompareNumberRepetitions);
            return dictionaryList;
        }

        public static void ShowList(List<KeyValuePair<string, int>> list)
        {
            StringBuilder sb = new StringBuilder();

            if(list.Count == 0)
            {
                sb.AppendLine("no words entered.");
            }
            else
            {
                foreach (KeyValuePair<string, int> pair in list)
                {
                    sb.AppendLine($"word: {pair.Key} - repetitions: {pair.Value}");
                }
            }
            MessageBox.Show(sb.ToString(), "List of words");
        }

        public static void ShowTopList(List<KeyValuePair<string, int>> list)
        {
            StringBuilder sb = new StringBuilder();

            if (list.Count == 0)
            {
                sb.AppendLine("no words entered.");
            }
            else
            {
                for (int i = 0; i < 3 && i < list.Count; i++)
                {
                    KeyValuePair<string, int> pair = list[i]; // guardo el par
                    sb.AppendLine($"word: {pair.Key} - repetitions: {pair.Value}");
                }
            }
            MessageBox.Show(sb.ToString(), "List of words");
        }
    }
}