

using Xadres.app;
using Xadres.screen;
using Xadres.tabuleiro;
using Xadres.xadres;

try
{

  PartidaDeXadres partida = new PartidaDeXadres();


  TelaTabuleiro.Mostra_tela_do_tabuleiro(partida.Tabuleiro);
  Console.ReadLine();
}
catch (TabuleiroExeption error)
{






  Console.WriteLine(error.Message);

}


