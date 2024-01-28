namespace Xadres.tabuleiro
{
  public class Peca
  {
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }

    public int Quantidade_de_Movimentos { get; protected set; }

    public Tabuleiro tabuleiro { get; protected set; }


    public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
    {

      this.posicao = posicao;

      this.cor = cor;

      this.tabuleiro = tabuleiro;

      this.Quantidade_de_Movimentos = 0;
    }
  }
}
