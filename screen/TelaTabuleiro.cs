using Xadres.tabuleiro;
using Xadres.xadres;

namespace Xadres.screen
{
  public class TelaTabuleiro
  {
    public static void Mostra_tela_do_tabuleiro(Tabuleiro tabuleiro)

    {
      for (int i = 0; i < tabuleiro.linhas; i++)
      {
        Console.Write(8 - i + " ");
        for (int j = 0; j < tabuleiro.colunas; j++)
        {



          if (tabuleiro.Peca(i, j) == null)
          {
            Console.Write("- ");
            continue;
          }

          ImprimirPeca(tabuleiro.Peca(i, j));


        }

        Console.WriteLine();
      }

      Console.WriteLine("  a b c d e f g h");
    }

    public static PosicaoXadres LerPosicaoxadres()
    {
      string s = Console.ReadLine();

      char coluna = s[0];

      int linha = int.Parse(s[1] + "");

      return new PosicaoXadres(coluna, linha);
    }
    public static void ImprimirPeca(Peca peca)
    {
      if (peca.cor == Cor.Branco)
      {
        Console.Write(peca + " ");
      }
      else
      {
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(peca + " ");
        Console.ForegroundColor = aux;
      }
    }

  }
}
