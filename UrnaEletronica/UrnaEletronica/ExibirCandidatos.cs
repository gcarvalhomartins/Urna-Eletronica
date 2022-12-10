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
		public static void MenuExibirCandidato()
		{
            string respostaUsuario;
            bool pediuPraSair = false;
            do
            {

                Console.WriteLine("Você está em Vizualiação de Candidato =) ");
                Console.WriteLine("A - Para Vizualizar os Candidatos ");
                Console.WriteLine("B - Para adicionar Candidatos ");

                respostaUsuario = Console.ReadLine();

                switch (respostaUsuario.ToLower())
                {
                    case "a":
                        Exibir();
                        break;
                    case "b":
                        CandidatosFixos();
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
        public static void CandidatosFixos()
        {
            
            Candidato candidatos1 = new Candidato();
            candidatos1.Id = 2323;
            candidatos1.Nome = "José";
            candidatos1.Numero = 13;
            candidatos1.Partido = "PVV";
            candidatos1.CargoDisputado = "Presidencia";

            Candidato candidatos2 = new Candidato();
            candidatos2.Id = 2323;
            candidatos2.Nome = "José";
            candidatos2.Numero = 13;
            candidatos2.Partido = "PVV";
            candidatos2.CargoDisputado = "Presidencia";

            Candidato candidatos3 = new Candidato();
            candidatos3.Id = 2323;
            candidatos3.Nome = "José";
            candidatos3.Numero = 13;
            candidatos3.Partido = "PVV";
            candidatos3.CargoDisputado = "Governador";

            Candidato candidatos4 = new Candidato();
            candidatos4.Id = 2323;
            candidatos4.Nome = "José";
            candidatos4.Numero = 13;
            candidatos4.Partido = "PVV";
            candidatos4.CargoDisputado = "Governador";

            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos1);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos2);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos3);
            _candidadoExtrasServices.AdicionarVisitanteNaLista(candidatos4);

        }
	}
}
