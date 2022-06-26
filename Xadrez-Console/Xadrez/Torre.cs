using Xadrez_Console.TabuleiroXadrez;

namespace Xadrez_Console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao novaPosicao = new(0, 0);
            Posicao posicaoOriginal = Posicao;

            #region MovimentosPossiveis para a TORRE
            // acima
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != this.Cor)
                {
                    break;
                }
                novaPosicao.Linha = novaPosicao.Linha - 1;
            }

            // abaixo
            novaPosicao.DefinirValores(posicaoOriginal.Linha + 1, posicaoOriginal.Coluna);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != this.Cor)
                {
                    break;
                }
                novaPosicao.Linha = novaPosicao.Linha + 1;
            }

            // direita
            novaPosicao.DefinirValores(posicaoOriginal.Linha, posicaoOriginal.Coluna + 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != this.Cor)
                {
                    break;
                }
                novaPosicao.Coluna = novaPosicao.Coluna + 1;
            }

            // esquerda
            novaPosicao.DefinirValores(posicaoOriginal.Linha, posicaoOriginal.Coluna - 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != this.Cor)
                {
                    break;
                }
                novaPosicao.Coluna = novaPosicao.Coluna - 1;
            }

            #endregion

            return matriz;
        }
        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);

            return peca == null || peca.Cor != this.Cor;
        }

        public override string ToString()
        {
            return "T";
        }

    }
}
