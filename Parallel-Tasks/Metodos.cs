using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Tasks
{
    class Metodos
    {
        string[] linesClientes;
        string[] linesCompras;
        string[] linesPerfiles;

        public Metodos(string dACC, string dACO, string dAPE)
        {
           try { 
           linesClientes = File.ReadAllLines(dACC);
                //direccion Archivo Compras
            }
            catch (Exception)
            {

            }
            try { 
            linesCompras = File.ReadAllLines(dACO);
            }
            catch (Exception)
            {

            }
            //direccion Archivo Perfiles
            try
            {
                linesPerfiles = File.ReadAllLines(dAPE);
            }
            catch (Exception)
            {

            }
            
        }

        /*
         *· Determinar que cliente posee la mayor compra en un rango de 
         * fechas determinado. (Este rango lo seleccionará el usuario de la aplicación)
         * Recibe las fechas y la dirección del archivo a leer.
         * Retorna un array de resultados de el cliente y el rendimiento.
         * cmc = (C)liente (M)ayor (C)ompra.
         */

        //Array de Resultados
        ArrayList cmc;
        // Variable comparación 
        string client = "No he encontrado cliente";
        double montoMayor = 0;

        // Primer Metodo
        public ArrayList mayorCompra(string date1, string date2,string type)
        {
            cmc =  new ArrayList(); 
            //Convierte las fechas a Datetime.
            DateTime Date1 = DateTime.Parse(date1);
            DateTime Date2 = DateTime.Parse(date2);
            //Start Timer 
            var watch = Stopwatch.StartNew();
            try
            {   //Lee todas las lineas y las guarda en un array
                

                if (type.Equals("Parallel"))
                {
                    Parallel.ForEach(linesCompras, (line) =>
                    {
                        mayorCompraMain(line, Date1, Date2);
                    });

                }
                else
                {
                foreach (string line in linesCompras)
                {
                    mayorCompraMain(line, Date1, Date2);

                }
            }
                //Recorrer cada linea de compras.
                cmc.Add("Resultados Tareas:");
                cmc.Add("Lines Readed: " + linesCompras.Length);


            }
            catch (Exception)
            {
                cmc.Add("IO Exception | Busca un archivo de compras <-" + "\n");

            }
            //Añade el cliente al array de respuesta
            cmc.Add(client);
            //Detiene el reloj
            watch.Stop();
            //Convertir de Milisegundos a Segundos
            var elapsedMs = watch.ElapsedMilliseconds;
            var sec = TimeSpan.FromMilliseconds(elapsedMs).TotalSeconds;
            //Añade el tiempo al array de respuesta
          
            cmc.Add("Tiempo Función (ms) : " + sec + "\n");

            //Retorna el array de respuesta.
            return cmc;
        }

     
        public void mayorCompraMain(string line,DateTime Date1, DateTime Date2)
        {
            //Divide los valores por comas dentro de un array
            string[] values = line.Split(',');
            //La fecha esta en la posicion 6
            var fecha = values[5];
            //Convertir la fecha (String) a DateTime
            DateTime myDate = DateTime.Parse(fecha);
            //Compara la fecha del elemento
            int result1 = DateTime.Compare(myDate, Date1);
            int result2 = DateTime.Compare(myDate, Date2);

            //Si Entra en el rango de fechas.
            if ((result1 >= 1) && (result2 <= 0))
            {
                // richTextBox1.Text += line + myDate + "\n";

                try
                {   //Obtenermos el monto de esa compra
                    //Esta en la posicion 4 y convertirlo a double.
                    double monto = Convert.ToDouble(values[4]);

                    //Comparar el monto obtenido, con el mayor actual
                    if (monto >= montoMayor)
                    {
                       
                        //Si es mayor se actualiza el cliente 
                        // y monto de la persona con mayor compra.
                        montoMayor = monto;
                        //Obtener Tarea Actual
                       

                        //Coloca Tarea
                        client = ("Este es el cliente con la mayor compra:\n"
                            + values[1] + " Monto: " + values[4] + " Fecha: " +
                            values[5] + " Thread:" + Thread.CurrentThread.ManagedThreadId); 
                    }
                }
                //Excepcion de formato
                catch (FormatException) { cmc.Add("Format Exception\n"); }
                //Exception de Overflow
                catch (OverflowException) { cmc.Add("OverflowException\n"); }

            }
        }

        // Segundo Metodo
        public ArrayList buscarCompras (string date1, string date2,
            string[] nombre_clientes,string type)
        {
            foreach(string x in nombre_clientes)
            {
                var y = x;

            }
            return null;
        }

    }
}
