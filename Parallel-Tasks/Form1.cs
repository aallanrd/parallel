 //* ITCR - SSC - Katherine Tuz
 //* Arquitectura Computadores
 //* II Proyecto Programado.

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
        string dirArchivoClientes = "";
        string dirArchivoPerfiles = "";
        string dirArchivoCompras = "";

        public Form1()
        {
            InitializeComponent();
        }

        //Buscar Archivo #1 Clientes
        private void searchClient_Click(object sender, EventArgs e)
        {
            dirArchivoClientes = buscarArchivo(1);
        }
        //Buscar Archivo #2 Perfiles
        private void searchProfile_Click(object sender, EventArgs e)
        {
            dirArchivoPerfiles = buscarArchivo(2);
        }
        
        //Buscar Archivo #3 Compras
        private void searchShop_Click(object sender, EventArgs e)
        {
            
            dirArchivoCompras = buscarArchivo(3);
            
        }

        //Busca un archivo y lo asigna a la variable correspondiente
        // Recibe {{ int index }} 1,2,3 para cada archivo
        public string buscarArchivo(int index)
        {
            string archivoDialog = "Not found";

            // Muestra el Dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // Comprueba Aceptar.
            if (result == DialogResult.OK) 
            {
                //Obtiene el Full Path del Archivo
                archivoDialog = openFileDialog1.FileName;
                try
                {
                    switch (index)
                    {  
                        //Dependiendo de cual archivo queremos obtener
                        //lo asigna a su variable correspondiente
                        case 1:
                            dirArchivoClientes = archivoDialog;
                            string[] lines = System.IO.File.ReadAllLines(dirArchivoClientes);
                            listBox1.Items.Clear();
                            foreach (string line in lines)
                            {
                                string[] values = line.Split(',');
                                listBox1.Items.Add(values[1]);
                            }

                            break;
                        case 2:  dirArchivoPerfiles = archivoDialog; break;
                        case 3:  dirArchivoCompras = archivoDialog; break;
                        default: break;
                    }
                }
                catch (IOException e)
                {
                    //Si hay un error en el archivo, es captada
                    //Por el try & catch y la retorna.
                    return  e.ToString() ;
                }
            }

            //Obtenemos el último sub string del path retornado por el FileChooser. 
            // Esto es para no mostrar el FULL Path 
            file1Label.Text = dirArchivoClientes.Substring(dirArchivoClientes.LastIndexOf(("\\")) + 1);
            file2.Text = dirArchivoPerfiles.Substring(dirArchivoPerfiles.LastIndexOf(("\\")) + 1);
            file3.Text = dirArchivoCompras.Substring(dirArchivoCompras.LastIndexOf(("\\")) + 1);
          
            //Retorna el Full Path
            return archivoDialog;
        }

     
        private void button7_Click(object sender, EventArgs e)
        {

           try { 
            if (!listBox2.Items.Contains(listBox1.SelectedItem))
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                // item already exists in listbox
            }
            }catch(Exception)
            {
                MessageBox.Show("Deberias elegir a alguien","Mensaje Importante ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var date1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            var date2 = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            mayorCompra(date1, date2);

        }

        private void mayorCompra(string date1, string date2)
        {

            try
            {
                richTextBox1.Text = "";
                string[] lines = System.IO.File.ReadAllLines(dirArchivoCompras);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    
                    richTextBox1.Text += line + "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deberias Buscar un Archivo", "Mensaje Importante ");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado aún", "Mensaje Importante ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado aún", "Mensaje Importante ");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                string[] lines = System.IO.File.ReadAllLines(dirArchivoCompras);
                foreach (string line in lines)
                {
                    richTextBox1.Text += line + "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deberias Buscar un Archivo", "Mensaje Importante ");

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                string[] lines = System.IO.File.ReadAllLines(dirArchivoPerfiles);
                foreach (string line in lines)
                {

                    richTextBox1.Text += line + "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deberias Buscar un Archivo", "Mensaje Importante ");
            }
        }
    }
}
