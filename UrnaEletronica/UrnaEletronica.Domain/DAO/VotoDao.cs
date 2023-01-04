using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class VotoDao
    {
        public static List<VotoEleitor> ListaDeVotos = new List<VotoEleitor>();
        public void AddVoto(VotoEleitor votoASerCadastrado)
        {
            ListaDeVotos.Add(votoASerCadastrado);
        }
    }
}
