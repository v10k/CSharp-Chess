using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i,j) == null) {
                        Console.Write("- ");
                    } else {
                        Tela.imprimirPeca(tab.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            char colunaIndice = 'a';
            for (int i = 0; i < tab.colunas; i++) {
                string retorno = (i == 0) ? $"  {colunaIndice}" : $" {(char) (colunaIndice + i)}";
                Console.Write(retorno.ToUpper());
            }
            Console.WriteLine("\n");
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.Branca) {
                Console.Write($"{peca} ");
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{peca} ");
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
