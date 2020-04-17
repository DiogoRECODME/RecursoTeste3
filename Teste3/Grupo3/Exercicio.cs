using System;

namespace Grupo3
{
    public class Exercicio
    {
        public static void OlaPessoa()
        {
            Console.WriteLine("Introduza o seu nome:\t");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Olá {name}");
        }
    }
}
