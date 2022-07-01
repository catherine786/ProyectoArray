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

            Console.WriteLine("Cuantas sucursales va a ingresar?");
            int cantSuc = Convert.ToInt32(Console.ReadLine());
            int[] sucIn = new int[cantSuc];

            for (int i = 0; i < cantSuc; i++)
            {
                Console.WriteLine("De que Sucursal va a ingresar datos?");
                int numSuc = (Convert.ToInt32(Console.ReadLine()) - 1);
                
                sucIn[i] = numSuc;
                objSucursal[numSuc] = new sucursal();
                Console.WriteLine("Esta por ingresar los datos de la sucursal de: {0}", NombreSucursal[numSuc]);
                Console.WriteLine("Ingresar el monto de venta del mes");
                objSucursal[numSuc].MontoDeVenta = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de empleados: ");
                objSucursal[numSuc].CantDeEmpleados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad de clientes que compraron algo este mes: ");
                objSucursal[numSuc].CantDeClientes = Convert.ToInt32(Console.ReadLine());

                objSucursal[numSuc].NumeroDeSucursal = numSuc;
            }


            // salida de informacion 
            // calculo del promedio de la edad
            Calcular.Datos(sucIn, NombreSucursal, objSucursal);
            Calcular.calcPromVenta(sucIn, objSucursal);
            Calcular.calcPromEmple(sucIn, objSucursal);
            Calcular.VentasPorEmpleado(sucIn, NombreSucursal, objSucursal);
            Calcular.VentaMax(sucIn, NombreSucursal, objSucursal);
            Calcular.VentaMin(sucIn, NombreSucursal, objSucursal);

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
        public static int Datos(int[] sucIn,string[] NombreSucursal, sucursal[] objSuc)
        {
            for (int i = 0; i < sucIn.Length; i++)
            {
                Console.WriteLine("{0} El monto de venta fue de: ${1} Tienen una cantidad de: {2} empleados y {3} clientes compraron este mes",NombreSucursal[sucIn[i]], objSuc[sucIn[i]].MontoDeVenta, objSuc[sucIn[i]].CantDeEmpleados, objSuc[sucIn[i]].CantDeClientes);
            }
            return 0;
        }

        public static int calcPromEmple(int[] sucIn, sucursal[] objSuc)
        {
            int sumatoria = 0;
            for (int i = 0; i < sucIn.Length; i++)
            {
                sumatoria = sumatoria + objSuc[sucIn[i]].CantDeEmpleados;
            }
            int promedio = sumatoria / sucIn.Length;
            Console.WriteLine("La suma de emmpleados es de: {0} \n El promedio de Empleados de todas las sucursales fue de: {1}", sumatoria, promedio);
            return 0;
        }


        public static int calcPromVenta(int[] sucIn, sucursal[] objSuc)
        {
            decimal promedio = 0;
            decimal sumatoria = 0;
            for (int i = 0; i < sucIn.Length; i++)
            {
                sumatoria = sumatoria + objSuc[sucIn[i]].MontoDeVenta;
            }
            promedio = sumatoria / sucIn.Length;
            Console.WriteLine("La suma de venta es de: {0} \n El promedio de venta de todas las sucursales fue de: ${1:N2} este mes", sumatoria, promedio);
            return 0;
        }

        public static int VentasPorEmpleado(int[] sucIn, string[] NombreSucursal, sucursal[] objSuc)
        {
            int suma1 = 0;
            decimal suma2 = 0;
            for (int i = 0; i < sucIn.Length; i++)
            {
                suma1 = suma1 + objSuc[sucIn[i]].CantDeEmpleados;
                suma2 = suma2 + objSuc[sucIn[i]].MontoDeVenta;


            }
            decimal promedio = suma2 / suma1;
            Console.WriteLine("El promedio de venta por empleado es de: {0:N2}", promedio);
            
            return 0;
        }
        public static int VentaMax(int[] sucIn, string[] NombreSucursal, sucursal[] objSuc)
        {
            decimal VentaMaxima = objSuc[sucIn[0]].MontoDeVenta;
            int n = objSuc[sucIn[0]].NumeroDeSucursal;
            for (int i = 0; i < sucIn.Length; i++)
            {
                if (VentaMaxima < objSuc[sucIn[i]].MontoDeVenta)
                {
                    VentaMaxima = objSuc[sucIn[i]].MontoDeVenta;
                    n = objSuc[sucIn[i]].NumeroDeSucursal;

                }
            }
            Console.WriteLine("la venta maxima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n], VentaMaxima);


            return 0;

        }
        public static int VentaMin(int[] sucIn, string[] NombreSucursal, sucursal[] objSuc)
        {
            decimal VentaMinima = objSuc[sucIn[0]].MontoDeVenta;
            int n = objSuc[sucIn[0]].NumeroDeSucursal;
            for (int i = 0; i < sucIn.Length; i++)
            {
                if (VentaMinima > objSuc[sucIn[i]].MontoDeVenta)
                {
                    VentaMinima = objSuc[sucIn[i]].MontoDeVenta;
                    n = objSuc[sucIn[i]].NumeroDeSucursal;

                }

            }
            Console.WriteLine("la venta minima le pertenese a la sucursal de {0} y fue de: ${1}", NombreSucursal[n], VentaMinima);
            return 0;

        }
    }
}
