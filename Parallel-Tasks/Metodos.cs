using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Tasks
{
    class Metodos
    {
        /*
         *· Determinar que cliente posee la mayor compra en un rango de 
         * fechas determinado. (Este rango lo seleccionará el usuario de la aplicación)
         * Recibe las fechas y la dirección del archivo a leer.
         * Retorna un array de resultados de el cliente y el rendimiento.
         */

        public ArrayList mayorCompra(string date1, string date2,string dirArchivoCompras)
        {
            //Convierte las fechas a Datetime.
            DateTime Date1 = DateTime.Parse(date1);
            DateTime Date2 = DateTime.Parse(date2);
            //Start Timer 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //Array de Resultados
            ArrayList cmc = new ArrayList();
            // Variable comparación 
            string client= "No he encontrado cliente";
            
            try
            {
                
                //Lee todas las lineas y las guarda en un array
                string[] lines = System.IO.File.ReadAllLines(dirArchivoCompras);

                double montoMayor = 0;

                //Recorrer cada linea de compras.
                foreach (string line in lines)
                {
                    //Divide los valores por comas dentro de un array
                    string[] values = line.Split(',');
                    //La fecha esta en la posicion 6
                    var fecha = values[6];
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
                            double monto = Convert.ToDouble(values[5]);

                            //Comparar el monto obtenido, con el mayor actual
                            if (monto >= montoMayor)
                            {
                                //Si es mayor se actualiza el cliente 
                                // y monto de la persona con mayor compra.
                                montoMayor = monto;
                                client = ("Este es el cliente con la mayor compra:\n"
                                    + values[1] + " Monto: " + values[5]  + " Fecha: " +
                                    values[6]);
                            }
                        }
                        //Excepcion de formato
                        catch (FormatException) { cmc.Add("Format Exception\n"); }
                        //Exception de Overflow
                        catch (OverflowException) { cmc.Add("OverflowException\n"); }

                    }

                }
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
            cmc.Add("Resultados Tareas:");
            cmc.Add("Tiempo Función (ms) : " + sec + "\n");

            //Retorna el array de respuesta.
            return cmc;
        }

        public string buscarCompra( string[] clientes, string date1, string date2)
        {
            return "Nothing";
        }

        public Cliente buscarCliente(string id)
        {
            return new Cliente();
        }



    }
}
