using MyLibrary;
using System;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*string result;
            int userseg = Convert.ToInt32(Console.ReadLine());
            int seg = userseg;
            int cont = 0;
            int min = 0;

  
                if (seg >= 60)
                {
                    cont++;
                    seg = seg - 60;
                    min = seg;

                }
            if (seg <= 60)
            {
                seg = seg / 100;
                seg = seg * 10;
                   
            }
                 
           Console.WriteLine($"{cont} hora, {min} minutos,{seg}segundos");*/

            int bas = int.Parse(Console.ReadLine());
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
    }


