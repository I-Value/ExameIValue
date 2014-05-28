using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IValueshApp
{
    public partial class FormApp : Form
    {
        private string fileName;
        private string text;
        private int totalPrepositions;
        private int totalVerbs1;
        private int totalVerbs2;

        public FormApp()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            SetFileName();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            ProcessFile();
        }

        /// <summary>
        /// Seta o nome do arquivo.
        /// </summary>
        private void SetFileName()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = dialog.FileName;
                fileName = dialog.FileName;
            }
        }

        /// <summary>
        /// Processa o arquivo para somar os totais de preposições, verbos e verbos em primeira pessoa.
        /// </summary>
        private void ProcessFile()
        {
            try
            {
                if (fileName != null && fileName.Trim() != "")
                {
                    totalPrepositions = 0;
                    totalVerbs1 = 0;
                    totalVerbs2 = 0;
                    
                    //Lê o arquivo e separa as palavras
                    text = File.ReadAllText(fileName).ToLower();
                    string[] words = text.Split(' ');

                    //Processa os totais
                    foreach (string w in words)
                    {
                        //Foo: t, s, w, l e h
                        string word = w.Trim();
                        if(word.Length > 0 && IsFoo(word[word.Length - 1]))
                        {
                            if (word.Length == 3 && !word.Contains('m'))
                            {
                                totalPrepositions++;
                            }

                            else if (word.Length >= 8)
                            {
                                totalVerbs1++;

                                if (IsFoo(word[0]))
                                {
                                    totalVerbs2++;
                                }
                            }
                        }

                    }

                    //Mostra os totais
                    txtTotalPrepositions.Text = totalPrepositions.ToString();
                    txtTotalVerbs1.Text = totalVerbs1.ToString();
                    txtTotalVerbs2.Text = totalVerbs2.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione um arquivo antes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retorna se um char é do tipo Foo.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsFoo(char c)
        {
            if (c == 't' || c == 's' || c == 'w' || c == 'l' || c == 'h')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
