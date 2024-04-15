using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography;

namespace GDKlaba3WordSearcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Declare a list to hold the file lines
        List<string> FileLines = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            // Open a file dialog
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                // Set the file dialog to show only *.txt file or all files
                openDialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Allow only single file selection
                openDialog.Multiselect = false;

                // Make sure the user didn't clicked the 'Cancel' button
                if (openDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Update the current file label with the filename only (not the full path)
                    label_CurrentFile.Text = $"Current file: {Path.GetFileName(openDialog.FileName)}";

                    // Add each line of the txt file into the list
                    foreach (string line in File.ReadAllLines(openDialog.FileName, Encoding.UTF8))
                        FileLines.Add(line);

                    textBox1.Text = File.ReadAllText(openDialog.FileName);
                }
                
                    

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the list
            list_SearchResults.Items.Clear();

            // Count the number of line so you will be able to present it on the results list later on
            int iLineNumber = 1;

            // For each item in the 'FileLines' list
            foreach (var item in FileLines)
            {
                // Check whether the current line contains the term the user typed in the searchbox
                // I'm using 'ToLower()' to ignore case
                if (item.ToLower().Contains(text_SearchTerm.Text.ToLower()))
                {
                    // Create new ListViewItem to be added later on to the results list
                    // Add the first column the complete line that contains the term in the searchbox
                    ListViewItem lvi = new ListViewItem(item);

                    // Add the line number to the second column
                    lvi.SubItems.Add(iLineNumber.ToString());

                    // Add the ListviewItem to the results list
                    list_SearchResults.Items.Add(lvi);
                }

                // Increment the line number variable
                iLineNumber++;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

   
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
