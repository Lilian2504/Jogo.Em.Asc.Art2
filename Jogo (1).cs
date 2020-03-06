using System;

namespace Labo2
{
	public class Jogo
	{
		int numero, contador=0;

		public Jogo (int numero)
		{
			this.numero = numero;
		}

		public void letreiro(){

			Console.SetCursorPosition (38, 5);Console.WriteLine (" _______  ______   ______   __   __  ______   __    _  __   __  _______ ");
			Console.SetCursorPosition (38, 6);Console.WriteLine ("|   _   ||      | |      | |  | |  ||      | |  |  | ||  | |  ||       | ");
			Console.SetCursorPosition (38, 7);Console.WriteLine ("|  |_|  ||  _    ||___   | |  |_|  ||___   | |   |_| ||  |_|  ||    ___| ");
			Console.SetCursorPosition (38, 8);Console.WriteLine ("|       || | |   |  __|  | |       |  __|  | |       ||       ||   |___  ");
			Console.SetCursorPosition (38, 9);Console.WriteLine ("|       || |_|   | |_____| |       | |_____| |  _    ||       ||    ___| ");
			Console.SetCursorPosition (38, 10);Console.WriteLine ("|   _   ||       |   __     |     |    __    | | |   ||   _   ||   |___  ");
			Console.SetCursorPosition (38, 11);Console.WriteLine ("|__| |__||______|   |__|     |___|    |__|   |_|  |__||__| |__||_______| ");


		}


		public void ComecarJogo(){
			letreiro ();
			Console.SetCursorPosition (55, 15);Console.WriteLine ("       O que é isso?");
			Console.SetCursorPosition (55, 16);Console.WriteLine ();
			Console.SetCursorPosition (55, 17);Console.WriteLine ("       #############      ");  
			Console.SetCursorPosition (55, 18);Console.WriteLine ("       ##         ##     "); 
			Console.SetCursorPosition (55, 19);Console.WriteLine ("       #  ~~   ~~  #     "); 
			Console.SetCursorPosition (55, 20);Console.WriteLine ("       #  ()   ()  #      "); 
			Console.SetCursorPosition (55, 21);Console.WriteLine ("       (     ^     )     "); 
			Console.SetCursorPosition (55, 22);Console.WriteLine ("        |         |       "); 
			Console.SetCursorPosition (55, 23);Console.WriteLine ("        |  {===}  |      ");
			Console.SetCursorPosition (55, 24);Console.WriteLine ("                 /       ");
			Console.SetCursorPosition (55, 25);Console.WriteLine ("       /  -----         ");
			Console.SetCursorPosition (55, 26);Console.WriteLine ("    ---  |%  /%|  ---    "); 
			Console.SetCursorPosition (55, 27);Console.WriteLine ("   /     |%%%%%|         ");
			Console.SetCursorPosition (55, 28);Console.WriteLine ("        |%/  %|           ");

			Console.WriteLine ();

			Console.SetCursorPosition (56, 32);
			string[] pessoa = {"Homem","Mulher"};
			for (int i = 0; i < pessoa.Length; i++) 
				Console.Write ("   {0}\t", pessoa [i]);

			Console.Write ("\n");


			numero = int.Parse (Console.ReadLine ());


			if (numero == 1) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.SetCursorPosition (90, 23);Console.WriteLine (" CERTO ");
				contador++;
			}

			else if(numero==2){
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition (90, 23);Console.WriteLine (" ERRADO ");
			}
			Console.WriteLine ("\n\n");
			Console.ReadLine ();
			Console.Clear ();

			Console.ForegroundColor = ConsoleColor.White;
			letreiro ();
			Console.WriteLine ();
			Console.SetCursorPosition (60, 15);Console.WriteLine ("      O que é isso?");
			Console.SetCursorPosition (60, 16);Console.WriteLine ();
			Console.SetCursorPosition (60, 17);Console.WriteLine ("           |_|_|  ");
			Console.SetCursorPosition (60, 18);Console.WriteLine ("            |@|   ");
			Console.SetCursorPosition (60, 19);Console.WriteLine ("            |@|  ");
			Console.SetCursorPosition (60, 20);Console.WriteLine ("           /@@@\\ ");
			Console.SetCursorPosition (60, 21);Console.WriteLine ();
			Console.SetCursorPosition (62, 23);
			string[] torre = {"Bispo","Torre"};
			for(int i = 0; i < torre.Length; i++)
				Console.Write("   {0}\t", torre[i]);
			Console.Write("\n");

			numero = int.Parse (Console.ReadLine ());


			if (numero == 1) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition (90, 18);Console.WriteLine (" ERRADO ");
			}

			else if(numero==2){
				Console.ForegroundColor = ConsoleColor.Green;
				Console.SetCursorPosition (90, 18);Console.WriteLine (" CERTO ");
				contador++;
			}
			Console.WriteLine ("\n\n");
			Console.ReadLine ();
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.White;
			letreiro ();
			Console.SetCursorPosition (59, 15);Console.WriteLine ("       O que é isso?");
			Console.SetCursorPosition (60, 16);Console.WriteLine ();
			Console.SetCursorPosition (60, 17);Console.WriteLine ("           www ");
			Console.SetCursorPosition (60, 18);Console.WriteLine ("           )@(  ");
			Console.SetCursorPosition (60, 19);Console.WriteLine ("           |@|  ");
			Console.SetCursorPosition (60, 20);Console.WriteLine ("           |@|  ");
			Console.SetCursorPosition (60, 21);Console.WriteLine ("          /@@@\\  ");
			Console.SetCursorPosition (62, 23);
			string[] real = {"Rainha","Rei"};
			for(int i = 0; i < real.Length; i++)
				Console.Write("   {0}\t", real[i]);
			Console.Write("\n");

			numero = int.Parse (Console.ReadLine ());


			if (numero == 1) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition (90, 18);Console.WriteLine (" ERRADO ");
			}

			else if(numero==2){
				Console.ForegroundColor = ConsoleColor.Green;
				Console.SetCursorPosition (90, 18);Console.WriteLine (" CERTO ");
				contador++;
			}
			Console.WriteLine ("\n\n");
			Console.ReadLine ();
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.White;
			letreiro ();
			Console.SetCursorPosition (63, 14);Console.WriteLine ("       O que é isso?");
			Console.SetCursorPosition (57, 16);Console.WriteLine ("           (‘‘‘,3‘‘‘==\"*¦‘‘‘              ");
			Console.SetCursorPosition (57, 17);Console.WriteLine ("        \"3‘‘‘‘‘‘‘‘‘‘‘‘‘‘‘,‘\"\"%3           ");
			Console.SetCursorPosition (57, 18);Console.WriteLine ("     .‘%A5‘‘‘‘‘\"\"\",,,,\"\"‘‘\"\"\"#55J.        ");
			Console.SetCursorPosition (57, 19);Console.WriteLine ("    \"$A5#A\"5‘\"\"\"\"\"\"\"\"\"\"\"\"\"=@\"@@@#3\"       ");
			Console.SetCursorPosition (57, 21);Console.WriteLine ("  \"\"¦5##\"\"\",,\"@,A@@@@@@,,\",\"\"@#\"##5=\"     ");
			Console.SetCursorPosition (57, 22);Console.WriteLine (" \"\"!\"#\"\"\"\"\"*\"%Ð*ÐÐÐÐÐÐÐÐAÐ,!\"\"\"\"\"\"#5A\"    ");
			Console.SetCursorPosition (57, 23);Console.WriteLine (" \"\"%\"\"\"\"\",\"\",,,*ÐWWWWW(Ð,,,,\"\"(,,\"\"\"\"\"    ");
			Console.SetCursorPosition (57, 24);Console.WriteLine ("\"$\"\",\"\"\"\"\"\"\",,,,*MMMMW*,,,,,,,,,,,\"*\"A$   ");
			Console.SetCursorPosition (57, 25);Console.WriteLine ("J\"\"\"\"\"\",5,,,\",,,,M*M*M***,,,,,,,@,,\",,%   ");
			Console.SetCursorPosition (57, 26);Console.WriteLine ("3A\",,,,#,5A,,,(*********,,,,\",,##,,,,,,   ");
			Console.SetCursorPosition (57,27);Console.WriteLine ("3A\",,,,5##5,,*¦*********,*,,,,J!,#,,,,%   ");
			Console.SetCursorPosition (57, 28);Console.WriteLine ("CA,,,,,,,,,,*****M!M*M***,*,,,,,,,,,,A%   ");
			Console.SetCursorPosition (57, 29);Console.WriteLine (" $=,,*,,,,,*,***!MMMMW!********,,,,,*,    ");
			Console.SetCursorPosition (57, 30);Console.WriteLine (" ,,,,,,,,,*****Ð!MMMWW!W*****,***,,@A,    ");
			Console.SetCursorPosition (57, 31);Console.WriteLine ("  ,,#!=******Ð!WWWWWWWWW!W*(****A@@,,     ");
			Console.SetCursorPosition (57, 32);Console.WriteLine ("    ,!@@Ð5*=**@WÐÐ@%@ÐÐÐÐ***Ð@@@@@5       ");
			Console.SetCursorPosition (57, 33);Console.WriteLine ("     ‘3A5#*#**!*!**!*!*!****@##5A,        ");
			Console.SetCursorPosition (57, 34);Console.WriteLine ("        3*¦*******!!!!!!*!*****           ");
			Console.SetCursorPosition (57, 35);Console.WriteLine ("           **!**!!@¦!!#!!***              ");
			Console.SetCursorPosition (65, 38);
			string[] bola = {"Bola","Carro"};
			for(int i = 0; i < bola.Length; i++)
				Console.Write("   {0}\t", bola[i]);
			Console.Write("\n");

			numero = int.Parse (Console.ReadLine ());


			if (numero == 1) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.SetCursorPosition (105, 26);Console.WriteLine (" CERTO ");
				contador++;
			}

			else if(numero==2){
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition (105, 26);Console.WriteLine (" ERRADO ");
			}
			Console.ReadLine ();
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.White;
			letreiro ();
			Console.SetCursorPosition (59, 15);Console.WriteLine ("       O que é isso?");
			Console.SetCursorPosition (50, 17);Console.WriteLine ("                     J#####J                       ");
			Console.SetCursorPosition (50, 18);Console.WriteLine ("             AJJJ$WWWW7,J,=ÐWWW3JJJ5               ");
			Console.SetCursorPosition (50, 19);Console.WriteLine ("            JC,,\"\"\"\",,JC==J,,,,,,,,CJ              ");
			Console.SetCursorPosition (50, 20);Console.WriteLine ("           ,J,\"\"\"\",,,,\"\",,,,,,,,,,,,J,             ");
			Console.SetCursorPosition (50, 21);Console.WriteLine ("           JW\"¦(7777\"\",,,,,,,777777,WJ             ");
			Console.SetCursorPosition (50, 22);Console.WriteLine ("           J\"\"7777¦¦CJJJJJJJ777777¦\"\"J             ");
			Console.SetCursorPosition (50, 23);Console.WriteLine ("      3$%W#J,,77¦¦777JJJJJJJ77%53¦¦\"\"J#W333        ");
			Console.SetCursorPosition (50, 24);Console.WriteLine ("         *######@######################            ");
			Console.SetCursorPosition (50, 25);Console.WriteLine ("      =(CCCCJJJJJJJJJJJJJJJJJJJJJJJJJCCCC(=        ");
			Console.SetCursorPosition (50, 26);Console.WriteLine ("    ‘C7Ð=(M7CJ333333333333333333333JC7W((W7C       ");
			Console.SetCursorPosition (50, 27);Console.WriteLine ("    J7Ð¦(=¦WCJCJ#################JJJCW¦((¦@7C      ");
			Console.SetCursorPosition (50, 28);Console.WriteLine ("    JCC3CC37CJ((AAAAAAAAAAAAAAAAA¦($CC37737CJ      ");
			Console.SetCursorPosition (50, 29);Console.WriteLine ("    J=JJ,,JJJ3=¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦=%JJJ,,JJJC      ");
			Console.SetCursorPosition (50, 30);Console.WriteLine ("    ¦¦¦¦¦*******************************¦¦¦¦¦      ");
			Console.SetCursorPosition (50, 31);Console.WriteLine ("    !¦¦¦¦***********‘‘7‘‘\"$‘‘***********¦¦¦¦¦      ");
			Console.SetCursorPosition (50, 32);Console.WriteLine ("      MMMMM         ‘‘‘‘‘‘‘‘‘         MMMMM        ");
			Console.SetCursorPosition (50, 33);Console.WriteLine ("      MMMMM‘\"*¦=7CCCCCCCCCCCCCCC7=¦**‘MMMMM        ");
		
			Console.SetCursorPosition (63, 38);
			string[] carro = {"Carro","Moto"};
			for(int i = 0; i < carro.Length; i++)
				Console.Write("   {0}\t", carro[i]);
			Console.Write("\n");

			numero = int.Parse (Console.ReadLine ());


			if (numero == 1) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.SetCursorPosition (105, 26);Console.WriteLine (" CERTO ");
				contador++;
			}

			else if(numero==2){
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition (105, 26);Console.WriteLine (" ERRADO ");
			}


			Console.ReadLine ();
			Console.Clear ();

			Console.ForegroundColor = ConsoleColor.White;
			letreiro ();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("\n\n");
			Console.SetCursorPosition (55, 15);Console.WriteLine ("VOCÊ ACERTOU O NOME DE " + contador+ " IMAGENS");

		}
	}
}

