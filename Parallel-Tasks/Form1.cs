using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallel_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button Action On Click to Search Clients File
        private void searchClient_Click(object sender, EventArgs e)
        {
            searchFile(1);
        }
        //Button Action On Click to Search Profile File
        private void searchProfile_Click(object sender, EventArgs e)
        {
            searchFile(2);
        }
        
        //Button Action On Click to Search Shop File
        private void searchShop_Click(object sender, EventArgs e)
        {
            searchFile(3);
        }

        public void searchFile(int index)
        {

            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                 //   string text = File.ReadAllText(file);
                  
                   // size = text.Length;
                    string directoryPath = Path.GetDirectoryName(file);
                    switch (index)
                    {  
                        case 1:
                            file1.Text = file;
                            done1.Checked = true;
                            break;
                        case 2:
                            file2.Text = file;
                            done2.Checked = true;
                            break;
                        case 3:
                            file3.Text = file;
                            done3.Checked = true;
                            break;
                        default:
                            break;
                                
                    }
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

       
    }
}
