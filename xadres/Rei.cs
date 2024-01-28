using Xadres.tabuleiro;

namespace Xadres.xadres
{
  public class Rei : Peca
  {
    public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {

    }


    public override string ToString()
    {
      return "R";
    }
  }
}
