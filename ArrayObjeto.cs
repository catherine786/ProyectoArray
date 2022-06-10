using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            marzo[] objMarzo = new marzo[6];

            objMarzo[0].id = 1;
            objMarzo[0].Nombre = "once";

            objMarzo[1].id = 2;
            objMarzo[1].Nombre = "San Nicolás";

            objMarzo[2].id = 3;
            objMarzo[2].Nombre = "Almagro";

            objMarzo[3].id = 4;
            objMarzo[3].Nombre = "Microcentro";

            objMarzo[4].id = 5;
            objMarzo[4].Nombre = "Microcentro";

            objMarzo[5].id = 6;
            objMarzo[5].Nombre = "Microcentro";

            objMarzo[6].id = 7;
            objMarzo[6].Nombre = "Microcentro";


        }
        public class marzo
        {
            public marzo() { }

            public int id;
            public string Nombre;
            
            public int NumeroDeSucursal
            {

            }
        
            public int MontoDeVenta
            {

            }

            public int CantidadDeEmpleados
            {

            }

            public int CantDeClientesDelMes
            {

            }
        }
    }
}
