using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaLocacao.Data;
using BibliotecaLocacao.Models;
using System.Threading.Tasks;
using System.Linq;

namespace BibliotecaLocacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocacoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LocacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Locacao locacao)
        {
            _context.Locacoes.Add(locacao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = locacao.Id }, locacao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var locacao = await _context.Locacoes.Include(l => l.Livro).Include(l => l.Usuario).FirstOrDefaultAsync(l => l.Id == id);
            if (locacao == null)
            {
                return NotFound();
            }
            return Ok(locacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Locacao locacao)
        {
            if (id != locacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(locacao).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Locacoes.Include(l => l.Livro).Include(l => l.Usuario).ToListAsync());
        }
    }
}