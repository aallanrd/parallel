//* ITCR - SSC - Katherine Tuz
//* Arquitectura Computadores
//* II Proyecto Programado.

using System;
using System.Collections;
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
        // Ver archivo Metodos.cs 
        // Todos los métodos de las funciones principales
        Metodos iM ;


        //Variables dirección de los archivos
        string dirArchivoClientes = "";
        string dirArchivoPerfiles = "";
        string dirArchivoCompras = "";

        //Constructor.
        public Form1()
        {
            InitializeComponent();
        }

        //Buscar Archivo #1 Clientes
        private void searchClient_Click(object sender, EventArgs e)
        {
            dirArchivoClientes = buscarArchivo(1);
             iM = new Metodos(dirArchivoClientes, dirArchivoCompras, dirArchivoPerfiles);

        }
        //Buscar Archivo #2 Perfiles
        private void searchProfile_Click(object sender, EventArgs e)
        {
            dirArchivoPerfiles = buscarArchivo(2);
             iM = new Metodos(dirArchivoClientes, dirArchivoCompras, dirArchivoPerfiles);

        }

        //Buscar Archivo #3 Compras
        private void searchShop_Click(object sender, EventArgs e)
        {
            
            dirArchivoCompras = buscarArchivo(3);
            iM = new Metodos(dirArchivoClientes, dirArchivoCompras, dirArchivoPerfiles);

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

     
        //Añadir una persona a la lista de clientes a consultar.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try { 
            if (!listClientes.Items.Contains(listTClientes.SelectedItem))
            {
                    //var cliente =  instanciaMetodos.buscarCliente(listTClientes.SelectedItem);
                    //listClientes.Items.Add(cliente);
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

        //Quitar a una persona de la lista de clientes a consultar
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Elimina el elemento de la Lista para Consultas
            listClientes.Items.Remove(listClientes.SelectedItem);

        }
        /* Funcion principal de busqueda para las mayores compras
        *  Recibe objetos desde la ventana.
        *  
        */
        private void buttonMC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //Obtener las fechas
            var date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            //Llama a la funcion de mayor compra

            string type = comboBox1.SelectedItem.ToString();
            try { 
            //************************
            //Obtiene un Array de los resultados del metodo de Mayor compra
            ArrayList cmc = iM.mayorCompra (date1,  date2, type);
            //************************           
            //Esto es imprimir en el RichTextBox
            foreach (string line in cmc)
            {
                richTextBox1.Text += line + "\n";
            }
            }
            catch (Exception)
            {
                richTextBox1.Text += "<--Aquí..... Debes elegir un archivo" + "\n";
            }
        }

        

        /* Funcion principal de busqueda de compras de clientes
     */
        private void buttonBC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //Obtener las fechas
            var date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
           
            //Cual tipo de método va a correr 
            string type = comboBox1.SelectedItem.ToString();

            //************************
            //Ejecuta funcion de Metodos.cs instanciado en instanciaMetodos
            //************************
           
            //Lista de clientes a consultar
            String[] array = new String[listClientes.Items.Count];
            listClientes.Items.CopyTo(array, 0);
            
            //************************
            //************************
            try {
                //Obtiene un Array de los resultados del metodo de Busqueda de compras
                //para N personas
                ArrayList cbc =  iM.buscarCompras
                    (date1,
                    date2,
                    array,
                    type);
                //Esto es imprimir en el RichTextBox
                foreach (string line in cbc)
            {
                richTextBox1.Text += line + "\n";
            }
            }
            catch(Exception)
            {
                richTextBox1.Text += "xxDeberias elegir a alguien para analizar" + "\n";
            }

        }

        /* Funcion principal de busqueda de compras sospechosas
       * 
       * 
       */
        private void buttonCS_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //Obtener las fechas
            var date1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var date2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");

            //Cual tipo de método va a correr 
            string type = comboBox1.SelectedItem.ToString();

            //************************
            //Ejecuta funcion de Metodos.cs instanciado en instanciaMetodos
            //************************

            //Lista de clientes a consultar
            String[] array = new String[listClientes.Items.Count];

            string perfil = perfilText.Text;

            //************************
            //************************
            try
            {
                //Obtiene un Array de los resultados del metodo de Busqueda de compras
                //para N personas
                ArrayList bcs = iM.buscarComprasSospechosas
                    (date1,
                    date2,
                    perfil,
                    type);
                //Esto es imprimir en el RichTextBox
                foreach (string line in bcs)
                {
                    richTextBox1.Text += line + "\n";
                }
            }
            catch (Exception)
            {
                richTextBox1.Text += "xxDeberias elegir a alguien para analizar" + "\n";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
