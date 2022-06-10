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

            


        }
        public class marzo
        {
            public marzo() { }

            public string[] sucursales = new string[8];
            public int id;
            public string Nombre;

            public int NumeroDeSucursal;

            public int MontoDeVenta;

            public int CantidadDeEmpleados;

            public int CantDeClientesDelMes;

            //Metodos
            public void mostrarDatos()
            {
                Console.WriteLine("La sucursal de {0} tiene un monto de venta de {1}, una cantidad de empleados igual a {2} y este mes tuvo {3} clientes", sucursales[i], MontoDeVenta,CantidadDeEmpleados, CantDeClientesDelMes);
            }
            public void mostrarSucursales()
            {
                Console.WriteLine(sucursales)
            }

        }
    }
}
