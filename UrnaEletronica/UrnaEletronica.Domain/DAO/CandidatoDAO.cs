using System;
using System.Collections.Generic;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    public class CandidatosDao
    {
        public static List<Candidato> ListaDeCandidatos = new List<Candidato>();


        public void AddCandidato(Candidato candidato)
        {
            ListaDeCandidatos.Add(candidato);
        }
    }


}
