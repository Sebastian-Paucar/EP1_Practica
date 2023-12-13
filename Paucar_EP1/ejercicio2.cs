using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paucar_EP1
{
     class ejercicio2
    {
        int edad = 0;
        public bool MayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int IngresarEdad()
        {
            do
            {
                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());
                if (edad < 0)
                {
                    Console.WriteLine("La edad ingresada no es válida");
                }
                else
                {
                    break;
                }
            }while (edad < 0);
            return edad;
        }
        static public void ejecucion2()
        {
            ejercicio2 obj = new ejercicio2();
            obj.edad = obj.IngresarEdad();
            if (obj.MayorEdad(obj.edad))
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }
            Console.ReadKey();
        }
        
    }
}
