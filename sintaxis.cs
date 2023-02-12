using System;
namespace Session_2
{
    class sintaxis
    {
        public static void Main(string[] args)
        {
            int numero = 0;

            do
            {
                Console.Write(numero);
                numero++;
                if(numero == 9)
                {
                    return;
                }
            } while (numero < 10);
            
            int numero2 = 0;
            while (numero < 10)
            {
                Console.WriteLine(numero2);
                numero2++;
            }
        }
    }
}
//agregar > nuevo elemento > clase de c#