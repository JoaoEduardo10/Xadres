namespace Xadres.tabuleiro
{
  public class Peca
  {
    public Posicao? posicao { get; set; }
    public Cor cor { get; protected set; }

    public int Quantidade_de_Movimentos { get; protected set; }

    public Tabuleiro tabuleiro { get; protected set; }


    public Peca(Cor cor, Tabuleiro tabuleiro)
    {

      posicao = null;

      this.cor = cor;

      this.tabuleiro = tabuleiro;

      Quantidade_de_Movimentos = 0;
    }

    public Peca(Tabuleiro tabuleiro, Cor cor)
    {
      this.tabuleiro = tabuleiro;
      this.cor = cor;
    }

    public void IncrementeQuantidadeDeMovimentos()
    {
      Quantidade_de_Movimentos++;
    }
  }
}
