using Xadres.tabuleiro;

namespace Xadres.xadres
{
  public class Torre : Peca
  {
    public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {

    }


    public override string ToString()
    {
      return "T";
    }
  }
}
