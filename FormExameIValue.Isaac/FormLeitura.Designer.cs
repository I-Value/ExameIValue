namespace FormExameIValue.Isaac
{
    partial class FormLeitura
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
            this.FileDialogLeitor = new System.Windows.Forms.OpenFileDialog();
            this.BtnBuscarArquivo = new System.Windows.Forms.Button();
            this.GbResultado = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPreposicoes = new System.Windows.Forms.TextBox();
            this.TxtVerbos = new System.Windows.Forms.TextBox();
            this.TxtVerbosPrimeiraPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelArquivoLido = new System.Windows.Forms.Label();
            this.GbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileDialogLeitor
            // 
            this.FileDialogLeitor.FileName = "openFileDialog1";
            this.FileDialogLeitor.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogLeitor_FileOk);
            // 
            // BtnBuscarArquivo
            // 
            this.BtnBuscarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarArquivo.Location = new System.Drawing.Point(12, 12);
            this.BtnBuscarArquivo.Name = "BtnBuscarArquivo";
            this.BtnBuscarArquivo.Size = new System.Drawing.Size(237, 23);
            this.BtnBuscarArquivo.TabIndex = 1;
            this.BtnBuscarArquivo.Text = "Escolher arquivo...";
            this.BtnBuscarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarArquivo.UseVisualStyleBackColor = true;
            this.BtnBuscarArquivo.Click += new System.EventHandler(this.BtnBuscarArquivo_Click);
            // 
            // GbResultado
            // 
            this.GbResultado.Controls.Add(this.LabelArquivoLido);
            this.GbResultado.Controls.Add(this.label5);
            this.GbResultado.Controls.Add(this.label4);
            this.GbResultado.Controls.Add(this.label3);
            this.GbResultado.Controls.Add(this.TxtVerbosPrimeiraPessoa);
            this.GbResultado.Controls.Add(this.TxtVerbos);
            this.GbResultado.Controls.Add(this.TxtPreposicoes);
            this.GbResultado.Controls.Add(this.label2);
            this.GbResultado.Location = new System.Drawing.Point(12, 54);
            this.GbResultado.Name = "GbResultado";
            this.GbResultado.Size = new System.Drawing.Size(448, 161);
            this.GbResultado.TabIndex = 2;
            this.GbResultado.TabStop = false;
            this.GbResultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade de Preposições";
            // 
            // TxtPreposicoes
            // 
            this.TxtPreposicoes.Location = new System.Drawing.Point(311, 17);
            this.TxtPreposicoes.Name = "TxtPreposicoes";
            this.TxtPreposicoes.ReadOnly = true;
            this.TxtPreposicoes.Size = new System.Drawing.Size(131, 20);
            this.TxtPreposicoes.TabIndex = 1;
            // 
            // TxtVerbos
            // 
            this.TxtVerbos.Location = new System.Drawing.Point(311, 43);
            this.TxtVerbos.Name = "TxtVerbos";
            this.TxtVerbos.ReadOnly = true;
            this.TxtVerbos.Size = new System.Drawing.Size(131, 20);
            this.TxtVerbos.TabIndex = 2;
            // 
            // TxtVerbosPrimeiraPessoa
            // 
            this.TxtVerbosPrimeiraPessoa.Location = new System.Drawing.Point(311, 69);
            this.TxtVerbosPrimeiraPessoa.Name = "TxtVerbosPrimeiraPessoa";
            this.TxtVerbosPrimeiraPessoa.ReadOnly = true;
            this.TxtVerbosPrimeiraPessoa.Size = new System.Drawing.Size(131, 20);
            this.TxtVerbosPrimeiraPessoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de Verbos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade de Verbos em Primeira Pessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Arquivo Lido:";
            // 
            // LabelArquivoLido
            // 
            this.LabelArquivoLido.AutoSize = true;
            this.LabelArquivoLido.Location = new System.Drawing.Point(82, 138);
            this.LabelArquivoLido.Name = "LabelArquivoLido";
            this.LabelArquivoLido.Size = new System.Drawing.Size(0, 13);
            this.LabelArquivoLido.TabIndex = 7;
            // 
            // FormLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 227);
            this.Controls.Add(this.GbResultado);
            this.Controls.Add(this.BtnBuscarArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLeitura";
            this.Text = "Leitura de IValuesh ";
            this.GbResultado.ResumeLayout(false);
            this.GbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDialogLeitor;
        private System.Windows.Forms.Button BtnBuscarArquivo;
        private System.Windows.Forms.GroupBox GbResultado;
        private System.Windows.Forms.Label LabelArquivoLido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVerbosPrimeiraPessoa;
        private System.Windows.Forms.TextBox TxtVerbos;
        private System.Windows.Forms.TextBox TxtPreposicoes;
        private System.Windows.Forms.Label label2;
    }
}