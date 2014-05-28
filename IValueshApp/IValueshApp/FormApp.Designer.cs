namespace IValueshApp
{
    partial class FormApp
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
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblPrepositions = new System.Windows.Forms.Label();
            this.txtTotalPrepositions = new System.Windows.Forms.TextBox();
            this.txtTotalVerbs1 = new System.Windows.Forms.TextBox();
            this.lblVerbs1 = new System.Windows.Forms.Label();
            this.txtTotalVerbs2 = new System.Windows.Forms.TextBox();
            this.lblVerbs2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(344, 12);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(120, 23);
            this.btnArquivo.TabIndex = 0;
            this.btnArquivo.Text = "Selecione o arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(64, 13);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(274, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(12, 16);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(46, 13);
            this.lblArquivo.TabIndex = 2;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(15, 39);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(119, 23);
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "Processar resposta";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblPrepositions
            // 
            this.lblPrepositions.AutoSize = true;
            this.lblPrepositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepositions.Location = new System.Drawing.Point(12, 95);
            this.lblPrepositions.Name = "lblPrepositions";
            this.lblPrepositions.Size = new System.Drawing.Size(149, 15);
            this.lblPrepositions.TabIndex = 4;
            this.lblPrepositions.Text = "Total de preposições: ";
            // 
            // txtTotalPrepositions
            // 
            this.txtTotalPrepositions.Location = new System.Drawing.Point(259, 95);
            this.txtTotalPrepositions.Name = "txtTotalPrepositions";
            this.txtTotalPrepositions.ReadOnly = true;
            this.txtTotalPrepositions.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrepositions.TabIndex = 5;
            // 
            // txtTotalVerbs1
            // 
            this.txtTotalVerbs1.Location = new System.Drawing.Point(259, 128);
            this.txtTotalVerbs1.Name = "txtTotalVerbs1";
            this.txtTotalVerbs1.ReadOnly = true;
            this.txtTotalVerbs1.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVerbs1.TabIndex = 7;
            // 
            // lblVerbs1
            // 
            this.lblVerbs1.AutoSize = true;
            this.lblVerbs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbs1.Location = new System.Drawing.Point(12, 128);
            this.lblVerbs1.Name = "lblVerbs1";
            this.lblVerbs1.Size = new System.Drawing.Size(113, 15);
            this.lblVerbs1.TabIndex = 6;
            this.lblVerbs1.Text = "Total de verbos: ";
            // 
            // txtTotalVerbs2
            // 
            this.txtTotalVerbs2.Location = new System.Drawing.Point(259, 157);
            this.txtTotalVerbs2.Name = "txtTotalVerbs2";
            this.txtTotalVerbs2.ReadOnly = true;
            this.txtTotalVerbs2.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVerbs2.TabIndex = 9;
            // 
            // lblVerbs2
            // 
            this.lblVerbs2.AutoSize = true;
            this.lblVerbs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbs2.Location = new System.Drawing.Point(12, 157);
            this.lblVerbs2.Name = "lblVerbs2";
            this.lblVerbs2.Size = new System.Drawing.Size(245, 15);
            this.lblVerbs2.TabIndex = 8;
            this.lblVerbs2.Text = "Total de verbos em primeira pessoa: ";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 294);
            this.Controls.Add(this.txtTotalVerbs2);
            this.Controls.Add(this.lblVerbs2);
            this.Controls.Add(this.txtTotalVerbs1);
            this.Controls.Add(this.lblVerbs1);
            this.Controls.Add(this.txtTotalPrepositions);
            this.Controls.Add(this.lblPrepositions);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnArquivo);
            this.Name = "FormApp";
            this.Text = "IValuesh App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblPrepositions;
        private System.Windows.Forms.TextBox txtTotalPrepositions;
        private System.Windows.Forms.TextBox txtTotalVerbs1;
        private System.Windows.Forms.Label lblVerbs1;
        private System.Windows.Forms.TextBox txtTotalVerbs2;
        private System.Windows.Forms.Label lblVerbs2;
    }
}

