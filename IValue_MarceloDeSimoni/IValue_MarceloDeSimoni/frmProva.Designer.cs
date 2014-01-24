namespace IValue_MarceloDeSimoni
{
    partial class frmProva
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
            this.cboQuestao = new System.Windows.Forms.ComboBox();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblRespostaValor = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboQuestao
            // 
            this.cboQuestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestao.FormattingEnabled = true;
            this.cboQuestao.Location = new System.Drawing.Point(31, 42);
            this.cboQuestao.Name = "cboQuestao";
            this.cboQuestao.Size = new System.Drawing.Size(284, 21);
            this.cboQuestao.TabIndex = 0;
            this.cboQuestao.SelectedIndexChanged += new System.EventHandler(this.cboQuestao_SelectedIndexChanged);
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Location = new System.Drawing.Point(31, 25);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(109, 13);
            this.lblQuestao.TabIndex = 1;
            this.lblQuestao.Text = "Selecione a Questão:";
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(331, 25);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(105, 13);
            this.lblArquivo.TabIndex = 3;
            this.lblArquivo.Text = "Selecione o Arquivo:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(31, 115);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(64, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta:";
            // 
            // lblRespostaValor
            // 
            this.lblRespostaValor.AutoSize = true;
            this.lblRespostaValor.Location = new System.Drawing.Point(93, 115);
            this.lblRespostaValor.Name = "lblRespostaValor";
            this.lblRespostaValor.Size = new System.Drawing.Size(0, 13);
            this.lblRespostaValor.TabIndex = 6;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(334, 42);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(374, 20);
            this.txtArquivo.TabIndex = 7;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(715, 38);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 8;
            this.btnCarregar.Text = "&Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // frmProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 153);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblRespostaValor);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.cboQuestao);
            this.MaximizeBox = false;
            this.Name = "frmProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I-Value - Marcelo De Simoni";
            this.Load += new System.EventHandler(this.frmProva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuestao;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblRespostaValor;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnCarregar;
    }
}

