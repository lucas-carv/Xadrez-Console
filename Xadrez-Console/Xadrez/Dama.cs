using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.TabuleiroXadrez;

namespace Xadrez_Console.Xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "D";
        }
        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao novaPosicao = new Posicao(0, 0);
            Posicao posicaoOriginal = Posicao;

            //noroeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna - 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != Cor)
                {
                    break;
                }
                novaPosicao.DefinirValores(novaPosicao.Linha - 1, novaPosicao.Coluna - 1);
            }
            //nordeste
            novaPosicao.DefinirValores(posicaoOriginal.Linha - 1, posicaoOriginal.Coluna + 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != Cor)
                {
                    break;
                }
                novaPosicao.DefinirValores(novaPosicao.Linha - 1, novaPosicao.Coluna + 1);
            }



            // SE
            novaPosicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != Cor)
                {
                    break;
                }
                novaPosicao.DefinirValores(novaPosicao.Linha + 1, novaPosicao.Coluna + 1);
            }

            // SO
            novaPosicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(novaPosicao) && PodeMover(novaPosicao))
            {
                matriz[novaPosicao.Linha, novaPosicao.Coluna] = true;
                if (Tabuleiro.Peca(novaPosicao) != null && Tabuleiro.Peca(novaPosicao).Cor != Cor)
                {
                    break;
                }
                novaPosicao.DefinirValores(novaPosicao.Linha + 1, novaPosicao.Coluna - 1);
            }


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
            return matriz;
        }
    }
}
