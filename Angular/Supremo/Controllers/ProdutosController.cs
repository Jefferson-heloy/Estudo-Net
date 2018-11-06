using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supremo.Models;

namespace Supremo.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.ListarProdutos());
            }
            catch (Exception ex) { return BadRequest("Erro" + ex.Message); } 
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var produto = _produtoRepository.ObterProdutoPorId(id);
                return Ok(produto);
            }catch(Exception ex) { return BadRequest($"Erro: {ex.Message}"); }
        }
        }
}