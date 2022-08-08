using System;
using tabuleiro;
using xadrez;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.colocarPeca(new Cavalo(tab,Cor.Preta), new Posicao(0,1));
            tab.colocarPeca(new Bispo(tab,Cor.Preta), new Posicao(0,2));
            tab.colocarPeca(new Piao(tab, Cor.Preta), new Posicao(1, 0));
            Tela.imprimirtabuleiro(tab);            
        }
    }
}
