using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IValuesh.Dicionario;

namespace FormExameIValue.Isaac
{
    public partial class FormLeitura : Form
    {
        public FormLeitura()
        {
            InitializeComponent();
        }

        private void BtnBuscarArquivo_Click(object sender, EventArgs e)
        {
            FileDialogLeitor.ShowDialog();
        }

        private void FileDialogLeitor_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FileDialogLeitor.FileName))
            {
                PreencherResultado(Leitor.Ler(File.ReadAllText(FileDialogLeitor.FileName)));
            }
            else
            {
                LimparCampos();
            }
        }

        private void PreencherResultado(List<Palavra> pPalavras)
        {
            if (pPalavras != null && pPalavras.Count > 0)
            {
                LabelArquivoLido.Text = Path.GetFileName(FileDialogLeitor.FileName);

                TxtPreposicoes.Text = pPalavras.Count(p => p is Preposicao).ToString();
                TxtVerbos.Text = pPalavras.Count(p => p is Verbo).ToString();
                TxtVerbosPrimeiraPessoa.Text = pPalavras.Where(p => p is Verbo).Count(p => ((Verbo)p).IsPrimeiraPessoa()).ToString();
            }
        }

        private void LimparCampos()
        {
            LabelArquivoLido.Text = string.Empty;

            TxtPreposicoes.Text = string.Empty;
            TxtVerbos.Text = string.Empty;
            TxtVerbosPrimeiraPessoa.Text = string.Empty;
        }
    }
}
