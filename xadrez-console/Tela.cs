﻿using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Tela {
        
        public static void ImprimirTabuleiro(Tabuleiro tab) {
            ConsoleColor corOriginal = Console.ForegroundColor;
            for (int i = 0; i < tab.Linhas; i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" {8 - i } ");
                Console.ForegroundColor = corOriginal;
                for (int j = 0; j < tab.Colunas; j++) {
                    ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            char colunaIndice = 'a';
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < tab.Colunas; i++) {
                string retorno = (i == 0) ? $"   {colunaIndice}" : $"  {(char)(colunaIndice + i)}";
                Console.Write(retorno);
            }
            Console.ForegroundColor = corOriginal;
            Console.WriteLine("\n");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkBlue;
            ConsoleColor corOriginal = Console.ForegroundColor;

            for (int i = 0; i < tab.Linhas; i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write($" {8 - i } ");
                for (int j = 0; j < tab.Colunas; j++) {
                    if (posicoesPossiveis[i, j]) {
                        Console.BackgroundColor = fundoAlterado;
                    } 
                    else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            char colunaIndice = 'a';
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < tab.Colunas; i++) {
                string retorno = (i == 0) ? $"   {colunaIndice}" : $"  {(char)(colunaIndice + i)}";
                Console.Write(retorno);
            }
            Console.ForegroundColor = corOriginal;
            Console.WriteLine("\n");
        }



        public static void ImprimirPeca(Peca peca) {

            if (peca == null) {
                Console.Write("-  ");
            }
            else { 
                if (peca.Cor == Cor.Branca) {
                    Console.Write($"{peca}  ");
                }
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{peca}  ");
                    Console.ForegroundColor = aux;
                }
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPartida(PartidaDeXadrez partida) {
            ImprimirTabuleiro(partida.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine($"\n\nTurno: {partida.Turno}");

            if (!partida.Terminada) {
                Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");
                if (partida.Xeque) {
                    Console.WriteLine("XEQUE!");
                }
            }
            else {
                Console.WriteLine("XEQUEMATE");
                Console.WriteLine($"Vencedor: {partida.JogadorAtual}");
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida) {
            Console.WriteLine("Peças capturadas: ");
            
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));

            Console.Write("\nPretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto) {
            Console.Write("[");
            foreach(Peca x in conjunto) {
                Console.Write($"{x} ");
            }
            Console.Write("]");
        }
    }
}
