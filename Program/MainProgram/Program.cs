using MyLibrary;
using System;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Console.Write("Ingresa el número de segundos: ");
             int userseg = Convert.ToInt32(Console.ReadLine());

             string result = MyLibrary.Math.ConvertTime(userseg);

             Console.WriteLine(result);*/

            int bas = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());
            string result = MyLibrary.Math.CalculateAreaTriangule(bas, altura);
            Console.WriteLine($"El area es : {result}");
        }
    }
}

        /*int bas = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());

            int result;
            if (bas > 0 && altura > 0)
            {
                result = bas * altura;
                result = result / 2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Algunos de sus numeros es negativo");
            }
        }
    }
    }*/


