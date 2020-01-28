﻿using tabuleiro;

namespace xadrez {
    class Peao : Peca {

        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }

        private bool ExisteInimigo(Posicao pos) {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool livre (Posicao pos) {
            return Tab.Peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca) {
                pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos) && QteMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else {
                pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos) && QteMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        }

        public override string ToString() {
            return "P";
        }
    }
}
