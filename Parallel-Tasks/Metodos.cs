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
            //Read del Archivo 
            try { 
            linesClientes = File.ReadAllLines(dACC);
             
            }
            catch (Exception){}

            //Read del Archivo
            try { 
            linesCompras = File.ReadAllLines(dACO);
            }
            catch (Exception){}
          
            //Read del Archivo
            try
            {
                linesPerfiles = File.ReadAllLines(dAPE);
            }
            catch (Exception){}
            
        }

        /*
         *· Determinar que cliente posee la mayor compra en un rango de 
         * fechas determinado. (Este rango lo seleccionará el usuario de la aplicación)
         * Recibe las fechas y la dirección del archivo a leer.
         * El type es para saber si es parallelo o secuencial
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
            montoMayor = 0;
            //Cliente Mayor Compra
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
                    //Para cada uno de ellos.
                    Parallel.ForEach(linesCompras, (line) =>
                    {
                        //Funcion Auxiliar en Paralello
                       client =  mayorCompraMain(line, Date1, Date2);
                    });

                }
                else
                {
                foreach (string line in linesCompras)
                {
                    //Funcion Auxiliar en Secuencia.
                   client = mayorCompraMain(line, Date1, Date2);

                }
            }
                //Recorrer cada linea de compras.
                cmc.Add("Resultados Tareas:");
                //cmc.Add("Lines Readed: " + linesCompras.Length);
                cmc.Add(client);
            }
            catch (Exception)
            {
                cmc.Add("IO Exception | Busca un archivo de compras <-" + "\n");

            }
            //Añade el cliente al array de respuesta
           
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

     
        public string mayorCompraMain(string line,DateTime Date1, DateTime Date2)
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

                        cmc.Add("Entra en fecha para consulta");
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

            }else
            {
                
            }
            return client;
        }

        /*
         * Determinar las N compras realizadas por alguna persona específica o 
         * por N personas específicas en un rango de fechas determinado.
         * 
         * */
        ArrayList cbc;
      
        public ArrayList buscarCompras (string date1, string date2,
            string[] clientes,string type)
        {

            cbc = new ArrayList();
            //Convierte las fechas a Datetime.
            DateTime Date1 = DateTime.Parse(date1);
            DateTime Date2 = DateTime.Parse(date2);
            //Start Timer 
            var watch = Stopwatch.StartNew();
            try
            {   
                if (type.Equals("Parallel"))
                {
                    Parallel.ForEach(clientes, (cliente) =>
                    {
                        //Para cada uno de ellos.
                        Parallel.ForEach(linesCompras, (line) =>
                       {
                       
                            //Funcion Auxiliar en Paralello
                            client = buscarCompraMain(line,cliente, Date1, Date2);
                           if (client.Equals("No he encontrado cliente"))
                           {

                           }else
                           {
                               cbc.Add(client);
                           }
                       });
                    });

                }
                else
                {
                    foreach (string cliente in clientes)
                    {
                        foreach(string line in linesCompras)
                        {
                            client = buscarCompraMain(line,cliente, Date1, Date2);
                            cbc.Add(client);
                        } 
                        //Funcion Auxiliar en Secuencia.
                        

                    }
                }

                //Recorrer cada linea de compras.
                cbc.Add("Resultados Tareas:");
                cbc.Add("Lines Readed: " + linesCompras.Length);
               
            }
            catch (Exception)
            {
                cbc.Add("IO Exception | Busca un archivo de compras <-" + "\n");

            }
          
            //Detiene el reloj
            watch.Stop();
            //Convertir de Milisegundos a Segundos
            var elapsedMs = watch.ElapsedMilliseconds;
            var sec = TimeSpan.FromMilliseconds(elapsedMs).TotalSeconds;
            //Añade el tiempo al array de respuesta

            cbc.Add("Tiempo Función (ms) : " + sec + "\n");

            //Retorna el array de respuesta.
            return cbc;
            
        }

        public string buscarCompraMain(string line,string cliente, DateTime Date1, DateTime Date2)
        {
            string id_Cliente = buscarCliente(cliente);

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
                {   
                    if(id_Cliente== values[1]) { 
                   //Coloca Tarea
                     client = ("\nEntra en fecha para: "  + cliente
                            + values[1] + " Monto: " + values[4] + " Fecha: " +
                            values[5] + " Thread:" + Thread.CurrentThread.ManagedThreadId);
                    }

                }

                //Excepcion de formato
                catch (FormatException) { cbc.Add("Format Exception\n"); }
                //Exception de Overflow
                catch (OverflowException) { cbc.Add("OverflowException\n"); }

            }
            else
            {

            }
            return client;
        }

        private string buscarCliente(string cliente)
        {
            string cliD = "0";
            foreach (string line in linesClientes)
            {
                string[] values = line.Split(',');
                var nombre = values[1];
                if (nombre.Equals(cliente))
                {
                    cliD = values[0];
                }

            }
            return cliD;
        }

        ArrayList ccs;

        public ArrayList buscarComprasSospechosas(string date1, string date2,
            string perfil, string type)
        {

            ccs = new ArrayList();
            //Convierte las fechas a Datetime.
            DateTime Date1 = DateTime.Parse(date1);
            DateTime Date2 = DateTime.Parse(date2);
            //Start Timer 
            var watch = Stopwatch.StartNew();
            try
            {   


                if (type.Equals("Parallel"))
                {
                    //Para cada uno de ellos.
                    Parallel.ForEach(linesCompras, (line) =>
                    {
                        //Funcion Auxiliar en Paralello
                        client = mayorCompraMain(line, Date1, Date2);
                    });

                }
                else
                {
                    foreach (string line in linesCompras)
                    {
                        //Funcion Auxiliar en Secuencia.
                        client = mayorCompraMain(line, Date1, Date2);

                    }
                }
                //Recorrer cada linea de compras.
                ccs.Add("Resultados Tareas:");
                ccs.Add("Lines Readed: " + linesCompras.Length);
            }
            catch (Exception)
            {
                ccs.Add("IO Exception | Busca un archivo de compras <-" + "\n");

            }
            //Añade el cliente al array de respuesta
            ccs.Add(client);
            //Detiene el reloj
            watch.Stop();
            //Convertir de Milisegundos a Segundos
            var elapsedMs = watch.ElapsedMilliseconds;
            var sec = TimeSpan.FromMilliseconds(elapsedMs).TotalSeconds;
            //Añade el tiempo al array de respuesta

            ccs.Add("Tiempo Función (ms) : " + sec + "\n");

            //Retorna el array de respuesta.
            return ccs;

        }

    }
}
