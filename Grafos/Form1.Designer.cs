namespace Grafos
{
    partial class frmGrafos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.gbVertices = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminarVertice = new System.Windows.Forms.Button();
            this.lbVertices = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txAgregarVertice = new System.Windows.Forms.TextBox();
            this.btAgregarVertice = new System.Windows.Forms.Button();
            this.gbArcos = new System.Windows.Forms.GroupBox();
            this.nuPeso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEliminarArco = new System.Windows.Forms.Button();
            this.lbArcos = new System.Windows.Forms.ListBox();
            this.txDestino = new System.Windows.Forms.TextBox();
            this.txOrigen = new System.Windows.Forms.TextBox();
            this.btAgregarArco = new System.Windows.Forms.Button();
            this.gbGrafo = new System.Windows.Forms.GroupBox();
            this.cbTipoGrafo = new System.Windows.Forms.ComboBox();
            this.btNuevoGrafo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbIndicacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbRecorridos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNodoRecorrido = new System.Windows.Forms.TextBox();
            this.btAnchura = new System.Windows.Forms.Button();
            this.btProfundidad = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbDistancia = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDist2 = new System.Windows.Forms.TextBox();
            this.txtDist1 = new System.Windows.Forms.TextBox();
            this.btCalcularDist = new System.Windows.Forms.Button();
            this.gbGradoNodo = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGradoNodo = new System.Windows.Forms.TextBox();
            this.btCalcularGrado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.gbVertices.SuspendLayout();
            this.gbArcos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPeso)).BeginInit();
            this.gbGrafo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbRecorridos.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.gbDistancia.SuspendLayout();
            this.gbGradoNodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGrafo
            // 
            this.pbGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGrafo.BackColor = System.Drawing.Color.White;
            this.pbGrafo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrafo.Location = new System.Drawing.Point(210, 146);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(642, 347);
            this.pbGrafo.TabIndex = 0;
            this.pbGrafo.TabStop = false;
            this.pbGrafo.Click += new System.EventHandler(this.pbGrafo_Click);
            this.pbGrafo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGrafo_Paint);
            this.pbGrafo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseMove);
            // 
            // gbVertices
            // 
            this.gbVertices.Controls.Add(this.label1);
            this.gbVertices.Controls.Add(this.btEliminarVertice);
            this.gbVertices.Controls.Add(this.lbVertices);
            this.gbVertices.Controls.Add(this.label6);
            this.gbVertices.Controls.Add(this.txAgregarVertice);
            this.gbVertices.Controls.Add(this.btAgregarVertice);
            this.gbVertices.Location = new System.Drawing.Point(12, 175);
            this.gbVertices.Name = "gbVertices";
            this.gbVertices.Size = new System.Drawing.Size(192, 127);
            this.gbVertices.TabIndex = 1;
            this.gbVertices.TabStop = false;
            this.gbVertices.Text = "Vértices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Vértices:";
            // 
            // btEliminarVertice
            // 
            this.btEliminarVertice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarVertice.Location = new System.Drawing.Point(121, 66);
            this.btEliminarVertice.Name = "btEliminarVertice";
            this.btEliminarVertice.Size = new System.Drawing.Size(65, 22);
            this.btEliminarVertice.TabIndex = 3;
            this.btEliminarVertice.Text = "Eliminar";
            this.btEliminarVertice.UseVisualStyleBackColor = true;
            this.btEliminarVertice.Click += new System.EventHandler(this.btEliminarVertice_Click);
            // 
            // lbVertices
            // 
            this.lbVertices.FormattingEnabled = true;
            this.lbVertices.ItemHeight = 15;
            this.lbVertices.Location = new System.Drawing.Point(6, 66);
            this.lbVertices.Name = "lbVertices";
            this.lbVertices.Size = new System.Drawing.Size(109, 49);
            this.lbVertices.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre:";
            // 
            // txAgregarVertice
            // 
            this.txAgregarVertice.Location = new System.Drawing.Point(60, 22);
            this.txAgregarVertice.Name = "txAgregarVertice";
            this.txAgregarVertice.Size = new System.Drawing.Size(55, 23);
            this.txAgregarVertice.TabIndex = 1;
            // 
            // btAgregarVertice
            // 
            this.btAgregarVertice.Location = new System.Drawing.Point(121, 22);
            this.btAgregarVertice.Name = "btAgregarVertice";
            this.btAgregarVertice.Size = new System.Drawing.Size(65, 23);
            this.btAgregarVertice.TabIndex = 0;
            this.btAgregarVertice.Text = "Agregar";
            this.btAgregarVertice.UseVisualStyleBackColor = true;
            this.btAgregarVertice.Click += new System.EventHandler(this.btAgregarVertice_Click);
            // 
            // gbArcos
            // 
            this.gbArcos.Controls.Add(this.nuPeso);
            this.gbArcos.Controls.Add(this.label4);
            this.gbArcos.Controls.Add(this.label5);
            this.gbArcos.Controls.Add(this.label3);
            this.gbArcos.Controls.Add(this.label2);
            this.gbArcos.Controls.Add(this.btEliminarArco);
            this.gbArcos.Controls.Add(this.lbArcos);
            this.gbArcos.Controls.Add(this.txDestino);
            this.gbArcos.Controls.Add(this.txOrigen);
            this.gbArcos.Controls.Add(this.btAgregarArco);
            this.gbArcos.Location = new System.Drawing.Point(12, 311);
            this.gbArcos.Name = "gbArcos";
            this.gbArcos.Size = new System.Drawing.Size(192, 187);
            this.gbArcos.TabIndex = 4;
            this.gbArcos.TabStop = false;
            this.gbArcos.Text = "Arcos";
            // 
            // nuPeso
            // 
            this.nuPeso.Location = new System.Drawing.Point(60, 69);
            this.nuPeso.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nuPeso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPeso.Name = "nuPeso";
            this.nuPeso.Size = new System.Drawing.Size(55, 23);
            this.nuPeso.TabIndex = 5;
            this.nuPeso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Arcos:";
            // 
            // btEliminarArco
            // 
            this.btEliminarArco.Location = new System.Drawing.Point(121, 115);
            this.btEliminarArco.Name = "btEliminarArco";
            this.btEliminarArco.Size = new System.Drawing.Size(65, 27);
            this.btEliminarArco.TabIndex = 3;
            this.btEliminarArco.Text = "Eliminar";
            this.btEliminarArco.UseVisualStyleBackColor = true;
            this.btEliminarArco.Click += new System.EventHandler(this.btEliminarArco_Click);
            // 
            // lbArcos
            // 
            this.lbArcos.FormattingEnabled = true;
            this.lbArcos.ItemHeight = 15;
            this.lbArcos.Location = new System.Drawing.Point(6, 115);
            this.lbArcos.Name = "lbArcos";
            this.lbArcos.Size = new System.Drawing.Size(109, 64);
            this.lbArcos.TabIndex = 2;
            // 
            // txDestino
            // 
            this.txDestino.Location = new System.Drawing.Point(60, 44);
            this.txDestino.Name = "txDestino";
            this.txDestino.Size = new System.Drawing.Size(55, 23);
            this.txDestino.TabIndex = 1;
            // 
            // txOrigen
            // 
            this.txOrigen.Location = new System.Drawing.Point(60, 19);
            this.txOrigen.Name = "txOrigen";
            this.txOrigen.Size = new System.Drawing.Size(55, 23);
            this.txOrigen.TabIndex = 1;
            // 
            // btAgregarArco
            // 
            this.btAgregarArco.Location = new System.Drawing.Point(121, 66);
            this.btAgregarArco.Name = "btAgregarArco";
            this.btAgregarArco.Size = new System.Drawing.Size(65, 26);
            this.btAgregarArco.TabIndex = 0;
            this.btAgregarArco.Text = "Agregar";
            this.btAgregarArco.UseVisualStyleBackColor = true;
            this.btAgregarArco.Click += new System.EventHandler(this.btAgregarArco_Click);
            // 
            // gbGrafo
            // 
            this.gbGrafo.Controls.Add(this.textBox1);
            this.gbGrafo.Controls.Add(this.cbTipoGrafo);
            this.gbGrafo.Controls.Add(this.btNuevoGrafo);
            this.gbGrafo.Location = new System.Drawing.Point(12, 12);
            this.gbGrafo.Name = "gbGrafo";
            this.gbGrafo.Size = new System.Drawing.Size(192, 161);
            this.gbGrafo.TabIndex = 5;
            this.gbGrafo.TabStop = false;
            this.gbGrafo.Text = "Grafo";
            // 
            // cbTipoGrafo
            // 
            this.cbTipoGrafo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGrafo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoGrafo.FormattingEnabled = true;
            this.cbTipoGrafo.Items.AddRange(new object[] {
            "Dirigido",
            "No Dirigido"});
            this.cbTipoGrafo.Location = new System.Drawing.Point(6, 20);
            this.cbTipoGrafo.Name = "cbTipoGrafo";
            this.cbTipoGrafo.Size = new System.Drawing.Size(122, 27);
            this.cbTipoGrafo.TabIndex = 2;
            this.cbTipoGrafo.SelectedIndexChanged += new System.EventHandler(this.cbTipoGrafo_SelectedIndexChanged);
            // 
            // btNuevoGrafo
            // 
            this.btNuevoGrafo.Location = new System.Drawing.Point(134, 20);
            this.btNuevoGrafo.Name = "btNuevoGrafo";
            this.btNuevoGrafo.Size = new System.Drawing.Size(52, 27);
            this.btNuevoGrafo.TabIndex = 1;
            this.btNuevoGrafo.Text = "Nuevo";
            this.btNuevoGrafo.UseVisualStyleBackColor = true;
            this.btNuevoGrafo.Click += new System.EventHandler(this.btNuevoGrafo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbIndicacion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbIndicacion
            // 
            this.lbIndicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndicacion.Name = "lbIndicacion";
            this.lbIndicacion.Size = new System.Drawing.Size(0, 17);
            // 
            // gbRecorridos
            // 
            this.gbRecorridos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecorridos.Controls.Add(this.label9);
            this.gbRecorridos.Controls.Add(this.txtNodoRecorrido);
            this.gbRecorridos.Controls.Add(this.btAnchura);
            this.gbRecorridos.Controls.Add(this.btProfundidad);
            this.gbRecorridos.Location = new System.Drawing.Point(627, 12);
            this.gbRecorridos.Name = "gbRecorridos";
            this.gbRecorridos.Size = new System.Drawing.Size(225, 71);
            this.gbRecorridos.TabIndex = 7;
            this.gbRecorridos.TabStop = false;
            this.gbRecorridos.Text = "Recorridos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nodo:";
            // 
            // txtNodoRecorrido
            // 
            this.txtNodoRecorrido.Location = new System.Drawing.Point(57, 29);
            this.txtNodoRecorrido.Name = "txtNodoRecorrido";
            this.txtNodoRecorrido.Size = new System.Drawing.Size(55, 23);
            this.txtNodoRecorrido.TabIndex = 5;
            // 
            // btAnchura
            // 
            this.btAnchura.Location = new System.Drawing.Point(127, 16);
            this.btAnchura.Name = "btAnchura";
            this.btAnchura.Size = new System.Drawing.Size(87, 23);
            this.btAnchura.TabIndex = 2;
            this.btAnchura.Text = "Anchura";
            this.btAnchura.UseVisualStyleBackColor = true;
            this.btAnchura.Click += new System.EventHandler(this.btAnchura_Click);
            // 
            // btProfundidad
            // 
            this.btProfundidad.Location = new System.Drawing.Point(127, 41);
            this.btProfundidad.Name = "btProfundidad";
            this.btProfundidad.Size = new System.Drawing.Size(87, 23);
            this.btProfundidad.TabIndex = 1;
            this.btProfundidad.Text = "Profundidad";
            this.btProfundidad.UseVisualStyleBackColor = true;
            this.btProfundidad.Click += new System.EventHandler(this.btProfundidad_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscar.Controls.Add(this.label7);
            this.gbBuscar.Controls.Add(this.btBuscar);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(429, 92);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(190, 48);
            this.gbBuscar.TabIndex = 8;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar Vértice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre:";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(128, 18);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(56, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(67, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(55, 23);
            this.txtBuscar.TabIndex = 5;
            // 
            // gbDistancia
            // 
            this.gbDistancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDistancia.Controls.Add(this.label8);
            this.gbDistancia.Controls.Add(this.label10);
            this.gbDistancia.Controls.Add(this.txtDist2);
            this.gbDistancia.Controls.Add(this.txtDist1);
            this.gbDistancia.Controls.Add(this.btCalcularDist);
            this.gbDistancia.Location = new System.Drawing.Point(429, 12);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new System.Drawing.Size(192, 75);
            this.gbDistancia.TabIndex = 9;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Camino entre dos nodos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Destino:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Origen:";
            // 
            // txtDist2
            // 
            this.txtDist2.Location = new System.Drawing.Point(60, 44);
            this.txtDist2.Name = "txtDist2";
            this.txtDist2.Size = new System.Drawing.Size(55, 23);
            this.txtDist2.TabIndex = 1;
            // 
            // txtDist1
            // 
            this.txtDist1.Location = new System.Drawing.Point(60, 19);
            this.txtDist1.Name = "txtDist1";
            this.txtDist1.Size = new System.Drawing.Size(55, 23);
            this.txtDist1.TabIndex = 1;
            // 
            // btCalcularDist
            // 
            this.btCalcularDist.Location = new System.Drawing.Point(121, 41);
            this.btCalcularDist.Name = "btCalcularDist";
            this.btCalcularDist.Size = new System.Drawing.Size(65, 26);
            this.btCalcularDist.TabIndex = 0;
            this.btCalcularDist.Text = "Calcular";
            this.btCalcularDist.UseVisualStyleBackColor = true;
            this.btCalcularDist.Click += new System.EventHandler(this.txtCalcularDist_Click);
            // 
            // gbGradoNodo
            // 
            this.gbGradoNodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGradoNodo.Controls.Add(this.label11);
            this.gbGradoNodo.Controls.Add(this.txtGradoNodo);
            this.gbGradoNodo.Controls.Add(this.btCalcularGrado);
            this.gbGradoNodo.Location = new System.Drawing.Point(627, 89);
            this.gbGradoNodo.Name = "gbGradoNodo";
            this.gbGradoNodo.Size = new System.Drawing.Size(225, 48);
            this.gbGradoNodo.TabIndex = 10;
            this.gbGradoNodo.TabStop = false;
            this.gbGradoNodo.Text = "Grado de un nodo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nodo:";
            // 
            // txtGradoNodo
            // 
            this.txtGradoNodo.Location = new System.Drawing.Point(54, 18);
            this.txtGradoNodo.Name = "txtGradoNodo";
            this.txtGradoNodo.Size = new System.Drawing.Size(55, 23);
            this.txtGradoNodo.TabIndex = 1;
            // 
            // btCalcularGrado
            // 
            this.btCalcularGrado.Location = new System.Drawing.Point(145, 18);
            this.btCalcularGrado.Name = "btCalcularGrado";
            this.btCalcularGrado.Size = new System.Drawing.Size(74, 23);
            this.btCalcularGrado.TabIndex = 0;
            this.btCalcularGrado.Text = "Calcular";
            this.btCalcularGrado.UseVisualStyleBackColor = true;
            this.btCalcularGrado.Click += new System.EventHandler(this.btCalcularGrado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(177, 99);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Para crear un grafo dirigido o no dirigido, seleccione el tipo de grafo deseado e" +
    "n la caja de opciones y a continuación haga clic en \'Nuevo\'.";
            // 
            // frmGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.gbGradoNodo);
            this.Controls.Add(this.gbDistancia);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbRecorridos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbGrafo);
            this.Controls.Add(this.gbArcos);
            this.Controls.Add(this.gbVertices);
            this.Controls.Add(this.pbGrafo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGrafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafos - Víctor Manuel Flamenco Quijada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGrafos_Load);
            this.SizeChanged += new System.EventHandler(this.frmGrafos_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.gbVertices.ResumeLayout(false);
            this.gbVertices.PerformLayout();
            this.gbArcos.ResumeLayout(false);
            this.gbArcos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPeso)).EndInit();
            this.gbGrafo.ResumeLayout(false);
            this.gbGrafo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbRecorridos.ResumeLayout(false);
            this.gbRecorridos.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
            this.gbGradoNodo.ResumeLayout(false);
            this.gbGradoNodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.GroupBox gbVertices;
        private System.Windows.Forms.Button btEliminarVertice;
        private System.Windows.Forms.ListBox lbVertices;
        private System.Windows.Forms.TextBox txAgregarVertice;
        private System.Windows.Forms.Button btAgregarVertice;
        private System.Windows.Forms.GroupBox gbArcos;
        private System.Windows.Forms.Button btEliminarArco;
        private System.Windows.Forms.ListBox lbArcos;
        private System.Windows.Forms.TextBox txOrigen;
        private System.Windows.Forms.Button btAgregarArco;
        private System.Windows.Forms.GroupBox gbGrafo;
        private System.Windows.Forms.Button btNuevoGrafo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbIndicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDestino;
        private System.Windows.Forms.NumericUpDown nuPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbRecorridos;
        private System.Windows.Forms.Button btProfundidad;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btAnchura;
        private System.Windows.Forms.GroupBox gbDistancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDist2;
        private System.Windows.Forms.TextBox txtDist1;
        private System.Windows.Forms.Button btCalcularDist;
        private System.Windows.Forms.ComboBox cbTipoGrafo;
        private System.Windows.Forms.GroupBox gbGradoNodo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGradoNodo;
        private System.Windows.Forms.Button btCalcularGrado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNodoRecorrido;
        private System.Windows.Forms.TextBox textBox1;
    }
}

