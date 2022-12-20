using System;
using System.ComponentModel;
using System.Linq.Expressions;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.DAO;
using UrnaEletronica.Domain.Services;
using System.Runtime.CompilerServices;

namespace UrnaEletronica.CLI
{
    public class MenuExtras
    { 
        static CandidatoExtraServices _candidatoExtraServices = new CandidatoExtraServices();
        public static void CadastrarVisitante()
        {
            Console.WriteLine("Olá Você está no extras , Aqui você pode se tornar um candidato =) ");
            
            Console.WriteLine("Digite seu código de Identificação ");
            string id = Console.ReadLine();

            Console.WriteLine("Digite seu nome");
            string nomeVisitante= Console.ReadLine();

            Console.WriteLine("Digite seu Número Para Votação ");
            string numero = Console.ReadLine();

            Console.WriteLine("Digite seu Cargo Disputado ");
            string cargoDisputado = Console.ReadLine();

            Console.WriteLine("Digite seu Partido");
            string Partido= Console.ReadLine();

            int idVisitante = int.Parse(id);
            int numeroVisitante = int.Parse(numero);

            Candidato candidatoASerCadastrado = new Candidato();
            candidatoASerCadastrado.Id = idVisitante;
            candidatoASerCadastrado.Nome = nomeVisitante;
            candidatoASerCadastrado.Numero = numeroVisitante;
            candidatoASerCadastrado.Partido = Partido;
            candidatoASerCadastrado.CargoDisputado = cargoDisputado;

            _candidatoExtraServices.AdicionarCandidatoNaLista(candidatoASerCadastrado);
            
        }
    }
}
