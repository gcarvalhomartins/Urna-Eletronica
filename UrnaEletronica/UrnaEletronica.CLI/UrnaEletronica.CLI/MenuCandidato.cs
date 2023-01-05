using System;
using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Domain.Models;
using UrnaEletronica.Domain.Services;

namespace UrnaEletronica.CLI
{
    internal class MenuCandidato
    {
        private static UrnaServices _urnaServices = new UrnaServices();

        static void ExibirCandidatos()
        {
            List<Candidato> candidato = _urnaServices.ListarCandidatos();

            foreach (var item in candidato)
            {
                MenuVoto.ExibirCandidato(item);
            }
        }
    }
}
