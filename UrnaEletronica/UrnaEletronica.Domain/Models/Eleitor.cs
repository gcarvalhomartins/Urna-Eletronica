using System;
using System.Collections.Generic;
using System.Text;

namespace UrnaEletronica.Domain.Models
{
    public class Eleitor : Candidato
    {
        public int VotoCotado { get; set; }
    }
}
