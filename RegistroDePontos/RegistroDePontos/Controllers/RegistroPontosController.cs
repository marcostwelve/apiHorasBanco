using Microsoft.AspNetCore.Mvc;
using RegistroDePontos.DataContext;
using RegistroDePontos.Models;

namespace RegistroDePontos.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegistroPontosController : ControllerBase
    {
        private readonly RegistroPontoContext _context;
        public RegistroPontosController(RegistroPontoContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult TodosRegistros() 
        {
            var registros = _context.Registros.ToList();

            return Ok(registros);
        }

        [HttpGet("/ObterPorNome")]
        public IActionResult RegistroPorNome(string nome) 
        {
            var usuario = _context.Registros.Where(u => u.Nome.Contains(nome));
            if(usuario != null)
            {
                return Ok(usuario);
            }

            return BadRequest();
        }

        [HttpPost("/EntradaExpediente")]
        public IActionResult EntradaExpediente(RegistroPonto registro)
        {
            var data = DateTime.Now;
            var DataFormatada = string.Format("{0:HH:mm}", data);
            registro.EntradaExpediente = DataFormatada;

            _context.Add(registro);
            _context.SaveChanges();
            return Ok(registro);
        }

        [HttpPost("/EntradaAlmoco")]
        public IActionResult EntradaAlmoco( int id)
        {
            var usuario = _context.Registros.Find(id);
            var data = DateTime.Now;
            var dataFormatada = string.Format("{0:HH:mm}", data);

            if (usuario == null)
            {
                return NotFound();
            }

            usuario.EntradaAlmoco = dataFormatada;
            _context.Update(usuario);
            _context.SaveChanges();
            

            return Ok();
        }

        [HttpPost("/VoltaAlmoco")]
        public IActionResult VoltaAlmoco(int id)
        {
            var usuario = _context.Registros.Find(id);
            var data = DateTime.Now;
            var dataFormatada = string.Format("{0:HH:mm}", data);

            if(usuario == null)
            {
                return NotFound();
            }

            usuario.VoltaAlmoco = dataFormatada;
            _context.Update(usuario);
            _context.SaveChanges();
            

            return Ok();
        }

        [HttpPost("/SaidaExpediente")]
        public IActionResult SaidaExpediente(int id)
        {
            var usuario = _context.Registros.Find(id);
            var data = DateTime.Now;
            var dataFormatada = string.Format("{0:HH:mm}", data);
            if(usuario == null)
            {
                return NotFound();
            }

            usuario.SaidaExpediente = dataFormatada;
            _context.Update(usuario);
            _context.SaveChanges();
            
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletarRegistro(int id)
        {
            var usuario = _context.Registros.Find(id);
            if(usuario == null)
            {
                return NotFound();
            }

            _context.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
