using System;
using System.Collections.Generic;
using UrnaEletronica.Domain.DAO;

namespace UrnaEletronica.CLI
{

	internal class ExibirListaDeCandidatos
	{   
        static CandidatosDao _candidatosDAO = new CandidatosDao(); 
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
                        Console.WriteLine(CandidatosDao.ListaDeCandidatos);
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
        public void ExibirCandidatos()
        {
            
        }
	}
}
