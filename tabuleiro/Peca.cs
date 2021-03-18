using tabuleiro;

namespace tabuleiro
{
     abstract class Peca
    {

        public Posicao posicao { get; protected set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.QteMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
