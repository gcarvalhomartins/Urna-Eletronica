using System;
using System.Collections.Generic;

namespace UrnaEletronica.CLI
{

	internal class MenuCandidato
	{
		public static void ExibirCandidato()
		{
            string respostaUsuario;
            bool pediuPraSair = false;
            do
            {

                Console.WriteLine("Você está em Vizualiação de Candidato =) ");
                Console.WriteLine("A - Para Vizualizar os Candidatos a Presidencia ");
                Console.WriteLine("A - Para Vizualizar os Candidatos a Governador ");

                respostaUsuario = Console.ReadLine();

                switch (respostaUsuario.ToLower())
                {
                    case "a":
                        Console.WriteLine();
                        break;
                    case "b":
                        Console.WriteLine();
                        break;
                    case "c":
                        Console.WriteLine();
                        break;
                    default:
                        pediuPraSair = true;
                        break;
                }

            } while (!pediuPraSair);
        }
	}
}
