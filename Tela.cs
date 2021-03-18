using tabuleiro;
using System;

namespace ChessProject
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j)==null) {
                        Console.WriteLine("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
