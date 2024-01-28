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

    public Peca Peca(Posicao posicao)
    {
      return pecas[posicao.Linha, posicao.Coluna];
    }

    public bool exitePeca(Posicao posicao)
    {
      ValidarPosicao(posicao);
      return Peca(posicao) != null;
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
      if (exitePeca(posicao))
      {
        throw new TabuleiroExeption("Já existe uma peca na posição " + posicao.ToString());
      }

      pecas[posicao.Linha, posicao.Coluna] = peca;
      peca.posicao = posicao;
    }


    public Peca retirarPeca(Posicao posicao)
    {
      if (Peca(posicao) == null)
      {
        return null;
      }


      Peca aux = Peca(posicao);
      aux.posicao = null;
      pecas[posicao.Linha, posicao.Coluna] = null;
      return aux;
    }

    public bool PosicaoValida(Posicao posicao)
    {
      if (posicao.Coluna < 0 || posicao.Coluna >= colunas || posicao.Linha < 0 || posicao.Linha >= linhas)
      {
        return false;
      }

      return true;
    }

    public void ValidarPosicao(Posicao posicao)
    {
      if (!PosicaoValida(posicao))
      {
        throw new TabuleiroExeption("Posição invalida!");
      }
    }
  }
}
