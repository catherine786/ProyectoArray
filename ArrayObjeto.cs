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
            sucursales[] objSucursales = new sucursales[7];
            //Pregunto de ctas sucursales va a ingresar datos
            Console.WriteLine("Ingrese de cuantas sucursales va a ingresar datos:");
            int cantSuc = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < cantSuc; i++)
            {
                Console.WriteLine("Ingrese el numero de la sucursal: ");
                int numS = Convert.ToInt32(Console.ReadLine());

                objSucursales[numS] = new sucursales();

                Console.WriteLine("Ingresar el monto de venta: ");
                objSucursales[numS].MontoDeVenta = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de empleados: ");
                objSucursales[numS].CantidadDeEmpleados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de clientes que compraron algo este mes: ");
                objSucursales[numS].CantClientesMes = Convert.ToInt32(Console.ReadLine());
                
            }

            


            string[] NombreSucursal = new string[7] { "Once", "San Nicolas", "Almagro", "Microcentro", "Palermo", "San Cristobal", "Parque Patricios" };



            
            Console.ReadKey();
        }
        public class sucursales
        {
            //Metodo constructor
            public sucursales()
            {

            }

            //Atributos
            public decimal MontoDeVenta = 0;
            public int CantidadDeEmpleados = 0;
            public int CantClientesMes = 0;

            //Metodos
            

            public void PromedioVentas( int sumVt, int cantSuc )
            {
                Console.WriteLine("El promedio de ventas es de: {0} ", sumVt / cantSuc);
            }

            public void PromedioEmpleados(int sumEmp, int cantSuc)
            {
                Console.WriteLine("El promedio de empleados es de: {0} ", sumEmp / cantSuc);
            }


        }
        
        public static class calculos
        {
            //metodos
            public static int MostrarDatos(sucursales[] arreglo)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Monto de venta {0}, Emp {1}, Clientes {2}", arreglo[i].MontoDeVenta, arreglo[i].CantidadDeEmpleados, arreglo[i].CantClientesMes);
                }
                    
            }
        }
    }
}
