using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class CandidatoDao
    {
        public static List<Candidato> ListaDeCandidatos = new List<Candidato>();

        public void AddCandidato(Candidato candidato)
        {
            ListaDeCandidatos.Add(candidato);
        }
        public Candidato ObterCandidato(string nome)
        {
            Candidato candidato = ListaDeCandidatos.Where(item => item.Nome == nome).First();
            return candidato;
        }
        public Candidato ObterCandidado(int numero)
        {
            Candidato candidato = ListaDeCandidatos.Where(item => item.Numero == numero).First();
            return candidato;
        }

    }
}
