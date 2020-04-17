using System;

namespace GrupoIII
{
    public class Exercicio03
    {
        public static void UpdateHighScore(int score, string scoreName, ref int currentHighScore, ref string currentHighScoreName)
        {
            if (score > currentHighScore)
            {
                currentHighScore = score;
                currentHighScoreName = scoreName;
            }
        }

        public static void TabelaGalo(int lines, int columns)
        {
            int c = 0;
            for(int i = 0; i < lines; i++)
            {
                for(int x = 0; x < columns; x++)
                {
                    if((c % 2) == 0)
                        Console.Write("X ");
                    else
                        Console.Write("O ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        public static int SomaImpares(int num1, int num2)
        {
            if ((num1 == num2) && (num2 % 2 != 0))
                return num1;
            else if (num1 == num2)
                return num1 - num2;
            else if ((num1 % 2) != 0)
                return num1 + SomaImpares((num1 + 1), num2);
            else
                return SomaImpares((num1 + 1), num2);
        }

    }
}
