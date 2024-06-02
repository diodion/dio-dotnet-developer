using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetAPI.Context;
using DotnetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = contato.Id }, contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null) return NotFound();
            return Ok(contato);
        }

        [HttpGet("PegaNome")]
        public IActionResult GetByName(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
    
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null) return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return Ok(new { message = "Contato Deletado", itemId = id }); 

        }
    }
}