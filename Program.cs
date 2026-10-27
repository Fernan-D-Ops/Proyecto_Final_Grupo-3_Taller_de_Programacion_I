using System;

namespace ProjectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bucle para ejecutar el codigo al menos una vez y controlar que sea el usuario quien decida cuando dejarlo

             Console.WriteLine(@"
                ==================================================
                |Bienvenido a la tabla de multiplicar interactiva|
                ==================================================
                "); // Con @ nos permite hacer multilineas, muy util para disenos

            do
            {
                try // Con Try "Probamos" la respuesta del usuario para evitar que el usuario no rompa el programa con una respuesta no valida.
                {
                    Console.Write("De que numero desea saber su tabla de multiplicar? "); //.Write Para hacer la pregunta y capturar la respuesta en la misma linea
                    string resNumero = Console.ReadLine(); 
                    int numero = int.Parse(resNumero);
                    for (int i = 1; i <= 12; i++)
                    {
                        long calculo = numero * i;
                        Console.WriteLine($"{numero} x {i} = {calculo}");  
                    }
                }

                catch (FormatException) // En caso de una respuesta inadecuada o erronea le avisamos al usuario y lo devolvemos a la pregunta
                {
                    Console.WriteLine("Porfavor ingrese un numero valido");
                    continue;
                }

                Console.Write("Desea calcular otra tabla? (Si) / (No) "); // Condicion para que el usuario sea quien decide salir del codigo
                string resBucle = Console.ReadLine().ToLower();
                if (resBucle == "s" || resBucle == "si" || resBucle == "yes" || resBucle == "y") // Multiples manera de contestar para que sea mas amigable al user
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Gracias por utilizar nuestro programa, Bye!");
                    break;
                }

            } while (true);
            
            
        }
    }
}        