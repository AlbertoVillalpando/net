using System;
namespace Session_2
{
    class sintaxis
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("-----Primer Ejercicio-----");
            Console.WriteLine("Suma de dos valores");
            int numero = 10;
            int numero2 = 18;
            int numero3 = numero + numero2;
            Console.WriteLine(numero3);


            Console.WriteLine("-----Segundo Ejercicio-----");
            Console.WriteLine("Ingresa un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un numero");
            if(numero > numero2)
            {
                Console.WriteLine("El número mayor es " + numero);
            }else
            {
                Console.WriteLine("El número mayor es " + numero2);
            }
            

            Console.WriteLine("-----Tercer Ejercicio-----");
            Console.WriteLine("Ingresa el nombre del día de la semana");
            string dia = Console.ReadLine();

            if(dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Es fin de semana!!");
            }else
            {
                Console.WriteLine("No es fin de semana");
            }


            Console.WriteLine("-----Cuarto Ejercicio-----");
            Console.WriteLine("Ingresa precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            if(precio > 0)
            {
                Console.WriteLine("Ingresa el método de pago (efectivo o tarjeta)");
                string metodo = Console.ReadLine();
                if(metodo == "tarjeta") 
                {
                    Console.WriteLine("Ingresa el número de cuenta");
                    string tarjeta = Console.ReadLine();
                    Console.WriteLine("Número de cuenta: " + tarjeta);
                }
            }else
            {
                Console.WriteLine("Precio inválido");
            }
        

            Console.WriteLine("-----Quinto Ejercicio-----");
            Console.WriteLine("Ingresa al número correspondiente al día de la semana (1 - 7)");
            int dia_semana = Convert.ToInt32(Console.ReadLine());

            switch (dia_semana)
            {
                case 1:
                    Console.WriteLine("Hoy es domingo");
                    break;
                case 2:
                    Console.WriteLine("Hoy es lunes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es martes");
                    break;
                case 4:
                    Console.WriteLine("Hoy es miercoles");
                    break;
                case 5:
                    Console.WriteLine("Hoy es jueves");
                    break;
                case 6:
                    Console.WriteLine("Hoy es viernes");
                    break;
                case 7:
                    Console.WriteLine("Hoy es sabado");
                    break;
                    
            }
        }
    }
}