using System.Data;

namespace Xadres.tabuleiro
{
  public class Tabuleiro
  {
    private Peca[,] pecas;

    public int colunas { get; set; }

    public int linhas { get; set; }

    public Tabuleiro(int linhas, int colunas)
    {
      this.colunas = colunas;
      this.linhas = linhas;
      pecas = new Peca[linhas, colunas];
    }


    public Peca Peca(int linha, int coluna)
    {
      return pecas[linha, coluna];
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
      pecas[posicao.Linha, posicao.Coluna] = peca;
      peca.posicao = posicao;
    }
  }
}
