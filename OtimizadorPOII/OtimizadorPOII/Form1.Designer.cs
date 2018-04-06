namespace OtimizadorPOII
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ligacao = new System.Windows.Forms.Label();
            this.caixeiroviajante = new System.Windows.Forms.RadioButton();
            this.quaseotimo = new System.Windows.Forms.RadioButton();
            this.extensaominima = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tablesize = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.go = new System.Windows.Forms.Button();
            this.metodos = new System.Windows.Forms.GroupBox();
            this.tabeladados = new System.Windows.Forms.DataGridView();
            this.calcular = new System.Windows.Forms.Button();
            this.zmelhor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablesize)).BeginInit();
            this.metodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeladados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ligacao
            // 
            this.ligacao.Location = new System.Drawing.Point(6, 16);
            this.ligacao.Name = "ligacao";
            this.ligacao.Size = new System.Drawing.Size(408, 206);
            this.ligacao.TabIndex = 5;
            // 
            // caixeiroviajante
            // 
            this.caixeiroviajante.AutoSize = true;
            this.caixeiroviajante.Location = new System.Drawing.Point(6, 19);
            this.caixeiroviajante.Name = "caixeiroviajante";
            this.caixeiroviajante.Size = new System.Drawing.Size(103, 17);
            this.caixeiroviajante.TabIndex = 0;
            this.caixeiroviajante.TabStop = true;
            this.caixeiroviajante.Text = "Caixeiro Viajante";
            this.caixeiroviajante.UseVisualStyleBackColor = true;
            // 
            // quaseotimo
            // 
            this.quaseotimo.AutoSize = true;
            this.quaseotimo.Location = new System.Drawing.Point(6, 42);
            this.quaseotimo.Name = "quaseotimo";
            this.quaseotimo.Size = new System.Drawing.Size(128, 17);
            this.quaseotimo.TabIndex = 1;
            this.quaseotimo.TabStop = true;
            this.quaseotimo.Text = "Quase Ótimo (Guloso)";
            this.quaseotimo.UseVisualStyleBackColor = true;
            // 
            // extensaominima
            // 
            this.extensaominima.AutoSize = true;
            this.extensaominima.Location = new System.Drawing.Point(6, 65);
            this.extensaominima.Name = "extensaominima";
            this.extensaominima.Size = new System.Drawing.Size(107, 17);
            this.extensaominima.TabIndex = 2;
            this.extensaominima.TabStop = true;
            this.extensaominima.Text = "Extensão Mínima";
            this.extensaominima.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fluxo Máximo";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamanho da Tabela";
            // 
            // tablesize
            // 
            this.tablesize.Location = new System.Drawing.Point(10, 170);
            this.tablesize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tablesize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.tablesize.Name = "tablesize";
            this.tablesize.Size = new System.Drawing.Size(124, 20);
            this.tablesize.TabIndex = 5;
            this.tablesize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tablesize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(10, 196);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(124, 23);
            this.go.TabIndex = 7;
            this.go.Text = "Gerar Tabela";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // metodos
            // 
            this.metodos.Controls.Add(this.go);
            this.metodos.Controls.Add(this.radioButton1);
            this.metodos.Controls.Add(this.tablesize);
            this.metodos.Controls.Add(this.label1);
            this.metodos.Controls.Add(this.radioButton4);
            this.metodos.Controls.Add(this.extensaominima);
            this.metodos.Controls.Add(this.quaseotimo);
            this.metodos.Controls.Add(this.caixeiroviajante);
            this.metodos.Location = new System.Drawing.Point(12, 12);
            this.metodos.Name = "metodos";
            this.metodos.Size = new System.Drawing.Size(140, 225);
            this.metodos.TabIndex = 0;
            this.metodos.TabStop = false;
            this.metodos.Text = "Métodos";
            // 
            // tabeladados
            // 
            this.tabeladados.AllowUserToAddRows = false;
            this.tabeladados.AllowUserToDeleteRows = false;
            this.tabeladados.AllowUserToResizeColumns = false;
            this.tabeladados.AllowUserToResizeRows = false;
            this.tabeladados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabeladados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabeladados.Location = new System.Drawing.Point(158, 12);
            this.tabeladados.Name = "tabeladados";
            this.tabeladados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabeladados.Size = new System.Drawing.Size(580, 225);
            this.tabeladados.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(6, 19);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(124, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // zmelhor
            // 
            this.zmelhor.Location = new System.Drawing.Point(174, 21);
            this.zmelhor.Name = "zmelhor";
            this.zmelhor.ReadOnly = true;
            this.zmelhor.Size = new System.Drawing.Size(100, 20);
            this.zmelhor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.zmelhor);
            this.groupBox1.Controls.Add(this.calcular);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "z* =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "z* = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ligacao);
            this.groupBox2.Location = new System.Drawing.Point(318, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Percurso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabeladados);
            this.Controls.Add(this.metodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otimizador POII";
            ((System.ComponentModel.ISupportInitialize)(this.tablesize)).EndInit();
            this.metodos.ResumeLayout(false);
            this.metodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeladados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ligacao;
        private System.Windows.Forms.RadioButton caixeiroviajante;
        private System.Windows.Forms.RadioButton quaseotimo;
        private System.Windows.Forms.RadioButton extensaominima;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tablesize;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.GroupBox metodos;
        private System.Windows.Forms.DataGridView tabeladados;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox zmelhor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

