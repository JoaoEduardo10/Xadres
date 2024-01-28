

using Xadres.app;
using Xadres.screen;
using Xadres.tabuleiro;

try
{

  PartidaDeXadres partida = new PartidaDeXadres();

  while (!partida.Terminada)
  {
    Console.Clear();
    TelaTabuleiro.Mostra_tela_do_tabuleiro(partida.Tabuleiro);

    Console.Write("Origem: ");
    Posicao origem = TelaTabuleiro.LerPosicaoxadres().ToPosicao();
    Console.Write("Destino: ");
    Posicao destino = TelaTabuleiro.LerPosicaoxadres().ToPosicao();


    partida.execultarMovimento(origem, destino);
  }

  Console.ReadLine();
}
catch (TabuleiroExeption error)
{






  Console.WriteLine(error.Message);

}


