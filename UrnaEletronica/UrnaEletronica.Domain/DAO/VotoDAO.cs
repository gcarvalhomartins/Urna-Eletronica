using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class VotoDAO
    {
        public static List<Voto> Voto = new List<Voto>();

        public void AddVoto(Voto voto)
        {
            Voto.Add(voto);
        }
    }
}
