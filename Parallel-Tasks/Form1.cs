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
        Metodos instanciaMetodos = new Metodos();

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
                            listTClientes.Items.Clear();
                            foreach (string line in lines)
                            {
                                string[] values = line.Split(',');
                                listTClientes.Items.Add(values[1]);
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

     
        private void buttonAdd_Click(object sender, EventArgs e)
        {

           try { 
            if (!listClientes.Items.Contains(listTClientes.SelectedItem))
            {
                listClientes.Items.Add(listTClientes.SelectedItem);
            }
            else
            {
                //No hacer nada, si ya el item existe.
            }
            }catch(Exception)
            {

                MessageBox.Show("Deberias elegir a alguien","Mensaje Importante ");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Elimina el elemento de la Lista para Consultas
            listClientes.Items.Remove(listClientes.SelectedItem);

        }
        /* Funcion principal de busqueda para las mayores compras
        * 
        * 
        */
        private void buttonMC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text += comboBox1.SelectedItem + "\n";
            //Start Timer 
            var watch = System.Diagnostics.Stopwatch.StartNew();

            //Obtener las fechas
            var date1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            var date2 = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            //Llama a la funcion de mayor compra
            
            string cmc = instanciaMetodos.mayorCompra(date1, date2,dirArchivoCompras);
            richTextBox1.Text += cmc + "\n";

           
            //Stop Timer
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            var sec = TimeSpan.FromMilliseconds(elapsedMs).TotalSeconds;
            richTextBox2.Text += "Tiempo Función (ms) : " + sec + "\n";

        }

        /* Funcion principal de busqueda de compras de clientes
     * 
     * 
     */
        private void buttonBC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado aún", "Mensaje Importante ");
        }

        /* Funcion principal de busqueda de compras sospechosas
       * 
       * 
       */
        private void buttonCS_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }
    }
}
