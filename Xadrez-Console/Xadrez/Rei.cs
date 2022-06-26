using Xadrez_Console.TabuleiroXadrez;

namespace Xadrez_Console.Xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez Partida;
        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            Partida = partida;
        }

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.QuantidadeMovimentos == 0;
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

            // #jogadaespecial roque
            if(QuantidadeMovimentos == 0 && !Partida.Xeque)
            {
                // #jogadaespecial roque pequeno
                Posicao PosicaoTorre1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(PosicaoTorre1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if(Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }
                
                // #jogadaespecial roque grande
                Posicao PosicaoTorre2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(PosicaoTorre2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

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
