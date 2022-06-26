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

            Posicao novaPosicao = new(0, 0);
            Posicao posicaoOriginal = Posicao;

            #region MovimentosPossiveis para o REI
            //acima
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // nordeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna + 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // direita
            novaPosicao.DefinirValores(posicaoOriginal.Linha, posicaoOriginal.Coluna + 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // sudeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha + 1, posicaoOriginal.Coluna + 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // abaixo
            novaPosicao.DefinirValores(posicaoOriginal.Linha + 1, posicaoOriginal.Coluna);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // sudoeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha + 1, posicaoOriginal.Coluna - 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // esquerda
            novaPosicao.DefinirValores(posicaoOriginal.Linha, posicaoOriginal.Coluna - 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
            // noroeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna - 1);
            if (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
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
