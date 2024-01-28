using Xadres.tabuleiro;

namespace Xadres.screen
{
  public class TelaTabuleiro
  {
    public static void Mostra_tela_do_tabuleiro(Tabuleiro tabuleiro)
    {
      for (int i = 0; i < tabuleiro.linhas; i++)
      {

        for (int j = 0; j < tabuleiro.colunas; j++)
        {
          if (tabuleiro.Peca(i, j) == null)
          {
            Console.Write("- ");
            continue;
          }

          Console.Write(tabuleiro.Peca(i, j) + " ");


        }

        Console.WriteLine();
      }
    }
  }
}
