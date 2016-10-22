using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parallel_Tasks
{
    class Cliente
    {
        string cedula ;
        string nombre;
        string apell1;
        string apell2;
        string direcc;
        string telefono;
        string perfil;

        public Cliente()
        {

        }
       
        public Cliente(string cedula,string nombre,string apell1,
            string apell2,string direcc,string telefono,string perfil)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apell1 = apell1;
            this.apell2 = apell2;
            this.direcc = direcc;
            this.telefono = telefono;
            this.perfil = perfil;

        }
    }
}
