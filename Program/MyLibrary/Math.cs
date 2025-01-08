namespace MyLibrary
{
    public class Math
    {
        public static string ConvertTime (int userseg) 
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
        public static string ConversionTemperatura(double celsius)
        {
                double fahrenheit = 0;
                fahrenheit = celsius * 1.8;
                fahrenheit = fahrenheit + 32;

                int redondeo = Convert.ToInt32(fahrenheit);

                return $"{celsius}ºC convertido a Fahrenheit es {redondeo}ºF ";
            }

        }
    }
    

