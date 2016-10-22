using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Tasks
{
    class Metodos
    {

        public string mayorCompra(string date1, string date2,string dirArchivoCompras)
        {
            DateTime Date1 = DateTime.Parse(date1);
            DateTime Date2 = DateTime.Parse(date2);

            string cliente = "No client \n";

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
                            if (monto >= montoMayor)
                            {
                                montoMayor = monto;
                                cliente = "Este es el cliente con la mayor compra:\n" + values[1];
                            }
                        }
                        catch (FormatException) { cliente += "Format Exception"; }
                        catch (OverflowException) { cliente += "OverflowException"; }

                    }

                }
            }
            catch (Exception)
            {
                cliente += "IO Exception | Busca un archivo de compras <-";

            }
            return cliente;
        }
    }
}
