using System.Diagnostics.Contracts;

namespace MyLibrary
{
    public class Math
    {
        public static string ConvertTime(int userseg)
        {

            int horas = userseg / 3600;
            int minutos = (userseg % 3600) / 60;
            int segundos = userseg % 60;

            return $"{horas} horas, {minutos} minutos, {segundos} segundos";
        }
        public static string CalculateAreaTriangule(int bas, int altura)
        {
            int result;
            if (bas > 0 && altura > 0)
            {
                result = bas * altura;
                result = result / 2;
                return result.ToString();
            }
            else
            {
                return "Algunos de sus numeros es negativo";
            }
        }
        public static string ConversionTemperaturaFahrenheit(double celsius)
        {
            double fahrenheit = 0;
            fahrenheit = celsius * 1.8;
            fahrenheit = fahrenheit + 32;

            int redondeo = Convert.ToInt32(fahrenheit);

            return $"{celsius}ºC convertido a Fahrenheit es {redondeo}ºF ";
        }
        public static string ConversionTemperaturaKelvin(double celsius)
        {
            double kelvin = 0;
            kelvin = celsius + 273.15;

            return $"{celsius}ºC convertido a Kelvin es {kelvin}ºF ";
        }
        public static double ConvertirKelvinAFahrenheit(double kelvin)
        {
            double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
            return fahrenheit;
        }
        public static double CalcularDescompte(double precioInicial, double precioDescompte)
        {
            if (precioInicial <= 0)
            {
                throw new ArgumentException("El precio incial debe ser mayor a 0");
            }

            double descompte = ((precioInicial - precioDescompte) / precioInicial) * 100;
            return descompte;
        }
        public static string ConversionDecimalAHexadecimal(int userNum)
        {
            string total = ""; 

            while (userNum > 0) 
            {
                int residuo = userNum % 16;
                string hexadecimal = "";

                if (residuo >= 10)
                {
                    hexadecimal = ((char)('A' + (residuo - 10))).ToString(); 
                }
                else
                {
                    hexadecimal = residuo.ToString();
                }

                total = hexadecimal + total; 
                userNum /= 16; 
            }

            return total; 
        }
        public static bool CodePostal(string codePostal)
        {
          
            int numero;

            if (int.TryParse(codePostal, out numero))
            {
                if (numero >= 0 && numero <= 99999 && codePostal.Length == 5)
                {
                    return true; 
                }
            }
            return false;
        }
    }

}
 

    

