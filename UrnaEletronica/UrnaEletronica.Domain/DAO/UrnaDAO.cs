using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEletronica.Domain.Models;

namespace UrnaEletronica.Domain.DAO
{
    internal class UrnaDAO
    {
        public static List<Candidato> ListaDeCandidatos = new List<Candidato>();
        public static List<Eleitor> Eleitor = new List<Eleitor>();
        public static List<Voto> ListaDeVotos = new List<Voto>();

        public void AddCandidato(Candidato candidato)
        {
            ListaDeCandidatos.Add(candidato);
        }
        public Candidato ObterCandidato(string nome)
        {
            Candidato candidato = ListaDeCandidatos.Where(item => item.Nome == nome).First();
            return candidato;
        }
        public Candidato ObterCandidado(int numero)
        {
            Candidato candidato = ListaDeCandidatos.Where(item => item.Numero == numero).First();
            return candidato;
        }
        public void AddEleitor(Eleitor eleitor)
        {
            Eleitor.Add(eleitor);
        }
        public Eleitor ObterEleitor(string nomeEleitor)
        {
            Eleitor eleitor = Eleitor.Where(item => item.EleitorNome == nomeEleitor).First();
            return eleitor;
        }
        public Eleitor ObterEleitor(int tituloEleitor)
        {
            Eleitor eleitor = Eleitor.Where(item => item.titulo == tituloEleitor).First();
            return eleitor;
        }
        public void AddVoto(Candidato voto)
        {
            ListaDeVotos.Add(voto);
        }
        public List<Voto> ListarVoto()
        {
            return ListaDeVotos;
        }
    }
}
