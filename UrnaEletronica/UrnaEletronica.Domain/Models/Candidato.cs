using System;
using System.Collections.Generic;
using System.Text;

namespace UrnaEletronica.Domain.Models
{
    public class Candidato
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string CargoDisputado { get; set; }
        public string Partido { get; set; }
        public List<Voto> Voto { get; set; }

        public List<Eleitor> Eleitor { get; set; }

    }
}
