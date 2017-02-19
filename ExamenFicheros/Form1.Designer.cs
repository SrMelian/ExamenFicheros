namespace ExamenFicheros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tP1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVtbPartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbSets1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVtbSets2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLee = new System.Windows.Forms.Button();
            this.bGraba = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nUPJ2s3 = new System.Windows.Forms.NumericUpDown();
            this.nUPJ2s2 = new System.Windows.Forms.NumericUpDown();
            this.nUPJ2s1 = new System.Windows.Forms.NumericUpDown();
            this.nUPJ1s3 = new System.Windows.Forms.NumericUpDown();
            this.nUPJ1s2 = new System.Windows.Forms.NumericUpDown();
            this.nUPJ1s1 = new System.Windows.Forms.NumericUpDown();
            this.cBJ2 = new System.Windows.Forms.ComboBox();
            this.tBJ1 = new System.Windows.Forms.TextBox();
            this.nUDPartido = new System.Windows.Forms.NumericUpDown();
            this.lJugador2 = new System.Windows.Forms.Label();
            this.lJugador1 = new System.Windows.Forms.Label();
            this.lPartido = new System.Windows.Forms.Label();
            this.tP2 = new System.Windows.Forms.TabPage();
            this.bOrdena = new System.Windows.Forms.Button();
            this.cBJugador = new System.Windows.Forms.ComboBox();
            this.lJugador = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DGV2tbJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV2tbGrandSlams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPartido)).BeginInit();
            this.tP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tP1);
            this.tabControl1.Controls.Add(this.tP2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tP1
            // 
            this.tP1.Controls.Add(this.dataGridView1);
            this.tP1.Controls.Add(this.bLee);
            this.tP1.Controls.Add(this.bGraba);
            this.tP1.Controls.Add(this.listBox1);
            this.tP1.Controls.Add(this.nUPJ2s3);
            this.tP1.Controls.Add(this.nUPJ2s2);
            this.tP1.Controls.Add(this.nUPJ2s1);
            this.tP1.Controls.Add(this.nUPJ1s3);
            this.tP1.Controls.Add(this.nUPJ1s2);
            this.tP1.Controls.Add(this.nUPJ1s1);
            this.tP1.Controls.Add(this.cBJ2);
            this.tP1.Controls.Add(this.tBJ1);
            this.tP1.Controls.Add(this.nUDPartido);
            this.tP1.Controls.Add(this.lJugador2);
            this.tP1.Controls.Add(this.lJugador1);
            this.tP1.Controls.Add(this.lPartido);
            this.tP1.Location = new System.Drawing.Point(4, 22);
            this.tP1.Name = "tP1";
            this.tP1.Padding = new System.Windows.Forms.Padding(3);
            this.tP1.Size = new System.Drawing.Size(700, 252);
            this.tP1.TabIndex = 0;
            this.tP1.Text = "Partidos";
            this.tP1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVtbPartido,
            this.DGVtbJugador1,
            this.DGVtbJugador2,
            this.DGVtbSets1,
            this.DGVtbSets2});
            this.dataGridView1.Location = new System.Drawing.Point(103, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 98);
            this.dataGridView1.TabIndex = 15;
            // 
            // DGVtbPartido
            // 
            this.DGVtbPartido.HeaderText = "Partido";
            this.DGVtbPartido.Name = "DGVtbPartido";
            this.DGVtbPartido.ReadOnly = true;
            // 
            // DGVtbJugador1
            // 
            this.DGVtbJugador1.HeaderText = "Jugador 1";
            this.DGVtbJugador1.Name = "DGVtbJugador1";
            this.DGVtbJugador1.ReadOnly = true;
            // 
            // DGVtbJugador2
            // 
            this.DGVtbJugador2.HeaderText = "Jugador2";
            this.DGVtbJugador2.Name = "DGVtbJugador2";
            this.DGVtbJugador2.ReadOnly = true;
            // 
            // DGVtbSets1
            // 
            this.DGVtbSets1.HeaderText = "Sets 1";
            this.DGVtbSets1.Name = "DGVtbSets1";
            this.DGVtbSets1.ReadOnly = true;
            // 
            // DGVtbSets2
            // 
            this.DGVtbSets2.HeaderText = "Sets 2";
            this.DGVtbSets2.Name = "DGVtbSets2";
            this.DGVtbSets2.ReadOnly = true;
            // 
            // bLee
            // 
            this.bLee.Location = new System.Drawing.Point(21, 188);
            this.bLee.Name = "bLee";
            this.bLee.Size = new System.Drawing.Size(71, 41);
            this.bLee.TabIndex = 14;
            this.bLee.Text = "Lee";
            this.bLee.UseVisualStyleBackColor = true;
            this.bLee.Click += new System.EventHandler(this.bLee_Click);
            // 
            // bGraba
            // 
            this.bGraba.Location = new System.Drawing.Point(21, 131);
            this.bGraba.Name = "bGraba";
            this.bGraba.Size = new System.Drawing.Size(71, 41);
            this.bGraba.TabIndex = 13;
            this.bGraba.Text = "Graba";
            this.bGraba.UseVisualStyleBackColor = true;
            this.bGraba.Click += new System.EventHandler(this.bGraba_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "NADAL",
            "FEDERER",
            "DJOKOVIC",
            "MURRAY"});
            this.listBox1.Location = new System.Drawing.Point(459, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 69);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // nUPJ2s3
            // 
            this.nUPJ2s3.Location = new System.Drawing.Point(374, 85);
            this.nUPJ2s3.Name = "nUPJ2s3";
            this.nUPJ2s3.Size = new System.Drawing.Size(41, 20);
            this.nUPJ2s3.TabIndex = 11;
            // 
            // nUPJ2s2
            // 
            this.nUPJ2s2.Location = new System.Drawing.Point(313, 85);
            this.nUPJ2s2.Name = "nUPJ2s2";
            this.nUPJ2s2.Size = new System.Drawing.Size(41, 20);
            this.nUPJ2s2.TabIndex = 10;
            // 
            // nUPJ2s1
            // 
            this.nUPJ2s1.Location = new System.Drawing.Point(251, 85);
            this.nUPJ2s1.Name = "nUPJ2s1";
            this.nUPJ2s1.Size = new System.Drawing.Size(41, 20);
            this.nUPJ2s1.TabIndex = 9;
            // 
            // nUPJ1s3
            // 
            this.nUPJ1s3.Location = new System.Drawing.Point(374, 46);
            this.nUPJ1s3.Name = "nUPJ1s3";
            this.nUPJ1s3.Size = new System.Drawing.Size(41, 20);
            this.nUPJ1s3.TabIndex = 8;
            // 
            // nUPJ1s2
            // 
            this.nUPJ1s2.Location = new System.Drawing.Point(313, 46);
            this.nUPJ1s2.Name = "nUPJ1s2";
            this.nUPJ1s2.Size = new System.Drawing.Size(41, 20);
            this.nUPJ1s2.TabIndex = 7;
            // 
            // nUPJ1s1
            // 
            this.nUPJ1s1.Location = new System.Drawing.Point(251, 46);
            this.nUPJ1s1.Name = "nUPJ1s1";
            this.nUPJ1s1.Size = new System.Drawing.Size(41, 20);
            this.nUPJ1s1.TabIndex = 6;
            // 
            // cBJ2
            // 
            this.cBJ2.FormattingEnabled = true;
            this.cBJ2.Location = new System.Drawing.Point(103, 84);
            this.cBJ2.Name = "cBJ2";
            this.cBJ2.Size = new System.Drawing.Size(122, 21);
            this.cBJ2.TabIndex = 5;
            this.cBJ2.Validating += new System.ComponentModel.CancelEventHandler(this.cBJ2_Validating);
            // 
            // tBJ1
            // 
            this.tBJ1.Location = new System.Drawing.Point(103, 45);
            this.tBJ1.Name = "tBJ1";
            this.tBJ1.ReadOnly = true;
            this.tBJ1.Size = new System.Drawing.Size(122, 20);
            this.tBJ1.TabIndex = 4;
            // 
            // nUDPartido
            // 
            this.nUDPartido.Location = new System.Drawing.Point(103, 12);
            this.nUDPartido.Name = "nUDPartido";
            this.nUDPartido.Size = new System.Drawing.Size(41, 20);
            this.nUDPartido.TabIndex = 3;
            this.nUDPartido.Validating += new System.ComponentModel.CancelEventHandler(this.nUDPartido_Validating);
            // 
            // lJugador2
            // 
            this.lJugador2.AutoSize = true;
            this.lJugador2.Location = new System.Drawing.Point(18, 87);
            this.lJugador2.Name = "lJugador2";
            this.lJugador2.Size = new System.Drawing.Size(57, 13);
            this.lJugador2.TabIndex = 2;
            this.lJugador2.Text = "Jugador 2:";
            // 
            // lJugador1
            // 
            this.lJugador1.AutoSize = true;
            this.lJugador1.Location = new System.Drawing.Point(18, 48);
            this.lJugador1.Name = "lJugador1";
            this.lJugador1.Size = new System.Drawing.Size(57, 13);
            this.lJugador1.TabIndex = 1;
            this.lJugador1.Text = "Jugador 1:";
            // 
            // lPartido
            // 
            this.lPartido.AutoSize = true;
            this.lPartido.Location = new System.Drawing.Point(18, 14);
            this.lPartido.Name = "lPartido";
            this.lPartido.Size = new System.Drawing.Size(43, 13);
            this.lPartido.TabIndex = 0;
            this.lPartido.Text = "Partido:";
            // 
            // tP2
            // 
            this.tP2.Controls.Add(this.bOrdena);
            this.tP2.Controls.Add(this.cBJugador);
            this.tP2.Controls.Add(this.lJugador);
            this.tP2.Controls.Add(this.dataGridView2);
            this.tP2.Location = new System.Drawing.Point(4, 22);
            this.tP2.Name = "tP2";
            this.tP2.Padding = new System.Windows.Forms.Padding(3);
            this.tP2.Size = new System.Drawing.Size(700, 252);
            this.tP2.TabIndex = 1;
            this.tP2.Text = "Clasificación";
            this.tP2.UseVisualStyleBackColor = true;
            // 
            // bOrdena
            // 
            this.bOrdena.Location = new System.Drawing.Point(362, 136);
            this.bOrdena.Name = "bOrdena";
            this.bOrdena.Size = new System.Drawing.Size(85, 51);
            this.bOrdena.TabIndex = 3;
            this.bOrdena.Text = "Ordena";
            this.bOrdena.UseVisualStyleBackColor = true;
            this.bOrdena.Click += new System.EventHandler(this.bOrdena_Click);
            // 
            // cBJugador
            // 
            this.cBJugador.FormattingEnabled = true;
            this.cBJugador.Location = new System.Drawing.Point(392, 63);
            this.cBJugador.Name = "cBJugador";
            this.cBJugador.Size = new System.Drawing.Size(115, 21);
            this.cBJugador.TabIndex = 2;
            this.cBJugador.SelectedValueChanged += new System.EventHandler(this.cBJugador_SelectedIndexChanged);
            // 
            // lJugador
            // 
            this.lJugador.AutoSize = true;
            this.lJugador.Location = new System.Drawing.Point(425, 29);
            this.lJugador.Name = "lJugador";
            this.lJugador.Size = new System.Drawing.Size(48, 13);
            this.lJugador.TabIndex = 1;
            this.lJugador.Text = "Jugador:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV2tbJugador,
            this.DGV2tbGrandSlams});
            this.dataGridView2.Location = new System.Drawing.Point(15, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 161);
            this.dataGridView2.TabIndex = 0;
            // 
            // DGV2tbJugador
            // 
            this.DGV2tbJugador.HeaderText = "Jugador";
            this.DGV2tbJugador.Name = "DGV2tbJugador";
            this.DGV2tbJugador.ReadOnly = true;
            // 
            // DGV2tbGrandSlams
            // 
            this.DGV2tbGrandSlams.HeaderText = "Grand Slams";
            this.DGV2tbGrandSlams.Name = "DGV2tbGrandSlams";
            this.DGV2tbGrandSlams.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 291);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tP1.ResumeLayout(false);
            this.tP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ2s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPJ1s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPartido)).EndInit();
            this.tP2.ResumeLayout(false);
            this.tP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tP1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbJugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbJugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbSets1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVtbSets2;
        private System.Windows.Forms.Button bLee;
        private System.Windows.Forms.Button bGraba;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nUPJ2s3;
        private System.Windows.Forms.NumericUpDown nUPJ2s2;
        private System.Windows.Forms.NumericUpDown nUPJ2s1;
        private System.Windows.Forms.NumericUpDown nUPJ1s3;
        private System.Windows.Forms.NumericUpDown nUPJ1s2;
        private System.Windows.Forms.NumericUpDown nUPJ1s1;
        private System.Windows.Forms.ComboBox cBJ2;
        private System.Windows.Forms.TextBox tBJ1;
        private System.Windows.Forms.NumericUpDown nUDPartido;
        private System.Windows.Forms.Label lJugador2;
        private System.Windows.Forms.Label lJugador1;
        private System.Windows.Forms.Label lPartido;
        private System.Windows.Forms.TabPage tP2;
        private System.Windows.Forms.Button bOrdena;
        private System.Windows.Forms.ComboBox cBJugador;
        private System.Windows.Forms.Label lJugador;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV2tbJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV2tbGrandSlams;
    }
}

