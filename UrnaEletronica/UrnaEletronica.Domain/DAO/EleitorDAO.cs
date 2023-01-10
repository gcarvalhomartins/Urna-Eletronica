using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class EleitorDAO
    {
        public static List<Eleitor> Eleitor = new List<Eleitor>();

        public void AddEleitor(Eleitor eleitor)
        {
            Eleitor.Add(eleitor);
        }
        public Eleitor ObterEleitor(string nomeEleitor)
        {
            Eleitor eleitor = Eleitor.Where(item => item.Nome == nomeEleitor).First();
            return eleitor;
        }
        public Eleitor ObterEleitor(int tituloEleitor)
        {
            Eleitor eleitor = Eleitor.Where(item => item.titulo == tituloEleitor).First();
            return eleitor;
        }
    }
}
