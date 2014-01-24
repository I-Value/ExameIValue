using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace IValue_MarceloDeSimoni
{
    public partial class frmProva : Form
    {

        #region Propriedades

        private const int QUESTAO_01 = 1;
        private const int QUESTAO_02 = 2;

        #endregion

        #region Construtores

        public frmProva()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmProva_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarComboQuestao();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                var FD = new OpenFileDialog();
                if (FD.ShowDialog() == DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;
                    txtArquivo.Text = fileToOpen;

                    FileInfo File = new FileInfo(FD.FileName);
                    StreamReader reader = new StreamReader(fileToOpen);

                    ProcessarArquivo(reader);
                }
            }
            catch (Exception)
            {   
                throw;
            }
        }

        private void cboQuestao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRespostaValor.Text = String.Empty;
            txtArquivo.Text = String.Empty;
        }

        #endregion

        #region Métodos

        private void CarregarComboQuestao()
        {
            var lista = new List<ListItem>();
            lista.Add(new ListItem() { ID = 1, Text = "Questão 01 - Contar Preposições" });
            lista.Add(new ListItem() { ID = 2, Text = "Questão 02 - Contar Verbos" });

            cboQuestao.DataSource = lista;
            cboQuestao.ValueMember = "ID";
            cboQuestao.DisplayMember = "Text";
        }

        private void ProcessarArquivo(StreamReader reader)
        {
            Utilitario util = new Utilitario();

            if (Convert.ToInt32(cboQuestao.SelectedValue) == QUESTAO_01)
            {
                lblRespostaValor.Text = "O número de preposições no arquivo é " + util.ContarPreposicoes(reader) + ".";
            }
            else if (Convert.ToInt32(cboQuestao.SelectedValue) == QUESTAO_02)
            {
                int verbos = 0;
                int primeira_pessoa = 0;

                util.ContarVerbos(reader, out verbos, out primeira_pessoa);

                lblRespostaValor.Text = "O número de verbos no arquivo é " + verbos + ". Onde " + primeira_pessoa + " estão em primeira pessoa.";
            }
        }

        #endregion

    }
}
