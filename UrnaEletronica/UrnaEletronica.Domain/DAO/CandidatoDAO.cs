using System;
using System.Collections.Generic;
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
    }
}
