using System;

namespace GrupoIII
{
    public class Exercicio02
    {
        public static int WeirdSum(int num1,int num2)
        {
            if (((num1 + num2) % 2) == 0)
                return (num1 + num2) * 3;
            return (num1 + num2) * 2;
        }

        public static int Cube(int num)
        {
            return (num * num * num);
        }

        public static void Multiplo(int num1, int num2)
        {
            if ((num1 % num2) == 0)
                Console.WriteLine($"{num1} é múltiplo de {num2}");
            else
                Console.WriteLine($"{num1} não é múltiplo de {num2}");
        }

        public static void Tabuada(int num)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }

        public static void Segundos(int h, int m, int s)
        {
            Console.WriteLine($"{h} horas, {m} minutos e {s} segundos é equivalente a {(((h*3600) + (m*60)) + s)} segundos");
        }
    }
}
