using System;
using System.Collections.Generic;
using UrnaEletronica.Domain.DAO;

namespace UrnaEletronica.CLI
{

	internal class ExibirCandidatos
	{   
        static CandidatosDao _candidatosDAO = new CandidatosDao();

        static MenuExtras _menuExtras = new MenuExtras();
		public static void MenuExibirCandidato()
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
                        Exibir();
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
        public static void Exibir()
        {
            foreach( var candidato in CandidatosDao.ListaDeCandidatos)
            {
                Console.WriteLine("Id do Candidato : " + candidato.Id);
                Console.WriteLine("Nome do Candidato : " + candidato.Nome);
                Console.WriteLine("Número do Candidato : " + candidato.Numero);
                Console.WriteLine("Partido do Candiato :" + candidato.Partido);
                Console.WriteLine("Cargo Disputado :" + candidato.CargoDisputado);
            }
        }
	}
}
