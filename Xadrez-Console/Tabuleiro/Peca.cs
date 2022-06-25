namespace Xadrez_Console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public TabuleiroXadrez Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimentos = 0;
        }
    }
}
