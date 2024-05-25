using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Liste
{
    #region GraphNode
    public class GraphNode<T>
    {
        private T _valore;
        List<GraphNode<T>> _vicini;
        public T Valore
        {
            get { return _valore; }
        }
        public List<GraphNode<T>> Vicini
        {
            get { return _vicini; }
        }
        public GraphNode(T _valore)
        {
            this._valore = _valore;
            _vicini = new List<GraphNode<T>>();
        }
        public bool AggiungiVicino(GraphNode<T> vicini)
        {
            if (_vicini.Contains(vicini))
            {
                return false;
            }
            else
            {
                _vicini.Add(vicini);
                return true;
            }
        }
        public bool EliminaVicino(GraphNode<T> vicini)
        {
            if (_vicini.Contains(vicini))
            {
                _vicini.Remove(vicini);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminaTuttiVicini()
        {
            List<GraphNode<T>> viciniCopy = new List<GraphNode<T>>(_vicini);
            foreach (GraphNode<T> node in viciniCopy)
            {
                _vicini.Remove(node);
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder nodeString = new StringBuilder();
            nodeString.Append("[Nodo Valore: " + Valore + " con Vicini");
            int cont = 0;
            foreach (var node in _vicini)
            {
                if (node != null)
                {
                    if (cont == 0) { nodeString.Append(" -> " + node.Valore); cont++; }
                    else { nodeString.Append(" , " + node.Valore); }

                }
            }
            nodeString.Append(" ]");
            return nodeString.ToString();
        }
    }
    #endregion

    #region StandardGraph
    public class StandardGraph<T>
    {
        List<GraphNode<T>> myGraphNodes = new List<GraphNode<T>>();
        public StandardGraph() { }
        public int Conta
        {
            get { return myGraphNodes.Count; }
        }
        public IList<GraphNode<T>> GraphNode
        {
            get { return myGraphNodes.AsReadOnly(); }
        }
        public bool AggiungiNodo(T valore)
        {
            if (Trova(valore) != null)
            {
                return false;
            }
            else
            {
                myGraphNodes.Add(new GraphNode<T>(valore));
                return true;
            }
        }
        public bool AggiungiEdge(T n1, T n2)
        {
            GraphNode<T> gn1 = Trova(n1);
            GraphNode<T> gn2 = Trova(n2);

            if (gn1 == null)
            {
                return false;
            }
            if (gn2 == null)
            {
                return false;
            }
            if (gn1 == gn2)
            {
                return false;
            }
            if (gn1.Vicini != null && gn1.Vicini.Contains(gn2))
            {
                return false;
            }

            gn1.AggiungiVicino(gn2);
            return true;
        }
        public GraphNode<T> Trova(T valore)
        {
            foreach (var item in myGraphNodes)
            {
                if (item.Valore.Equals(valore))
                {
                    return item;
                }
            }
            return null;
        }
        public bool EliminaNodo(T valore)
        {
            GraphNode<T> TBR = Trova(valore);
            if (TBR != null)
            {
                myGraphNodes.Remove(TBR);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminaEdge(T n1, T n2)
        {
            GraphNode<T> gn1 = Trova(n1);
            GraphNode<T> gn2 = Trova(n2);
            if (gn1 == null || gn2 == null)
            {
                return false;
            }
            else if (!gn1.Vicini.Contains(gn2))
            {
                return false;
            }
            else
            {
                gn1.EliminaVicino(gn2);
                return true;
            }
        }
        public bool EliminaTutto()
        {
            foreach (GraphNode<T> node in myGraphNodes)
            {
                node.EliminaTuttiVicini();
            }
            while (myGraphNodes.Count > 0)
            {
                myGraphNodes.RemoveAt(0);
            }

            return true;
        }
        public override string ToString()
        {
            StringBuilder nodeString = new StringBuilder();
            for (int i = 0; i < Conta; i++)
            {
                nodeString.Append(myGraphNodes[i].ToString());
                if (i < Conta - 1)
                {
                    nodeString.Append("\n");
                }
            }
            return nodeString.ToString();
        }
        public void ImportaDaStringa(string input)
        {
            EliminaTutto();

            // Fase 1: Nodi
            MatchCollection nodeMatches = Regex.Matches(input, @"(\d+):(\d+(,\d+)*)");

            foreach (Match nodeMatch in nodeMatches)
            {
                //int nodeValue = int.Parse(nodeMatch.Groups[1].Value);
                //AggiungiNodo(nodeValue);
                T nodeValue = (T)Convert.ChangeType(int.Parse(nodeMatch.Groups[1].Value), typeof(T));
                AggiungiNodo(nodeValue);
            }

            // Fase 2: Edge
            foreach (Match nodeMatch in nodeMatches)
            {
                //int nodeValue = int.Parse(nodeMatch.Groups[1].Value);
                T nodeValue = (T)Convert.ChangeType(int.Parse(nodeMatch.Groups[1].Value), typeof(T));

                string[] neighbors = nodeMatch.Groups[2].Value.Split(',');
                foreach (string neighbor in neighbors)
                {
                    T neighborValue = (T)Convert.ChangeType(int.Parse(neighbor), typeof(T));
                    AggiungiEdge(nodeValue, neighborValue);
                }
            }
        }
        public void ImportaDaFile(string filePath)
        {
            try
            {
                string input = File.ReadAllText(filePath);
                ImportaDaStringa(input);
            }
            catch (IOException e)
            {
                throw new Exception($"Errore durante la lettura del file: {e.Message}");
            }
        }
        public string EsportaInStringa()
        {
            StringBuilder exportString = new StringBuilder();
            foreach (var node in myGraphNodes)
            {
                exportString.Append($"{node.Valore}:");
                if (node.Vicini.Count == 0)
                {
                    exportString.Append("0;");
                }
                else
                {
                    foreach (var neighbor in node.Vicini)
                    {
                        if (myGraphNodes.Contains(neighbor))
                        {
                            exportString.Append($"{neighbor.Valore},");
                        }
                    }
                    exportString.Append(";");
                }
            }
            return exportString.ToString();
        }
        public void EsportaInFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(EsportaInStringa());
                }
            }
            catch (IOException e)
            {
                throw new Exception($"Errore durante l'esportazione del file: {e.Message}");
            }
        }
        public T SommaTuttiINodi(T valoreNodoPartenza)
        {
            GraphNode<T> startNode = Trova(valoreNodoPartenza);
            if (startNode == null)
            {
                throw new Exception("Nodo di partenza non trovato nel grafo.");
            }

            HashSet<GraphNode<T>> visited = new HashSet<GraphNode<T>>();
            double sum = 0;
            Stack<GraphNode<T>> stack = new Stack<GraphNode<T>>();
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                GraphNode<T> currentNode = stack.Pop();
                if (currentNode != null && !visited.Contains(currentNode))
                {
                    visited.Add(currentNode);
                    if (currentNode.Valore is IConvertible)
                    {
                        sum += Convert.ToDouble(currentNode.Valore);
                    }
                    foreach (var neighbor in currentNode.Vicini)
                    {
                        stack.Push(neighbor);
                    }
                }
            }
            return (T)Convert.ChangeType(sum, typeof(T));
        }
        public List<GraphNode<T>> BFS(T valoreNodoPartenza)
        {
            GraphNode<T> startNode = Trova(valoreNodoPartenza);
            if (startNode == null)
            {
                throw new ArgumentException("Nodo di partenza non trovato nel grafo.");
            }

            // QUEUE
            List<GraphNode<T>> visited = new List<GraphNode<T>>();
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                GraphNode<T> currentNode = queue.Dequeue();
                if (!visited.Contains(currentNode))
                {
                    visited.Add(currentNode);
                    foreach (GraphNode<T> neighbor in currentNode.Vicini)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return visited;
        }
        public List<GraphNode<T>> DFS(T valoreNodoPartenza)
        {
            GraphNode<T> startNode = Trova(valoreNodoPartenza);
            if (startNode == null)
            {
                throw new ArgumentException("Nodo di partenza non trovato nel grafo.");
            }

            // STACK
            List<GraphNode<T>> visited = new List<GraphNode<T>>();
            Stack<GraphNode<T>> stack = new Stack<GraphNode<T>>();
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                GraphNode<T> currentNode = stack.Pop();
                if (!visited.Contains(currentNode))
                {
                    visited.Add(currentNode);
                    foreach (GraphNode<T> neighbor in currentNode.Vicini)
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return visited;
        }
        public string TrovaStringaPiuLung(T valoreNodoPartenza)
        {
            GraphNode<T> startNode = Trova(valoreNodoPartenza);
            if (startNode == null)
            {
                throw new ArgumentException("Nodo di partenza non trovato nel grafo.");
            }

            string stringaPiuLunga = startNode.Valore as string;
            if (stringaPiuLunga == null)
            {
                throw new ArgumentException("Il nodo di partenza non contiene una stringa.");
            }

            // QUEUE - HASHSET
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            HashSet<GraphNode<T>> visited = new HashSet<GraphNode<T>>();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                GraphNode<T> currentNode = queue.Dequeue();
                string currentString = currentNode.Valore as string;
                if (currentString != null && currentString.Length > stringaPiuLunga.Length)
                {
                    stringaPiuLunga = currentString;
                }

                foreach (GraphNode<T> neighbor in currentNode.Vicini)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return stringaPiuLunga;
        }
    }
    #endregion
}