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
            
            Console.WriteLine("Ingresar la cantidad de sucursales");
            int cantidadSucursales = Convert.ToInt32(Console.ReadLine());
            int[] MontoDeVentas = new int[cantidadSucursales];
            int[] CantidadDeEmpleados = new int[cantidadSucursales];
            int[] CantClientesMes = new int[cantidadSucursales];
            int sumaVentas = 0;

            for (int i = 0; i < cantidadSucursales; i++)
            {
                Console.WriteLine("Ingrese los datos de la sucursal {0}", i + 1);
                Console.WriteLine("Ingresar el monto de venta: ");
                MontoDeVentas[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de empleados: ");
                CantidadDeEmpleados[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de clientes que compraron algo este mes: ");
                CantClientesMes[i] = Convert.ToInt32(Console.ReadLine());

                sumaVentas += MontoDeVentas[i];
            }
            Console.WriteLine(sumaVentas);


            //For de prueba
            /*
            for (int i = 0; i < cantidadSucursales; i++)
            {
                Console.WriteLine("_________________");
                Console.WriteLine(MontoDeVentas[i]);
                Console.WriteLine(CantidadDeEmpleados[i]);
                Console.WriteLine(CantClientesMes[i]);
            }
            */
            Console.ReadKey();
        }
        public class sucursales
        {
            //Metodo constructor
            public sucursales()
            {

            }
            //Atributos

            int cantidadSucursales;
            
            //Metodos
            public void MostrarDatos()
            {
                Console.WriteLine("La sucursal ");
            }

            public void PromedioVentas()
            {
                Console.WriteLine(sumaVentas / cantidadSucursales);
            }
        }
    }
}
