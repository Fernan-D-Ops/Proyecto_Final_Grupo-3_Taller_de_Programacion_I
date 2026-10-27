using System;

namespace ProjectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int test =0;
            // Bucle para ejecutar el codigo al menos una vez y controlar que sea el usuario quien decida cuando dejarlo
            do
            {
                Console.WriteLine(@"
                ==================================================
                |Bienvenido a la tabla de multiplicar interactiva|
                ==================================================
                "); // Con @ nos permite hacer multilineas, muy util para disenos

                Console.Write("De que numero desea saber su tabla de multiplicar? "); //.Write Para hacer la pregunta y capturar la respuesta en la misma linea
                string respuesta = Console.ReadLine(); 
                int numero = int.Parse(respuesta);

                for (int i = 1; i <= 12; i++)
                {
                  int calculo = numero * i;
                  Console.WriteLine($"{numero} x {i} = {calculo}");  
                }

                test++;   
            } while (test <=0);
        }
    }
}        