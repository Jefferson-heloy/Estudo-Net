using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiIgreja.AcessoDados.Entidades;

namespace WebApiIgreja.AcessoDados
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly MyWebAppContext _myWebAppContext;

        public FilmeRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;   
        }

        public List<Filme> ListarFilmes()
        {
           return  _myWebAppContext.Filmes.ToList();
        }

        public Filme ObterFilmePorId(int id)
        {
            return _myWebAppContext.Filmes.FirstOrDefault(p => p.Id == id);
        }
        public List<Filme> ObterFilmePorDescricao(string genero)
        {
            return _myWebAppContext.Filmes.Where(p => p.Genero.ToUpper().Contains(genero)).ToList();
        }
        public List<Filme> ObterFilmePorNome(string nome)
        {
            return _myWebAppContext.Filmes.Where(p => p.Nome.ToUpper().Contains(nome)).ToList();
        }

        public List<Filme> ObterFilmePorClassificacao(double classificacao)
        {
            return _myWebAppContext.Filmes.Where(p => p.Classificacao >= classificacao).ToList();
        }

        public void Salvar(Filme filme)
        {
            _myWebAppContext.Filmes.Add(filme);
            _myWebAppContext.SaveChanges();
        }

       
    }
}
