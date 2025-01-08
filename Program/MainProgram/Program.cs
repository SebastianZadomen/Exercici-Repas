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

           /* Exercici2 int bas = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());
            string result = MyLibrary.Math.CalculateAreaTriangule(bas, altura);
            Console.WriteLine($"El area es : {result}");*/

            Console.WriteLine("Introduce un numero");
            double celsius = Convert.ToInt32(Console.ReadLine());
            string result = MyLibrary.Math.ConversionTemperatura(celsius);

            Console.WriteLine(result);

        }
    }
}



