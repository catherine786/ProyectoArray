using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciacion de la clase
            sucursal[] objSucursal = new sucursal[7];
            string[] NombreSucursal = new string[] { "Once", "San Nicolas", "Almagro", "Microcentro", "Palermo", "San Cristobal", "Parque Patricios" };
            Console.WriteLine("Sucursales:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}  {1}", (i + 1), NombreSucursal[i]);
            }

            for (int i = 0; i < objSucursal.Length; i++)
            {
                Console.WriteLine("De que Sucursal va a ingresar datos?");
                int n = (Convert.ToInt32(Console.ReadLine()) - 1);
                objSucursal[n] = new sucursal();
                Console.WriteLine("Esta por ingresar los datos de la sucursal de: {0}", NombreSucursal[n]);
                objSucursal[n].NumeroDeSucursal= i;
                Console.WriteLine("Ingresar el monto de venta del mes");
                objSucursal[n].MontoDeVenta = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de empleados: ");
                objSucursal[n].CantDeEmpleados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de clientes que compraron algo este mes: ");
                objSucursal[n].CantDeClientes = Convert.ToInt32(Console.ReadLine());
            }
 

            // salida de informacion 
            // calculo del promedio de la edad

            Calcular.Datos(NombreSucursal, objSucursal);
            Calcular.calcPromVenta(objSucursal);
            Calcular.VentasPorEmpleado(NombreSucursal, objSucursal);
            Calcular.VentaMax(NombreSucursal, objSucursal);
            Calcular.VentaMin(NombreSucursal, objSucursal);

        }
    }
    public class sucursal
    {

        // constructor
        public sucursal(){}

        // atributos
        public int NumeroDeSucursal;
        public decimal MontoDeVenta;
        public int CantDeEmpleados;
        public int CantDeClientes;
    }
    public static class Calcular
    {
        
        public static int Datos(string[] NombreSucursal, sucursal[] objSuc)
        {
            for (int i = 0; i < objSuc.Length; i++)
            {
                Console.WriteLine("Datos de la sucursal de {0} \n El monto de venta fue de: ${1} Tienen una cantidad de: {2} empleados y {3} clientes compraron este mes", NombreSucursal[i], objSuc[i].MontoDeVenta, objSuc[i].CantDeEmpleados, objSuc[i].CantDeClientes);
            }
            return 0;
        }

        public static int calcPromVenta(sucursal[] objSuc)
        {
            decimal promedio = 0;
            decimal sumatoria = 0;
            for (int i = 0; i < objSuc.Length; i++)
            {
                sumatoria = sumatoria + objSuc[i].MontoDeVenta;
            }
            promedio = sumatoria / objSuc.Length;
            Console.WriteLine("El promedio de venta de todas las sucursales fue de: ${0} este mes", promedio);
            return 0;
        }
        public static int VentasPorEmpleado(string[] NombreSucursal, sucursal[] objSuc)
        {
            int[] PromPorEmple = new int[objSuc.Length];
            int promedio = 0;
            for (int i = 0; i < objSuc.Length; i++)
            {
                int emple= objSuc[i].CantDeEmpleados;
                int ventas= objSuc[i].CantDeClientes;
                promedio = ventas / emple;
                PromPorEmple[i]= promedio;
                Console.WriteLine("En la sucursal de {0} tuvieron un promedio de {1} ventas por empleado", NombreSucursal[i] , PromPorEmple[i]);
            }
            
            return 0;
        }
        public static int VentaMax(string[] NombreSucursal, sucursal[] objSuc)
        {
            decimal VentaMaxima = objSuc[0].MontoDeVenta;
            int n = objSuc[0].NumeroDeSucursal;
            for (int i = 0; i < objSuc.Length; i++)
            {
                if (VentaMaxima < objSuc[i].MontoDeVenta)
                {
                    VentaMaxima = objSuc[i].MontoDeVenta;
                     n = objSuc[i].NumeroDeSucursal;
                    
                }
            }
            Console.WriteLine("la venta maxima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n], VentaMaxima);


            return 0;

        }
        public static int VentaMin(string[] NombreSucursal, sucursal[] objSuc)
        {
            decimal VentaMinima = objSuc[0].MontoDeVenta;
            int n= objSuc[0].NumeroDeSucursal;
            for (int i = 0; i < objSuc.Length; i++)
            {
                if (VentaMinima > objSuc[i].MontoDeVenta)
                {
                    VentaMinima = objSuc[i].MontoDeVenta;
                    n = objSuc[i].NumeroDeSucursal;

                }

            }
            Console.WriteLine("la venta minima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n], VentaMinima);
            return 0;

        }
    }
}
