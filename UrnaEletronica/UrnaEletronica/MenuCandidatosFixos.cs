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
                        AdicionarCandidatosFixos();
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


            foreach (var candidato in CandidatosDao.ListaDeCandidatos)
            {
                Console.WriteLine("Id do Candidato : " + candidato.Id);
                Console.WriteLine("Nome do Candidato : " + candidato.Nome);
                Console.WriteLine("Número do Candidato : " + candidato.Numero);
                Console.WriteLine("Partido do Candiato :" + candidato.Partido);
                Console.WriteLine("Cargo Disputado :" + candidato.CargoDisputado);
            }
        }
        public static void AdicionarCandidatosFixos()
        {

            Candidato candidatos1 = new Candidato();
            candidatos1.Id = 2323;
            candidatos1.Nome = "José";
            candidatos1.Numero = 13;
            candidatos1.Partido = "PVV";
            candidatos1.CargoDisputado = "Presidencia";

            Candidato candidatos2 = new Candidato();
            candidatos2.Id = 4675;
            candidatos2.Nome = "Paulo";
            candidatos2.Numero = 13;
            candidatos2.Partido = "KDI";
            candidatos2.CargoDisputado = "Presidencia";

            Candidato candidatos3 = new Candidato();
            candidatos3.Id = 9090;
            candidatos3.Nome = "Marquinhos";
            candidatos3.Numero = 13;
            candidatos3.Partido = "KEJ";
            candidatos3.CargoDisputado = "Governador";

            Candidato candidatos4 = new Candidato();
            candidatos4.Id = 5648;
            candidatos4.Nome = "Yoham";
            candidatos4.Numero = 13;
            candidatos4.Partido = "SWE";
            candidatos4.CargoDisputado = "Governador";

            VerificacaoCandidatosFixos(candidatos1);
            VerificacaoCandidatosFixos(candidatos2);
            VerificacaoCandidatosFixos(candidatos3);
            VerificacaoCandidatosFixos(candidatos4);

        }
        static void VerificacaoCandidatosFixos(Candidato candidatoASerCadastrado)
        {
            bool jaExiste = _candidatosFixosServices.JaExisteCadastroCandidato(candidatoASerCadastrado.Id);
            if (jaExiste)
            {
                Console.WriteLine("Candidatos Já Cadastrados");
            }
            else
            {
                _candidadoExtrasServices.AdicionarCandidatoNaLista(candidatoASerCadastrado);
            }
        }
    }
}
