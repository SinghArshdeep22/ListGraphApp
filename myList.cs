using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Liste
{
    public class myList<T>
    {
        #region Attributi
        private List<T> items;
        #endregion

        #region Costruttore
        public myList()
        {
            items = new List<T>();
        }
        #endregion

        #region Aggiungi
        public void AggiungiInTesta(T valore)
        {
            items.Insert(0, valore);
        }
        public void AggiungiInCoda(T valore)
        {
            items.Add(valore);
        }
        public void AggiungiInOrdine(T valore)
        {
            int indice = 0;
            while (indice < items.Count && Comparer<T>.Default.Compare(items[indice], valore) < 0
)
            {
                indice++;
            }
            items.Insert(indice, valore);
        }
        public void AggiungiInPosizione(int posizione, T valore)
        {
            if (posizione >= 0 && posizione <= items.Count)
            {
                items.Insert(posizione, valore);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Posizione non valida.");
            }
        }
        #endregion

        #region Elimina
        public void EliminaPerPosizione(int posizione)
        {
            if (posizione >= 0 && posizione < items.Count)
            {
                items.RemoveAt(posizione);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Posizione non valida.");
            }
        }
        public void EliminaPerValore(T valore)
        {
            items.Remove(valore);
        }
        #endregion

        #region Operazioni
        public List<T> GetList()
        {
            return items;
        }

        public override string ToString()
        {
            return string.Join(", ", items);
        }
        public int ContaNodiDivisibili(int divisore)
        {
            if (divisore == 0)
            {
                throw new ArgumentException("Il divisore non può essere zero.");
            }

            int conteggio = 0;
            foreach (T item in items)
            {
                try
                {
                    int valNumerico = Convert.ToInt32(item);
                    if (valNumerico % divisore == 0)
                    {
                        conteggio++;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return conteggio;
        }
        #endregion

        #region Importa
        public void ImportaDaStringa(string input, char[] separators)
        {
            string[] elementi = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string elemento in elementi)
            {
                items.Add((T)(object)elemento);
            }
        }
        public void ImportaDaFile(string filePath)
        {
            char[] separators = { ',', ' ', ';' };
            try
            {
                string input = File.ReadAllText(filePath);
                ImportaDaStringa(input, separators);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Errore durante la lettura del file: {e.Message}");
            }
        }
        #endregion

        #region Esporta
        public string EsportaInStringa()
        {
            return string.Join(",", items);
        }
        public void EsportaInFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string formattedString = string.Join(",", items);
                writer.Write(formattedString);
            }
        }
        #endregion
    }
}