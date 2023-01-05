using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class EleitorDAO
    {
        public static List<Eleitor> ListaDeVotoCotados = new List<Eleitor>();

        public void AddVoto(Eleitor voto)
        {
            ListaDeVotoCotados.Add(voto);
        }
    }
}
