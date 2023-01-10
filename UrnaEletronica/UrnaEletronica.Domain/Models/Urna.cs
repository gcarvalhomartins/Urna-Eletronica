using System;
using System.Collections.Generic;
using System.Text;

namespace UrnaEletronica.Domain.Models
{
    public class Urna : Eleitor
    {
        public List<Candidato> ListaDeCandidatos { get; set; }
        public List<Eleitor> ListaDeEleitores { get; set; }
        public List<Voto> ListaVotos { get; set;}
        public bool ExisteCandidato { get; set; }
        public bool VotoJaContado { get; set; }

    }
}
