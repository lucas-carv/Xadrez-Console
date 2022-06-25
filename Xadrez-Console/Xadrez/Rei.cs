using Xadrez_Console.TabuleiroXadrez;

namespace Xadrez_Console.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new(0,0);

            #region MovimentosPossiveis para o REI
            //acima
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // acima
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // nordeste
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // direita
            posicao.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // sudeste
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // abaixo
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // sudoeste
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // esquerda
            posicao.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
            // noroeste
            posicao.DefinirValores(posicao.Linha -1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;
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
            return "R";
        }

    }
}
