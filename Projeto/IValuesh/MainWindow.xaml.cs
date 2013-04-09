using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace IValuesh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region .:Variables:.

        private string fileName = "";
        private string fileText = "";

        #endregion

        #region .:Events:.

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file after the user has been prompted for the file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            fileName = GetFileName();
            if (fileName != String.Empty)
            {
                fileText = File.ReadAllText(fileName);
            }

            if (!String.IsNullOrEmpty(fileText))
            {
                Answers(fileText);
                txtFileName.Text = fileName;
            }
        }

        #endregion

        #region .:Methods:.

        /// <summary>
        /// Use the common dialog to get a valid file name.
        /// Filtering for .txt.
        /// Starting in predefined location.
        /// </summary>
        private string GetFileName()
        {
            string fname = String.Empty;

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = @"C:";
            openFileDlg.DefaultExt = ".txt"; // Default file extension
            openFileDlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            bool? result = openFileDlg.ShowDialog();

            if (result == true)
            {
                fname = openFileDlg.FileName;
            }
            return fname;
        }

        /// <summary>
        /// Fill the fields with the answers
        /// </summary>
        /// <param name="fileText"></param>
        private void Answers(string fileText)
        {
            List<String> lstWords = fileText.Split(' ').ToList();
            int countPrep = 0;
            int countVerb = 0;
            int countVerbFirstPerson = 0;

            lstWords.ForEach(delegate(String word)
            {

                if (word.Length == 3 && (word.EndsWith("t") || word.EndsWith("s") || word.EndsWith("w") || word.EndsWith("l") || word.EndsWith("h")))
                {
                    if (!word.Contains("m"))
                        countPrep++;
                }

                if (word.Length >= 8 && (word.EndsWith("t") || word.EndsWith("s") || word.EndsWith("w") || word.EndsWith("l") || word.EndsWith("h")))
                {
                    countVerb++;

                    if (word.StartsWith("t") || word.StartsWith("s") || word.StartsWith("w") || word.StartsWith("l") || word.StartsWith("h"))
                        countVerbFirstPerson++;
                }
            });

            txtPreposicoes.Text = countPrep.ToString();
            txtVerb.Text = countVerb.ToString();
            txtVerbFirstPerson.Text = countVerbFirstPerson.ToString();
        }

        #endregion

    }
}
