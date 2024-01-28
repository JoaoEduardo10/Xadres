

using Xadres.screen;
using Xadres.tabuleiro;
using Xadres.xadres;

Tabuleiro tabuleiro = new Tabuleiro(8, 8);


tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3));
tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));

TelaTabuleiro.Mostra_tela_do_tabuleiro(tabuleiro);

Console.ReadLine();
