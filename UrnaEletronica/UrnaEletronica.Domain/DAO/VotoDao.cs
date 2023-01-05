using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class VotoDao
    {
        public static List<Voto> ListaDeVotoEleito = new List<Voto>();

        public void AddVoto(Voto voto)
        {
            ListaDeVotoEleito.Add(voto);
        }
    }
}
