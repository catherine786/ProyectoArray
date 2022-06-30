using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] ObjPersona = new Persona[4];
            string[] Nombres = new string[4] { "Cathy", "Axel", "Facu", "Ale" };
            int[] Numeros = new int[4] {1,2,3,4};
            int[] Edades = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}  {1}", (i+1), Nombres[i]);
            }


            Console.WriteLine("Cuantas edades va a ingresar?");
            int cantEdades = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantEdades; i++)
            {
                Console.WriteLine("De que alumno quiere ingresar la edad?");
                int numAlumno = (Convert.ToInt32(Console.ReadLine()) - 1);
                ObjPersona[numAlumno] = new Persona();
                Console.WriteLine("Ingrese la edad del alumno: ");
                Edades[numAlumno] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i =0; i < 4; i++)
            {
                Console.WriteLine("Nombre: {0}, edad: {1}", Nombres[i], Edades[i]);
            }

        }   
    }
    public class Persona
    {
        public Persona() { }

        public  string[] Nombres = new string[4] { "Cathy", "Axel", "Facu", "Ale" };
        public int[] Edades = new int[4];
    }
}
