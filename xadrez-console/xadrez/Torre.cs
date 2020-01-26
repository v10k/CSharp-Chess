using tabuleiro;

namespace xadrez {
    class Torre : Peca {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValor(Posicao.Linha - 1, Posicao.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
            pos.Linha = pos.Linha - 1;
            }

            pos.DefinirValor(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
            pos.Linha = pos.Linha + 1;
            }

            pos.DefinirValor(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
            pos.Coluna = pos.Coluna + 1;
            }

            pos.DefinirValor(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }

        public override string ToString() {
            return "T";
        }
    }
}
