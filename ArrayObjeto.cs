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
            sucursal[] objSucursal = new sucursal[2];
            for (int i = 0; i < objSucursal.Length; i++)
            {
                objSucursal[i] = new sucursal();
                objSucursal[i].NumeroDeSucursal = i+1;
                Console.WriteLine("Ingresar el monto de venta de la sucursal N°{0}: ", objSucursal[i].NumeroDeSucursal);
                objSucursal[i].MontoDeVenta = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de empleados: ");
                objSucursal[i].CantDeEmpleados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de clientes que compraron algo este mes: ");
                objSucursal[i].CantDeClientes = Convert.ToInt32(Console.ReadLine());
            }
            // salida de informacion 
            // calculo del promedio de la edad

            Calcular.Datos(objSucursal);
            Calcular.calcPromVenta(objSucursal);
            Calcular.VentasPorEmpleado(objSucursal);
            Calcular.VentaMax(objSucursal);
            Calcular.VentaMin(objSucursal);

        }
    }
    public class sucursal
    {

        // constructor
        public sucursal() { }

        // atributos
        public int NumeroDeSucursal;
        public decimal MontoDeVenta;
        public int CantDeEmpleados;
        public int CantDeClientes;
    }
    public static class Calcular
    {
        public static string[] NombreSucursal = new string[7] { "Once", "San Nicolas", "Almagro", "Microcentro", "Palermo", "San Cristobal", "Parque Patricios" };
        // metodos
        public static int Datos(sucursal[] objPerso)
        {
            for (int i = 0; i < objPerso.Length; i++)
            {
                Console.WriteLine("En la sucursal de {0}: El monto de venta fue de: ${1} Tienen una cantidad de: {2} empleados y {3} clientes compraron este mes", NombreSucursal[i], objPerso[i].MontoDeVenta, objPerso[i].CantDeEmpleados, objPerso[i].CantDeClientes);
            }
            return 0;
        }
        public static int calcPromVenta(sucursal[] objPerso)
        {
            decimal promedio = 0;
            decimal sumatoria = 0;
            for (int i = 0; i < objPerso.Length; i++)
            {
                sumatoria = sumatoria + objPerso[i].MontoDeVenta;
            }
            promedio = sumatoria / objPerso.Length;
            Console.WriteLine("El promedio de venta de todas las sucursales fue de: ${0} este mes", promedio);
            return 0;
        }
        public static int VentasPorEmpleado(sucursal[] objPerso)
        {
            int[] PromPorEmple = new int[objPerso.Length];
            int promedio = 0;
            for (int i = 0; i < objPerso.Length; i++)
            {
                int emple= objPerso[i].CantDeEmpleados;
                int ventas= objPerso[i].CantDeClientes;
                promedio = ventas / emple;
                PromPorEmple[i]= promedio;
                Console.WriteLine("Los empleados de la sucursal de {0} tuvieron un promedio de {1} ventas por empleado", NombreSucursal[i] , PromPorEmple[i]);
            }
            
            return 0;
        }
        public static int VentaMax(sucursal[] objPerso)
        {
            decimal VentaMaxima = 0;
            int n = 0;
            for(int i =0; i< objPerso.Length; i++)
            {
                if (VentaMaxima < objPerso[i].MontoDeVenta)
                {
                    VentaMaxima = objPerso[i].MontoDeVenta;
                    n = objPerso[i].NumeroDeSucursal;
                }
            }

            Console.WriteLine("la venta minima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n], VentaMaxima);
            return 0;

        }
        public static int VentaMin(sucursal[] objSucur)
        {
            decimal VentaMinima = objSucur[0].MontoDeVenta;
            int n=0;
            for (int i = 0; i < objSucur.Length; i++)
            {
                if (VentaMinima > objSucur[i].MontoDeVenta)
                {
                    VentaMinima = objSucur[i].MontoDeVenta;
                    n = objSucur[i].NumeroDeSucursal;
                }

            }
            Console.WriteLine("la venta minima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n] ,VentaMinima);

            return 0;

        }
    }
}
