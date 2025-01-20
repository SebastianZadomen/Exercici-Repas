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

            /*Exercici3 Console.WriteLine("Introduce un numero");
            double celsius = Convert.ToInt32(Console.ReadLine());
            string result = MyLibrary.Math.ConversionTemperaturaFahrenheit(celsius);

            Console.WriteLine(result);*/

            /*Console.WriteLine("Introduce un numero");
            double celsius = Convert.ToInt32(Console.ReadLine());
            string result = MyLibrary.Math.ConversionTemperaturaKelvin(celsius);

            Console.WriteLine(result);
            */

            double userNum = Convert.ToDouble(Console.ReadLine());
            double propina = MyLibrary.Math.CalculPropina(userNum);
            Console.WriteLine(propina);
            Console.ReadKey();

        }
    }
}



