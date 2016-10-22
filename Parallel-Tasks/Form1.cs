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

        private void Process_Click(object sender, EventArgs e)
        {
            var window = new Form2(dirArchivoClientes,dirArchivoPerfiles,dirArchivoCompras,comboBox1.SelectedItem);
            window.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void file3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

           
            if (!listBox2.Items.Contains(listBox1.SelectedItem))
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                // item already exists in listbox
            }
        }
    }
}
