using System;

namespace Labo2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.SetWindowSize (140, 44);
			Jogo realizar = new Jogo (0);


			realizar.letreiro ();
			Console.WriteLine ("\n\n");
			Console.WriteLine ("Adivinhe é um jogo para crianças exercitarem sua leitura e o seu conhecimento por objetos");
			Console.WriteLine ("O jogo começa apresentando uma tela com uma imagem e duas opções do que pode ser o objeto, sendo que só uma é a resposta certa");
			Console.WriteLine (" ");
			Console.WriteLine ("Como Jogar:");
			Console.WriteLine ("Se você acha que a resposta certa é a primeira opção aperte 1");
			Console.WriteLine ("Se você acha que a resposta certa é a segunda opção aperte 2");
			Console.WriteLine (" ");
			Console.WriteLine ("Aperte qualquer tecla para começar");
			Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine ();
			realizar.ComecarJogo();

		}
	}
}
