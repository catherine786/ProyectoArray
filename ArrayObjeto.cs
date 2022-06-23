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
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Estamos por ingresar los datos de la sucursal {0}", i + 1);
                
           
            }
            Console.ReadKey();
        }
        public class sucursales
        {
            //Metodo constructor
            public sucursales()
            {

            }
            //Atributos
            int MontoDeVenta;
            int Empleados;
            int Compradores;
            //Metodos
            
        }
    }
}
