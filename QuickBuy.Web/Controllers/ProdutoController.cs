﻿using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.ObterTodos());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                _produtoRepository.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
