using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paucar_EP1
{
    class ejercicio1
    {
        double numero1=0, numero2=0, resultado = 0;

        public double Sumar(double numero1, double numero2)
        {
            resultado = numero1 + numero2;
            return resultado;
        }

        static public void ejecucion1()
        {
            ejercicio1 obj = new ejercicio1();
            Console.WriteLine("Ingrese el primer número");
            obj.numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            obj.numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es: " + obj.Sumar(obj.numero1, obj.numero2));
            Console.ReadKey();  
        }

    }
}
