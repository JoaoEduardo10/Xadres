using Xadres.tabuleiro;
using Xadres.xadres;

namespace Xadres.app
{
  public class PartidaDeXadres
  {
    public Tabuleiro Tabuleiro { get; private set; }
    private int Turno;
    private Cor JogadorAtual;
    public bool Terminada { get; private set; }


    public PartidaDeXadres()
    {
      Tabuleiro = new Tabuleiro(8, 8);
      Turno = 1;
      JogadorAtual = Cor.Branco;
      ColocarPecas();
    }


    public void execultarMovimento(Posicao origiem, Posicao destino)
    {
      Peca p = Tabuleiro.retirarPeca(origiem);

      p.IncrementeQuantidadeDeMovimentos();

      Peca pecacapturada = Tabuleiro.retirarPeca(destino);

      Tabuleiro.ColocarPeca(p, destino);
    }


    private void ColocarPecas()
    {
      Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branco), new PosicaoXadres('c', 1).ToPosicao());
      Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branco), new PosicaoXadres('c', 2).ToPosicao());
    }
  }
}
