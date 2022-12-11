using System;
using System.Collections.Generic;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.CLI
{

	internal class ExibirCandidatos
	{
        
        static CandidatoExtraServices _candidadoExtrasServices = new CandidatoExtraServices();

        static CandidatosFixosServices _candidatosFixosServices = new CandidatosFixosServices();
		public static void MenuExibirCandidato()
		{   
            string respostaUsuario;
            bool pediuPraSair = false;
            do
            {
             

                Console.WriteLine("Você está em Vizualiação de Candidato =) ");
                Console.WriteLine("A - Para Vizualizar os Candidatos ");
                Console.WriteLine("B - Para adicionar Candidatos Fixos ");

                respostaUsuario = Console.ReadLine();

                switch (respostaUsuario.ToLower())
                {
                    case "a":
                        Exibir();
                        break;
                    case "b":
                        CandidatosFixosServices.AdicionarCandidatosFixos();
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
            

            foreach ( var candidato in CandidatosDao.ListaDeCandidatos)
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
