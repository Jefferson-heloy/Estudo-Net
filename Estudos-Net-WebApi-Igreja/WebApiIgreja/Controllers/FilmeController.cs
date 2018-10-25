using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiIgreja.AcessoDados;
using WebApiIgreja.AcessoDados.Entidades;

namespace WebApiIgreja.Controllers
{
    [Route("api/[Controller]/")]
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_filmeRepository.ListarFilmes());
            }
            catch (Exception ex)
            {
                return BadRequest("Erro:" + ex.Message);
            }

        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var filme = _filmeRepository.ObterFilmePorId(id);
                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("genero={genero}")]
        public IActionResult Get(string genero)
        {
            try
            {
               
                return Ok(_filmeRepository.ObterFilmePorDescricao(genero));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("nome={nome}")]
        public IActionResult GetNome(string nome)
        {
            try
            {

                return Ok(_filmeRepository.ObterFilmePorNome(nome));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpGet("classificacao={classificacao}")]
        public IActionResult Get(double classificacao)
        {
            try
            {

                return Ok(_filmeRepository.ObterFilmePorClassificacao(classificacao));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }



        [HttpPost]
        public IActionResult Post([FromBody]Filme filme)
        {
            try
            {
                _filmeRepository.Salvar(filme);
                return Created("/api/filme",filme);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

    }
}