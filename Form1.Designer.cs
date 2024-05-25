namespace Liste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            rbtnOrdine = new RadioButton();
            posTextBox = new TextBox();
            rbtnCoda = new RadioButton();
            rbtnPosizione = new RadioButton();
            rbtnTesta = new RadioButton();
            btnAggiungi = new Button();
            numTextBox = new TextBox();
            lb1 = new Label();
            valTextBox = new TextBox();
            posTextBox2 = new TextBox();
            lista = new ListBox();
            btnEsci = new Button();
            Tab = new TabControl();
            List = new TabPage();
            panel8 = new Panel();
            rbtnDivisore = new RadioButton();
            divisoreTextBox = new TextBox();
            btnContaNodiDivisibili = new Button();
            panel = new Panel();
            panel6 = new Panel();
            rbtnEsportaInFile = new RadioButton();
            rbtnImportaDaFile = new RadioButton();
            txtStringaOutput = new TextBox();
            txtStringaInput = new TextBox();
            rbtnEsportaInStringa = new RadioButton();
            rbtnImportaDaStringa = new RadioButton();
            btnEsporta = new Button();
            btnImporta = new Button();
            panel3 = new Panel();
            rbtnEliminaValore = new RadioButton();
            rbtnEliminaPosizione = new RadioButton();
            btnElimina = new Button();
            tabPage1 = new TabPage();
            btnEliminaTutto = new Button();
            panel5 = new Panel();
            btnBFS = new Button();
            txtNodoPartenza2 = new TextBox();
            btnDFS = new Button();
            panel11 = new Panel();
            rbtnSommaRagg = new RadioButton();
            rbtnSommaTutti = new RadioButton();
            txtNodoPartenza1 = new TextBox();
            btnSomma = new Button();
            panel10 = new Panel();
            rbtnEsportaInFileG = new RadioButton();
            rbtnImportaDaFileG = new RadioButton();
            txtStringaOutputG = new TextBox();
            txtStringaInputG = new TextBox();
            rbtnEsportaInStringaG = new RadioButton();
            rbtnImportaDaStringaG = new RadioButton();
            btnEsportaG = new Button();
            btnImportaG = new Button();
            btnEsci3 = new Button();
            rtxtbox = new RichTextBox();
            panel2 = new Panel();
            txtboxEEdge2 = new TextBox();
            txtboxENodo = new TextBox();
            txtboxEEdge1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnEliminaEdge = new Button();
            btnEliminaNodo = new Button();
            panel4 = new Panel();
            txtboxEdge2 = new TextBox();
            txtboxNodo = new TextBox();
            txtboxEdge1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAggiungiEdge = new Button();
            btnAggiungiNodo = new Button();
            panel1.SuspendLayout();
            Tab.SuspendLayout();
            List.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(rbtnOrdine);
            panel1.Controls.Add(posTextBox);
            panel1.Controls.Add(rbtnCoda);
            panel1.Controls.Add(rbtnPosizione);
            panel1.Controls.Add(rbtnTesta);
            panel1.Controls.Add(btnAggiungi);
            panel1.Controls.Add(numTextBox);
            panel1.Controls.Add(lb1);
            panel1.Location = new Point(17, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 241);
            panel1.TabIndex = 0;
            // 
            // rbtnOrdine
            // 
            rbtnOrdine.AutoSize = true;
            rbtnOrdine.Location = new Point(130, 139);
            rbtnOrdine.Name = "rbtnOrdine";
            rbtnOrdine.Size = new Size(91, 24);
            rbtnOrdine.TabIndex = 6;
            rbtnOrdine.TabStop = true;
            rbtnOrdine.Text = "In Ordine";
            rbtnOrdine.UseVisualStyleBackColor = true;
            // 
            // posTextBox
            // 
            posTextBox.Location = new Point(151, 192);
            posTextBox.Multiline = true;
            posTextBox.Name = "posTextBox";
            posTextBox.Size = new Size(94, 27);
            posTextBox.TabIndex = 5;
            posTextBox.Visible = false;
            // 
            // rbtnCoda
            // 
            rbtnCoda.AutoSize = true;
            rbtnCoda.Location = new Point(130, 109);
            rbtnCoda.Name = "rbtnCoda";
            rbtnCoda.Size = new Size(81, 24);
            rbtnCoda.TabIndex = 3;
            rbtnCoda.TabStop = true;
            rbtnCoda.Text = "In Coda";
            rbtnCoda.UseVisualStyleBackColor = true;
            // 
            // rbtnPosizione
            // 
            rbtnPosizione.AutoSize = true;
            rbtnPosizione.Location = new Point(130, 167);
            rbtnPosizione.Name = "rbtnPosizione";
            rbtnPosizione.Size = new Size(108, 24);
            rbtnPosizione.TabIndex = 4;
            rbtnPosizione.TabStop = true;
            rbtnPosizione.Text = "In Posizione";
            rbtnPosizione.UseVisualStyleBackColor = true;
            rbtnPosizione.CheckedChanged += rbtnPosizione_CheckedChanged;
            // 
            // rbtnTesta
            // 
            rbtnTesta.AutoSize = true;
            rbtnTesta.Location = new Point(130, 79);
            rbtnTesta.Name = "rbtnTesta";
            rbtnTesta.Size = new Size(80, 24);
            rbtnTesta.TabIndex = 3;
            rbtnTesta.TabStop = true;
            rbtnTesta.Text = "In Testa";
            rbtnTesta.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(25, 79);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(94, 140);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // numTextBox
            // 
            numTextBox.Location = new Point(25, 41);
            numTextBox.Name = "numTextBox";
            numTextBox.Size = new Size(94, 27);
            numTextBox.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(22, 19);
            lb1.Name = "lb1";
            lb1.Size = new Size(128, 20);
            lb1.TabIndex = 0;
            lb1.Text = "Inserisci il numero";
            // 
            // valTextBox
            // 
            valTextBox.Location = new Point(152, 110);
            valTextBox.Multiline = true;
            valTextBox.Name = "valTextBox";
            valTextBox.Size = new Size(94, 27);
            valTextBox.TabIndex = 7;
            valTextBox.Visible = false;
            // 
            // posTextBox2
            // 
            posTextBox2.Location = new Point(152, 47);
            posTextBox2.Multiline = true;
            posTextBox2.Name = "posTextBox2";
            posTextBox2.Size = new Size(94, 27);
            posTextBox2.TabIndex = 6;
            posTextBox2.Visible = false;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 20;
            lista.Location = new Point(382, 15);
            lista.Name = "lista";
            lista.Size = new Size(52, 424);
            lista.TabIndex = 4;
            // 
            // btnEsci
            // 
            btnEsci.Location = new Point(937, 495);
            btnEsci.Name = "btnEsci";
            btnEsci.Size = new Size(94, 29);
            btnEsci.TabIndex = 5;
            btnEsci.Text = "Esci";
            btnEsci.UseVisualStyleBackColor = true;
            btnEsci.Click += btnEsci_Click;
            // 
            // Tab
            // 
            Tab.Controls.Add(List);
            Tab.Controls.Add(tabPage1);
            Tab.Location = new Point(11, 12);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(1045, 564);
            Tab.TabIndex = 6;
            // 
            // List
            // 
            List.Controls.Add(panel8);
            List.Controls.Add(panel);
            List.Controls.Add(panel6);
            List.Controls.Add(panel3);
            List.Controls.Add(panel1);
            List.Controls.Add(btnEsci);
            List.Controls.Add(lista);
            List.Location = new Point(4, 29);
            List.Name = "List";
            List.Padding = new Padding(3);
            List.Size = new Size(1037, 531);
            List.TabIndex = 0;
            List.Text = "List";
            List.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(rbtnDivisore);
            panel8.Controls.Add(divisoreTextBox);
            panel8.Controls.Add(btnContaNodiDivisibili);
            panel8.Location = new Point(466, 304);
            panel8.Name = "panel8";
            panel8.Size = new Size(317, 135);
            panel8.TabIndex = 10;
            // 
            // rbtnDivisore
            // 
            rbtnDivisore.AutoSize = true;
            rbtnDivisore.Location = new Point(125, 24);
            rbtnDivisore.Name = "rbtnDivisore";
            rbtnDivisore.Size = new Size(84, 24);
            rbtnDivisore.TabIndex = 3;
            rbtnDivisore.TabStop = true;
            rbtnDivisore.Text = "Divisore";
            rbtnDivisore.UseVisualStyleBackColor = true;
            rbtnDivisore.CheckedChanged += rbtnNodiDivisibili_CheckedChanged;
            // 
            // divisoreTextBox
            // 
            divisoreTextBox.Location = new Point(147, 51);
            divisoreTextBox.Multiline = true;
            divisoreTextBox.Name = "divisoreTextBox";
            divisoreTextBox.Size = new Size(94, 27);
            divisoreTextBox.TabIndex = 6;
            divisoreTextBox.Visible = false;
            // 
            // btnContaNodiDivisibili
            // 
            btnContaNodiDivisibili.Location = new Point(25, 21);
            btnContaNodiDivisibili.Name = "btnContaNodiDivisibili";
            btnContaNodiDivisibili.Size = new Size(94, 86);
            btnContaNodiDivisibili.TabIndex = 2;
            btnContaNodiDivisibili.Text = "Conta";
            btnContaNodiDivisibili.UseVisualStyleBackColor = true;
            btnContaNodiDivisibili.Click += btnContaNodiDivisibili_Click;
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(17, 456);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(766, 68);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(rbtnEsportaInFile);
            panel6.Controls.Add(rbtnImportaDaFile);
            panel6.Controls.Add(txtStringaOutput);
            panel6.Controls.Add(txtStringaInput);
            panel6.Controls.Add(rbtnEsportaInStringa);
            panel6.Controls.Add(rbtnImportaDaStringa);
            panel6.Controls.Add(btnEsporta);
            panel6.Controls.Add(btnImporta);
            panel6.Location = new Point(466, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(317, 283);
            panel6.TabIndex = 8;
            // 
            // rbtnEsportaInFile
            // 
            rbtnEsportaInFile.AutoSize = true;
            rbtnEsportaInFile.Location = new Point(125, 151);
            rbtnEsportaInFile.Name = "rbtnEsportaInFile";
            rbtnEsportaInFile.Size = new Size(53, 24);
            rbtnEsportaInFile.TabIndex = 3;
            rbtnEsportaInFile.TabStop = true;
            rbtnEsportaInFile.Text = "File";
            rbtnEsportaInFile.UseVisualStyleBackColor = true;
            // 
            // rbtnImportaDaFile
            // 
            rbtnImportaDaFile.AutoSize = true;
            rbtnImportaDaFile.Location = new Point(125, 24);
            rbtnImportaDaFile.Name = "rbtnImportaDaFile";
            rbtnImportaDaFile.Size = new Size(53, 24);
            rbtnImportaDaFile.TabIndex = 3;
            rbtnImportaDaFile.TabStop = true;
            rbtnImportaDaFile.Text = "File";
            rbtnImportaDaFile.UseVisualStyleBackColor = true;
            // 
            // txtStringaOutput
            // 
            txtStringaOutput.Location = new Point(147, 207);
            txtStringaOutput.Multiline = true;
            txtStringaOutput.Name = "txtStringaOutput";
            txtStringaOutput.Size = new Size(94, 27);
            txtStringaOutput.TabIndex = 6;
            txtStringaOutput.Visible = false;
            // 
            // txtStringaInput
            // 
            txtStringaInput.Location = new Point(147, 80);
            txtStringaInput.Multiline = true;
            txtStringaInput.Name = "txtStringaInput";
            txtStringaInput.Size = new Size(94, 27);
            txtStringaInput.TabIndex = 6;
            txtStringaInput.Visible = false;
            // 
            // rbtnEsportaInStringa
            // 
            rbtnEsportaInStringa.AutoSize = true;
            rbtnEsportaInStringa.Location = new Point(125, 181);
            rbtnEsportaInStringa.Name = "rbtnEsportaInStringa";
            rbtnEsportaInStringa.Size = new Size(81, 24);
            rbtnEsportaInStringa.TabIndex = 3;
            rbtnEsportaInStringa.TabStop = true;
            rbtnEsportaInStringa.Text = "Stringa ";
            rbtnEsportaInStringa.UseVisualStyleBackColor = true;
            rbtnEsportaInStringa.CheckedChanged += rbtnEsportaInStringa_CheckedChanged;
            // 
            // rbtnImportaDaStringa
            // 
            rbtnImportaDaStringa.AutoSize = true;
            rbtnImportaDaStringa.Location = new Point(125, 54);
            rbtnImportaDaStringa.Name = "rbtnImportaDaStringa";
            rbtnImportaDaStringa.Size = new Size(81, 24);
            rbtnImportaDaStringa.TabIndex = 3;
            rbtnImportaDaStringa.TabStop = true;
            rbtnImportaDaStringa.Text = "Stringa ";
            rbtnImportaDaStringa.UseVisualStyleBackColor = true;
            rbtnImportaDaStringa.CheckedChanged += rbtnImportaDaStringa_CheckedChanged;
            // 
            // btnEsporta
            // 
            btnEsporta.Location = new Point(25, 151);
            btnEsporta.Name = "btnEsporta";
            btnEsporta.Size = new Size(94, 89);
            btnEsporta.TabIndex = 2;
            btnEsporta.Text = "Esporta";
            btnEsporta.UseVisualStyleBackColor = true;
            btnEsporta.Click += Esporta_Click;
            // 
            // btnImporta
            // 
            btnImporta.Location = new Point(25, 24);
            btnImporta.Name = "btnImporta";
            btnImporta.Size = new Size(94, 83);
            btnImporta.TabIndex = 2;
            btnImporta.Text = "Importa";
            btnImporta.UseVisualStyleBackColor = true;
            btnImporta.Click += Importa_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(valTextBox);
            panel3.Controls.Add(rbtnEliminaValore);
            panel3.Controls.Add(posTextBox2);
            panel3.Controls.Add(rbtnEliminaPosizione);
            panel3.Controls.Add(btnElimina);
            panel3.Location = new Point(17, 262);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 177);
            panel3.TabIndex = 7;
            // 
            // rbtnEliminaValore
            // 
            rbtnEliminaValore.AutoSize = true;
            rbtnEliminaValore.Location = new Point(130, 80);
            rbtnEliminaValore.Name = "rbtnEliminaValore";
            rbtnEliminaValore.Size = new Size(96, 24);
            rbtnEliminaValore.TabIndex = 3;
            rbtnEliminaValore.TabStop = true;
            rbtnEliminaValore.Text = "Per Valore";
            rbtnEliminaValore.UseVisualStyleBackColor = true;
            rbtnEliminaValore.CheckedChanged += rbtnEliminaValore_CheckedChanged;
            // 
            // rbtnEliminaPosizione
            // 
            rbtnEliminaPosizione.AutoSize = true;
            rbtnEliminaPosizione.Location = new Point(130, 21);
            rbtnEliminaPosizione.Name = "rbtnEliminaPosizione";
            rbtnEliminaPosizione.Size = new Size(116, 24);
            rbtnEliminaPosizione.TabIndex = 3;
            rbtnEliminaPosizione.TabStop = true;
            rbtnEliminaPosizione.Text = "Per Posizione";
            rbtnEliminaPosizione.UseVisualStyleBackColor = true;
            rbtnEliminaPosizione.CheckedChanged += rbtnEliminaPosizione_CheckedChanged;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(25, 21);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(94, 116);
            btnElimina.TabIndex = 2;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEliminaTutto);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel11);
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(btnEsci3);
            tabPage1.Controls.Add(rtxtbox);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1037, 531);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Graph";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminaTutto
            // 
            btnEliminaTutto.Location = new Point(289, 464);
            btnEliminaTutto.Name = "btnEliminaTutto";
            btnEliminaTutto.Size = new Size(444, 29);
            btnEliminaTutto.TabIndex = 0;
            btnEliminaTutto.Text = "Elimina Tutto";
            btnEliminaTutto.UseVisualStyleBackColor = true;
            btnEliminaTutto.Click += btnEliminaTutto_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnBFS);
            panel5.Controls.Add(txtNodoPartenza2);
            panel5.Controls.Add(btnDFS);
            panel5.Location = new Point(739, 367);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 91);
            panel5.TabIndex = 16;
            // 
            // btnBFS
            // 
            btnBFS.Location = new Point(152, 16);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(94, 29);
            btnBFS.TabIndex = 8;
            btnBFS.Text = "BFS";
            btnBFS.UseVisualStyleBackColor = true;
            btnBFS.Click += btnBFS_Click;
            // 
            // txtNodoPartenza2
            // 
            txtNodoPartenza2.Location = new Point(86, 51);
            txtNodoPartenza2.Multiline = true;
            txtNodoPartenza2.Name = "txtNodoPartenza2";
            txtNodoPartenza2.Size = new Size(94, 27);
            txtNodoPartenza2.TabIndex = 7;
            // 
            // btnDFS
            // 
            btnDFS.Location = new Point(24, 16);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(94, 29);
            btnDFS.TabIndex = 7;
            btnDFS.Text = "DFS";
            btnDFS.UseVisualStyleBackColor = true;
            btnDFS.Click += btnDFS_Click;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(rbtnSommaRagg);
            panel11.Controls.Add(rbtnSommaTutti);
            panel11.Controls.Add(txtNodoPartenza1);
            panel11.Controls.Add(btnSomma);
            panel11.Location = new Point(739, 234);
            panel11.Name = "panel11";
            panel11.Size = new Size(279, 127);
            panel11.TabIndex = 15;
            // 
            // rbtnSommaRagg
            // 
            rbtnSommaRagg.AutoSize = true;
            rbtnSommaRagg.Location = new Point(127, 46);
            rbtnSommaRagg.Name = "rbtnSommaRagg";
            rbtnSommaRagg.Size = new Size(119, 24);
            rbtnSommaRagg.TabIndex = 9;
            rbtnSommaRagg.TabStop = true;
            rbtnSommaRagg.Text = "Raggiungibili";
            rbtnSommaRagg.UseVisualStyleBackColor = true;
            rbtnSommaRagg.CheckedChanged += rbtnSommaRagg_CheckedChanged;
            // 
            // rbtnSommaTutti
            // 
            rbtnSommaTutti.AutoSize = true;
            rbtnSommaTutti.Location = new Point(126, 17);
            rbtnSommaTutti.Name = "rbtnSommaTutti";
            rbtnSommaTutti.Size = new Size(97, 24);
            rbtnSommaTutti.TabIndex = 8;
            rbtnSommaTutti.TabStop = true;
            rbtnSommaTutti.Text = "Tutti Nodi";
            rbtnSommaTutti.UseVisualStyleBackColor = true;
            // 
            // txtNodoPartenza1
            // 
            txtNodoPartenza1.Location = new Point(152, 76);
            txtNodoPartenza1.Multiline = true;
            txtNodoPartenza1.Name = "txtNodoPartenza1";
            txtNodoPartenza1.Size = new Size(94, 27);
            txtNodoPartenza1.TabIndex = 7;
            txtNodoPartenza1.Visible = false;
            // 
            // btnSomma
            // 
            btnSomma.Location = new Point(24, 16);
            btnSomma.Name = "btnSomma";
            btnSomma.Size = new Size(94, 86);
            btnSomma.TabIndex = 7;
            btnSomma.Text = "Somma dei Nodi";
            btnSomma.UseVisualStyleBackColor = true;
            btnSomma.Click += btnCalcoloSomma_Click;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(rbtnEsportaInFileG);
            panel10.Controls.Add(rbtnImportaDaFileG);
            panel10.Controls.Add(txtStringaOutputG);
            panel10.Controls.Add(txtStringaInputG);
            panel10.Controls.Add(rbtnEsportaInStringaG);
            panel10.Controls.Add(rbtnImportaDaStringaG);
            panel10.Controls.Add(btnEsportaG);
            panel10.Controls.Add(btnImportaG);
            panel10.Location = new Point(739, 18);
            panel10.Name = "panel10";
            panel10.Size = new Size(279, 210);
            panel10.TabIndex = 13;
            // 
            // rbtnEsportaInFileG
            // 
            rbtnEsportaInFileG.AutoSize = true;
            rbtnEsportaInFileG.Location = new Point(127, 108);
            rbtnEsportaInFileG.Name = "rbtnEsportaInFileG";
            rbtnEsportaInFileG.Size = new Size(53, 24);
            rbtnEsportaInFileG.TabIndex = 3;
            rbtnEsportaInFileG.TabStop = true;
            rbtnEsportaInFileG.Text = "File";
            rbtnEsportaInFileG.UseVisualStyleBackColor = true;
            // 
            // rbtnImportaDaFileG
            // 
            rbtnImportaDaFileG.AutoSize = true;
            rbtnImportaDaFileG.Location = new Point(126, 13);
            rbtnImportaDaFileG.Name = "rbtnImportaDaFileG";
            rbtnImportaDaFileG.Size = new Size(53, 24);
            rbtnImportaDaFileG.TabIndex = 3;
            rbtnImportaDaFileG.TabStop = true;
            rbtnImportaDaFileG.Text = "File";
            rbtnImportaDaFileG.UseVisualStyleBackColor = true;
            // 
            // txtStringaOutputG
            // 
            txtStringaOutputG.Location = new Point(149, 164);
            txtStringaOutputG.Multiline = true;
            txtStringaOutputG.Name = "txtStringaOutputG";
            txtStringaOutputG.Size = new Size(94, 27);
            txtStringaOutputG.TabIndex = 6;
            txtStringaOutputG.Visible = false;
            // 
            // txtStringaInputG
            // 
            txtStringaInputG.Location = new Point(148, 69);
            txtStringaInputG.Multiline = true;
            txtStringaInputG.Name = "txtStringaInputG";
            txtStringaInputG.Size = new Size(94, 27);
            txtStringaInputG.TabIndex = 6;
            txtStringaInputG.Visible = false;
            // 
            // rbtnEsportaInStringaG
            // 
            rbtnEsportaInStringaG.AutoSize = true;
            rbtnEsportaInStringaG.Location = new Point(127, 134);
            rbtnEsportaInStringaG.Name = "rbtnEsportaInStringaG";
            rbtnEsportaInStringaG.Size = new Size(81, 24);
            rbtnEsportaInStringaG.TabIndex = 3;
            rbtnEsportaInStringaG.TabStop = true;
            rbtnEsportaInStringaG.Text = "Stringa ";
            rbtnEsportaInStringaG.UseVisualStyleBackColor = true;
            rbtnEsportaInStringaG.CheckedChanged += rbtnEsportaInStringaG_CheckedChanged;
            // 
            // rbtnImportaDaStringaG
            // 
            rbtnImportaDaStringaG.AutoSize = true;
            rbtnImportaDaStringaG.Location = new Point(126, 39);
            rbtnImportaDaStringaG.Name = "rbtnImportaDaStringaG";
            rbtnImportaDaStringaG.Size = new Size(81, 24);
            rbtnImportaDaStringaG.TabIndex = 3;
            rbtnImportaDaStringaG.TabStop = true;
            rbtnImportaDaStringaG.Text = "Stringa ";
            rbtnImportaDaStringaG.UseVisualStyleBackColor = true;
            rbtnImportaDaStringaG.CheckedChanged += rbtnImportaDaStringaG_CheckedChanged;
            // 
            // btnEsportaG
            // 
            btnEsportaG.Location = new Point(27, 105);
            btnEsportaG.Name = "btnEsportaG";
            btnEsportaG.Size = new Size(94, 86);
            btnEsportaG.TabIndex = 2;
            btnEsportaG.Text = "Esporta";
            btnEsportaG.UseVisualStyleBackColor = true;
            btnEsportaG.Click += btnEsportaG_Click;
            // 
            // btnImportaG
            // 
            btnImportaG.Location = new Point(26, 10);
            btnImportaG.Name = "btnImportaG";
            btnImportaG.Size = new Size(94, 86);
            btnImportaG.TabIndex = 2;
            btnImportaG.Text = "Importa";
            btnImportaG.UseVisualStyleBackColor = true;
            btnImportaG.Click += btnImportaG_Click;
            // 
            // btnEsci3
            // 
            btnEsci3.Location = new Point(937, 496);
            btnEsci3.Name = "btnEsci3";
            btnEsci3.Size = new Size(94, 29);
            btnEsci3.TabIndex = 12;
            btnEsci3.Text = "Esci";
            btnEsci3.UseVisualStyleBackColor = true;
            btnEsci3.Click += btnEsci3_Click;
            // 
            // rtxtbox
            // 
            rtxtbox.Location = new Point(289, 18);
            rtxtbox.Name = "rtxtbox";
            rtxtbox.Size = new Size(444, 440);
            rtxtbox.TabIndex = 11;
            rtxtbox.Text = "";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtboxEEdge2);
            panel2.Controls.Add(txtboxENodo);
            panel2.Controls.Add(txtboxEEdge1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnEliminaEdge);
            panel2.Controls.Add(btnEliminaNodo);
            panel2.Location = new Point(17, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 160);
            panel2.TabIndex = 9;
            // 
            // txtboxEEdge2
            // 
            txtboxEEdge2.Location = new Point(158, 78);
            txtboxEEdge2.Name = "txtboxEEdge2";
            txtboxEEdge2.Size = new Size(85, 27);
            txtboxEEdge2.TabIndex = 2;
            // 
            // txtboxENodo
            // 
            txtboxENodo.Location = new Point(161, 9);
            txtboxENodo.Name = "txtboxENodo";
            txtboxENodo.Size = new Size(85, 27);
            txtboxENodo.TabIndex = 1;
            // 
            // txtboxEEdge1
            // 
            txtboxEEdge1.Location = new Point(67, 78);
            txtboxEEdge1.Name = "txtboxEEdge1";
            txtboxEEdge1.Size = new Size(85, 27);
            txtboxEEdge1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 12);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 1;
            label3.Text = "Nodo da rimuovere:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 81);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 1;
            label4.Text = "Edge:";
            // 
            // btnEliminaEdge
            // 
            btnEliminaEdge.Location = new Point(7, 111);
            btnEliminaEdge.Name = "btnEliminaEdge";
            btnEliminaEdge.Size = new Size(236, 29);
            btnEliminaEdge.TabIndex = 0;
            btnEliminaEdge.Text = "Elimina Edge";
            btnEliminaEdge.UseVisualStyleBackColor = true;
            btnEliminaEdge.Click += btnEliminaEdge_Click_1;
            // 
            // btnEliminaNodo
            // 
            btnEliminaNodo.Location = new Point(10, 42);
            btnEliminaNodo.Name = "btnEliminaNodo";
            btnEliminaNodo.Size = new Size(236, 29);
            btnEliminaNodo.TabIndex = 0;
            btnEliminaNodo.Text = "Elimina Nodo";
            btnEliminaNodo.UseVisualStyleBackColor = true;
            btnEliminaNodo.Click += btnEliminaNodo_Click_1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtboxEdge2);
            panel4.Controls.Add(txtboxNodo);
            panel4.Controls.Add(txtboxEdge1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnAggiungiEdge);
            panel4.Controls.Add(btnAggiungiNodo);
            panel4.Location = new Point(17, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 160);
            panel4.TabIndex = 8;
            // 
            // txtboxEdge2
            // 
            txtboxEdge2.Location = new Point(158, 75);
            txtboxEdge2.Name = "txtboxEdge2";
            txtboxEdge2.Size = new Size(85, 27);
            txtboxEdge2.TabIndex = 2;
            // 
            // txtboxNodo
            // 
            txtboxNodo.Location = new Point(161, 10);
            txtboxNodo.Name = "txtboxNodo";
            txtboxNodo.Size = new Size(85, 27);
            txtboxNodo.TabIndex = 1;
            // 
            // txtboxEdge1
            // 
            txtboxEdge1.Location = new Point(67, 75);
            txtboxEdge1.Name = "txtboxEdge1";
            txtboxEdge1.Size = new Size(85, 27);
            txtboxEdge1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 1;
            label1.Text = "Nodo da aggiungere:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 78);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Edge:";
            // 
            // btnAggiungiEdge
            // 
            btnAggiungiEdge.Location = new Point(7, 108);
            btnAggiungiEdge.Name = "btnAggiungiEdge";
            btnAggiungiEdge.Size = new Size(236, 29);
            btnAggiungiEdge.TabIndex = 0;
            btnAggiungiEdge.Text = "Aggiungi Edge";
            btnAggiungiEdge.UseVisualStyleBackColor = true;
            btnAggiungiEdge.Click += btnAggiungiEdge_Click_1;
            // 
            // btnAggiungiNodo
            // 
            btnAggiungiNodo.Location = new Point(10, 40);
            btnAggiungiNodo.Name = "btnAggiungiNodo";
            btnAggiungiNodo.Size = new Size(236, 29);
            btnAggiungiNodo.TabIndex = 0;
            btnAggiungiNodo.Text = "Aggiungi Nodo";
            btnAggiungiNodo.UseVisualStyleBackColor = true;
            btnAggiungiNodo.Click += btnAggiungiNodo_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 599);
            Controls.Add(Tab);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Tab.ResumeLayout(false);
            List.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rbtnTesta;
        private Button btnAggiungi;
        private TextBox numTextBox;
        private Label lb1;
        private RadioButton rbtnCoda;
        private RadioButton rbtnPosizione;
        private ListBox lista;
        private Button btnEsci;
        private TextBox posTextBox;
        private TextBox valTextBox;
        private TextBox posTextBox2;
        private RadioButton rbtnOrdine;
        private TabControl Tab;
        private TabPage List;
        private Panel panel3;
        private RadioButton rbtnEliminaValore;
        private RadioButton rbtnEliminaPosizione;
        private Button btnElimina;
        private TabPage tabPage1;
        private Button btnEsci3;
        private RichTextBox rtxtbox;
        private Button btnEliminaTutto;
        private Panel panel2;
        private TextBox txtboxEEdge2;
        private TextBox txtboxENodo;
        private TextBox txtboxEEdge1;
        private Label label3;
        private Label label4;
        private Button btnEliminaEdge;
        private Button btnEliminaNodo;
        private Panel panel4;
        private TextBox txtboxEdge2;
        private TextBox txtboxNodo;
        private TextBox txtboxEdge1;
        private Label label1;
        private Label label2;
        private Button btnAggiungiEdge;
        private Button btnAggiungiNodo;
        private Panel panel;
        private Panel panel6;
        private RadioButton rbtnImportaDaFile;
        private TextBox txtStringaInput;
        private RadioButton rbtnImportaDaStringa;
        private Button btnImporta;
        private RadioButton rbtnEsportaInFile;
        private TextBox txtStringaOutput;
        private RadioButton rbtnEsportaInStringa;
        private Button btnEsporta;
        private Panel panel8;
        private TextBox divisoreTextBox;
        private Button btnContaNodiDivisibili;
        private RadioButton rbtnDivisore;
        private RadioButton rbtnEsportaInFileG;
        private TextBox txtStringaOutputG;
        private RadioButton rbtnEsportaInStringaG;
        private Button btnEsportaG;
        private Panel panel10;
        private RadioButton rbtnImportaDaFileG;
        private TextBox txtStringaInputG;
        private RadioButton rbtnImportaDaStringaG;
        private Button btnImportaG;
        private Panel panel11;
        private RadioButton rbtnSommaNodi;
        private TextBox txtNodoPartenza1;
        private Button btnSomma;
        private RadioButton rbtnSommaRagg;
        private RadioButton rbtnSommaTutti;
        private Panel panel5;
        private Button btnBFS;
        private TextBox txtNodoPartenza2;
        private Button btnDFS;
    }
}