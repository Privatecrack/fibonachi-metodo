using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //serie fibonachi: 0, 1, 1, 2 3 5 8 13 21 34 55 89.....

            Console.WriteLine("Introduzca el valor hasta calcular la serie");
            string valor = Console.ReadLine();
            int numero = -1;


            numero=validarNumero(valor); 
            int a = 0;
            int b = 1;

            string mostrarPantalla = string.Empty;
            mostrarPantalla ="0";

           mostrarPantalla += calcular(a,b,numero);

            Console.WriteLine(mostrarPantalla);
            Console.ReadLine();
        }
        
        private static int validarNumero(string valor) {
            int numero = -1;
            try
            {
                numero = Convert.ToInt32(valor);
            }
            catch (Exception) {
                Console.WriteLine("debe introducir un numero:");
                Console.ReadLine();
            }
            return numero;
        }

        private static string calcular(int a, int b, int numero)
        {
            string mostrar=string.Empty;
            int resultado = 0;
            while (resultado <= numero)
            {
                resultado = a + b;
                a = b;
                b = resultado;
                mostrar += " " + resultado;
            }
            return mostrar;
        }
    }
}
