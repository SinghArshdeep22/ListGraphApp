using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace Liste
{
    public partial class Form1 : Form
    {
        #region Liste
        private myList<string> listaNumeri = new myList<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string valore = numTextBox.Text;
            if (!string.IsNullOrEmpty(valore))
            {
                if (rbtnTesta.Checked)
                {
                    listaNumeri.AggiungiInTesta(valore);
                    VisualizzaTestuale();
                }
                else if (rbtnCoda.Checked)
                {
                    listaNumeri.AggiungiInCoda(valore);
                    VisualizzaTestuale();
                }
                else if (rbtnOrdine.Checked)
                {
                    listaNumeri.AggiungiInOrdine(valore);
                    VisualizzaTestuale();
                }
                else if (rbtnPosizione.Checked)
                {
                    AggiungiInPosizione(valore);
                    VisualizzaTestuale();
                }
                else
                {
                    MessageBox.Show("Selezionare dove aggiungere il valore.");
                }
            }
            else
            {
                MessageBox.Show("Inserire un valore valido.");
            }
        }
        private void AggiungiInPosizione(string valore)
        {
            if (int.TryParse(posTextBox.Text, out int posizione))
            {
                posizione--;
                if (posizione >= 0 && posizione <= listaNumeri.GetList().Count)
                {
                    listaNumeri.AggiungiInPosizione(posizione, valore);
                }
                else
                {
                    MessageBox.Show("Posizione non valida.");
                }
            }
            else
            {
                MessageBox.Show("Inserire una posizione valida.");
            }
        }
        private void VisualizzaTestuale()
        {
            lista.Items.Clear();
            panel.Invalidate();

            List<string> valori = listaNumeri.GetList();
            if (valori != null && valori.Count > 0)
            {
                foreach (var valore in valori)
                {
                    lista.Items.Add(valore);
                }
            }
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.White);

            int raggio = 20;
            int x = 30;
            int y = 30;
            int distanzaCerchi = 15;
            List<Point> centri = new List<Point>();


            foreach (string valore in listaNumeri.GetList())
            {
                // Cerchio
                g.FillEllipse(Brushes.Black, x - raggio, y - raggio, raggio * 2, raggio * 2);

                // Testo
                SizeF textSize = g.MeasureString(valore.ToString(), font);
                float textX = x - textSize.Width / 2;
                float textY = y - textSize.Height / 2;
                g.DrawString(valore.ToString(), font, brush, new PointF(textX, textY));

                centri.Add(new Point(x, y));
                x += distanzaCerchi + raggio * 2;
            }

            // Archi
            if (centri.Count > 1)
            {
                for (int i = 0; i < centri.Count - 1; i++)
                {
                    Point start = new Point(centri[i].X + raggio, centri[i].Y);
                    Point end = new Point(centri[i + 1].X - raggio, centri[i + 1].Y);
                    DrawArrow(g, start, end);
                }
            }
        }
        private void DrawArrow(Graphics g, Point start, Point end)
        {
            Pen pen = new Pen(Color.Black, 2);

            // Linea Principale
            g.DrawLine(pen, start, end);

            double angle = Math.Atan2(end.Y - start.Y, end.X - start.X);
            float arrowSize = 10;

            PointF arrowP1 = new PointF(
                end.X - arrowSize * (float)Math.Cos(angle - Math.PI / 6),
                end.Y - arrowSize * (float)Math.Sin(angle - Math.PI / 6));

            PointF arrowP2 = new PointF(
                end.X - arrowSize * (float)Math.Cos(angle + Math.PI / 6),
                end.Y - arrowSize * (float)Math.Sin(angle + Math.PI / 6));

            PointF[] arrowPoints = { end, arrowP1, arrowP2 };

            // Punta Freccia
            g.FillPolygon(Brushes.Black, arrowPoints);
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (rbtnEliminaPosizione.Checked)
            {
                EliminaPerPosizione();
            }
            else if (rbtnEliminaValore.Checked)
            {
                EliminaPerValore();
            }
            else
            {
                MessageBox.Show("Selezionare come eliminare.");
            }
        }
        private void EliminaPerPosizione()
        {
            int posizione;
            if (int.TryParse(posTextBox2.Text, out posizione))
            {
                posizione--;
                if (posizione >= 0 && posizione < listaNumeri.GetList().Count)
                {
                    listaNumeri.EliminaPerPosizione(posizione);
                    VisualizzaTestuale();
                }
                else
                {
                    MessageBox.Show("Posizione non valida.");
                }
            }
            else
            {
                MessageBox.Show("Inserire una posizione valida.");
            }
        }
        private void EliminaPerValore()
        {
            string valore = valTextBox.Text;

            if (!string.IsNullOrEmpty(valore))
            {
                if (listaNumeri.GetList().Contains(valore))
                {
                    listaNumeri.EliminaPerValore(valore);
                    VisualizzaTestuale();
                }
                else
                {
                    MessageBox.Show("Il valore non esiste nella lista.");
                }
            }
            else
            {
                MessageBox.Show("Inserire un valore valido.");
            }
        }
        private void btnContaNodiDivisibili_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDivisore.Checked)
                {
                    if (string.IsNullOrWhiteSpace(divisoreTextBox.Text))
                    {
                        throw new Exception("Inserire un divisore valido.");
                    }

                    if (!int.TryParse(divisoreTextBox.Text, out int divisore))
                    {
                        throw new Exception("Il divisore inserito non è valido.");
                    }

                    int conteggio = listaNumeri.ContaNodiDivisibili(divisore);

                    MessageBox.Show($"Numero di nodi divisibili per {divisore}: {conteggio}");
                }
                else
                {
                    MessageBox.Show("Selezionare Radio Button.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore: " + ex.Message);
            }
        }
        private void Importa_Click(object sender, EventArgs e)
        {
            char[] separators = { ',', ' ', ';' };

            if (rbtnImportaDaStringa.Checked)
            {
                string input = txtStringaInput.Text;
                listaNumeri.ImportaDaStringa(input, separators);
                VisualizzaTestuale();
            }
            else if (rbtnImportaDaFile.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    listaNumeri.ImportaDaFile(filePath);
                    VisualizzaTestuale();
                }
            }
            else
            {
                MessageBox.Show("Selezionare da dove importare la lista.");
            }
        }
        private void Esporta_Click(object sender, EventArgs e)
        {
            if (rbtnEsportaInStringa.Checked)
            {
                EsportaInStringa();
            }
            else if (rbtnEsportaInFile.Checked)
            {
                EsportaInFile();
            }
            else
            {
                MessageBox.Show("Selezionare un'opzione di esportazione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EsportaInStringa()
        {
            try
            {
                string formattedString = listaNumeri.EsportaInStringa();
                txtStringaOutput.Text = formattedString;
                MessageBox.Show("Lista esportata come stringa formattata con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore durante l'esportazione della lista come stringa: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EsportaInFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File di testo|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    listaNumeri.EsportaInFile(filePath);
                    MessageBox.Show($"Lista esportata con successo nel file: {filePath}", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore durante l'esportazione della lista in un file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbtnPosizione_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPosizione.Checked)
            {
                posTextBox.Visible = true;
            }
            else
            {
                posTextBox.Visible = false;
            }
        }
        private void rbtnEliminaPosizione_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEliminaPosizione.Checked)
            {
                posTextBox2.Visible = true;
            }
            else
            {
                posTextBox2.Visible = false;
            }
        }
        private void rbtnEliminaValore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEliminaValore.Checked)
            {
                valTextBox.Visible = true;
            }
            else
            {
                valTextBox.Visible = false;
            }
        }
        private void rbtnImportaDaStringa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImportaDaStringa.Checked)
            {
                txtStringaInput.Visible = true;
            }
            else
            {
                txtStringaInput.Visible = false;
            }
        }
        private void rbtnEsportaInStringa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEsportaInStringa.Checked)
            {
                txtStringaOutput.Visible = true;
            }
            else
            {
                txtStringaOutput.Visible = false;
            }
        }
        private void rbtnNodiDivisibili_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDivisore.Checked)
            {
                divisoreTextBox.Visible = true;
            }
            else
            {
                divisoreTextBox.Visible = false;
            }
        }
        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEsci2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Graph
        StandardGraph<int> Graph = new StandardGraph<int>();
        private void btnAggiungiNodo_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxNodo.Text, out int value))
            {
                bool aggiungto = Graph.AggiungiNodo(value);
                rtxtbox.Text = Graph.ToString();

                if (aggiungto)
                {
                    //MessageBox.Show("Nodo aggiunto con successo!");
                }
                else
                {
                    MessageBox.Show("Impossibile aggiungere il nodo. Potrebbe già esistere.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci un valore valido per il nodo.");
            }
        }
        private void btnAggiungiEdge_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxEdge1.Text, out int value1) && int.TryParse(txtboxEdge2.Text, out int value2))
            {
                bool aggiungto = Graph.AggiungiEdge(value1, value2);
                rtxtbox.Text = Graph.ToString();

                if (aggiungto)
                {
                    //MessageBox.Show("Edge aggiunto con successo!");
                }
                else
                {
                    MessageBox.Show("Impossibile aggiungere Edge. Potrebbe non esistere uno dei nodi o edge esiste già.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci valori validi per i nodi.");
            }
        }
        private void btnEliminaNodo_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxENodo.Text, out int value))
            {
                bool rimosso = Graph.EliminaNodo(value);
                rtxtbox.Text = Graph.ToString();

                if (rimosso)
                {
                    MessageBox.Show("Nodo rimosso con successo!");
                }
                else
                {
                    MessageBox.Show("Impossibile eliminare il nodo.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci un valore valido per il nodo.");
            }
        }
        private void btnEliminaEdge_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxEEdge1.Text, out int value1) && int.TryParse(txtboxEEdge2.Text, out int value2))
            {
                bool rimosso = Graph.EliminaEdge(value1, value2);
                rtxtbox.Text = Graph.ToString();

                if (rimosso)
                {
                    MessageBox.Show("Edge rimosso con successo!");
                }
                else
                {
                    MessageBox.Show("Impossibile eliminare Edge.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci valori validi per i nodi.");
            }
        }
        private void btnEliminaTutto_Click(object sender, EventArgs e)
        {
            Graph.EliminaTutto();
            rtxtbox.Text = Graph.ToString();
        }
        private void btnImportaG_Click(object sender, EventArgs e)
        {
            if (rbtnImportaDaStringaG.Checked)
            {
                try
                {
                    string input = txtStringaInputG.Text;
                    Graph.ImportaDaStringa(input);
                    MessageBox.Show("Grafo importato correttamente!");
                    rtxtbox.Text = Graph.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'importazione: {ex.Message}");
                }
            }
            else if (rbtnImportaDaFileG.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        Graph.ImportaDaFile(filePath);
                        MessageBox.Show("Grafo importato correttamente!");
                        rtxtbox.Text = Graph.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore durante l'importazione: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleziona una modalità di importazione.");
            }
        }
        private void btnEsportaG_Click(object sender, EventArgs e)
        {
            if (rbtnEsportaInStringaG.Checked)
            {
                string exportString = Graph.EsportaInStringa();
                txtStringaOutputG.Text = exportString;
            }
            else if (rbtnEsportaInFileG.Checked)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Graph.EsportaInFile(filePath);
                    MessageBox.Show("Grafo esportato correttamente!");
                }
            }
            else
            {
                MessageBox.Show("Seleziona una modalità di esportazione.");
            }
        }
        private void btnCalcoloSomma_Click(object sender, EventArgs e)
        {
            if (rbtnSommaTutti.Checked)
            {
                if (Graph.Conta == 0)
                {
                    MessageBox.Show("Il grafo è vuoto. Impossibile calcolare la somma.");
                }
                else
                {
                    int somma = Graph.SommaTuttiINodi(Graph.GraphNode[0].Valore);
                    MessageBox.Show($"La somma di tutti i nodi è: {somma}");
                }
            }
            else if (rbtnSommaRagg.Checked)
            {
                if (int.TryParse(txtNodoPartenza1.Text, out int valoreNodoPartenza))
                {
                    GraphNode<int> nodoPartenza = Graph.Trova(valoreNodoPartenza);
                    if (nodoPartenza != null)
                    {
                        int somma = Graph.SommaTuttiINodi(nodoPartenza.Valore);
                        MessageBox.Show($"La somma dei nodi raggiungibili dal nodo {valoreNodoPartenza} è: {somma}");
                    }
                    else
                    {
                        MessageBox.Show("Il nodo di partenza specificato non esiste nel grafo.");
                    }
                }
                else
                {
                    MessageBox.Show("Inserisci un valore numerico valido per il nodo di partenza.");
                }
            }
        }
        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodoPartenza2.Text, out int valoreNodoPartenza))
            {
                try
                {
                    List<GraphNode<int>> visitati = Graph.DFS(valoreNodoPartenza);
                    MessageBox.Show("Nodi visitati (DFS): " + string.Join(", ", visitati.Select(n => n.Valore)));
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per il nodo di partenza.");
            }
        }
        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodoPartenza2.Text, out int valoreNodoPartenza))
            {
                try
                {
                    List<GraphNode<int>> visitati = Graph.BFS(valoreNodoPartenza);
                    MessageBox.Show("Nodi visitati (BFS): " + string.Join(", ", visitati.Select(n => n.Valore)));
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per il nodo di partenza.");
            }
        }
        private void rbtnImportaDaStringaG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImportaDaStringaG.Checked)
            {
                txtStringaInputG.Visible = true;
            }
            else
            {
                txtStringaInputG.Visible = false;
            }
        }
        private void rbtnEsportaInStringaG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEsportaInStringaG.Checked)
            {
                txtStringaOutputG.Visible = true;
            }
            else
            {
                txtStringaOutputG.Visible = false;
            }
        }
        private void rbtnSommaRagg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSommaRagg.Checked)
            {
                txtNodoPartenza1.Visible = true;
            }
            else
            {
                txtNodoPartenza1.Visible = false;
            }
        }
        private void btnEsci3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}