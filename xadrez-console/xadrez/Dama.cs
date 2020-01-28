using tabuleiro;

namespace xadrez {
    class Dama : Peca {

        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValor(Posicao.Linha, Posicao.Coluna - 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha, pos.Coluna - 1);
            }

            pos.DefinirValor(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha, pos.Coluna + 1);
            }

            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha - 1, pos.Coluna);
            }

            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha + 1, pos.Coluna);
            }

            pos.DefinirValor(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha, pos.Coluna - 1);
            }

            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha - 1, pos.Coluna - 1);
            }

            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha - 1, pos.Coluna + 1);
            }

            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha + 1, pos.Coluna + 1);
            }


            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValor(pos.Linha + 1, pos.Coluna - 1);
            }


            return mat;
        }

        public override string ToString() {
            return "D";
        }
    }
}
