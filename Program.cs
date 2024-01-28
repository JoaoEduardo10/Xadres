

using Xadres.screen;
using Xadres.tabuleiro;
using Xadres.xadres;

try
{
  Tabuleiro tabuleiro = new Tabuleiro(8, 8);


  tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
  tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3));
  tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branco), new Posicao(4, 3));
  tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branco), new Posicao(6, 3));
  tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branco), new Posicao(6, 2));

  TelaTabuleiro.Mostra_tela_do_tabuleiro(tabuleiro);
  Console.ReadLine();
}
catch (TabuleiroExeption error)
{

  Console.WriteLine(error.Message);

}


