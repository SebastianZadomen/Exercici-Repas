namespace MyLibrary
{
    public class Math
    {
        public static string ConvertTime (int seg) 
            {
            string result;
            seg = seg / 60;
            int cont= 0;

            if (seg == 60)
            { 
                cont = 1;
                seg = seg - 60;
           
            }
            return result=$"{cont} hora, {seg} segundos,";
            }
    }
}
