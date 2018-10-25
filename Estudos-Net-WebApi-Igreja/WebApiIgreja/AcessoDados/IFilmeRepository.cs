using System.Collections.Generic;
using WebApiIgreja.AcessoDados.Entidades;

namespace WebApiIgreja.AcessoDados
{
    public interface IFilmeRepository
    {
        List<Filme> ListarFilmes();
        Filme ObterFilmePorId(int id);
        List<Filme> ObterFilmePorDescricao(string genero);
        List<Filme> ObterFilmePorNome(string nome);
        List<Filme> ObterFilmePorClassificacao(double classificacao);
        void Salvar(Filme filme);
    }
}