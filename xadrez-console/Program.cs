﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada) {
                    try { 
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    catch (IndexOutOfRangeException e) {
                        Console.WriteLine("Insira um comando válido");
                        Console.ReadLine();
                    }
                    catch (FormatException e) {
                        Console.WriteLine("Insira um comando válido");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);

            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
          
        }
    }
}
