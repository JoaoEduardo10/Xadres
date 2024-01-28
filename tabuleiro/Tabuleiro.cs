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
      this.pecas = new Peca[linhas, colunas];
    }
  }
}
