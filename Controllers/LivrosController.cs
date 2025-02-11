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
    public class LivrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = livro.Id }, livro);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var livro = await _context.Livros.Include(l => l.Autor).FirstOrDefaultAsync(l => l.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Livro livro)
        {
            if (id != livro.Id)
            {
                return BadRequest();
            }

            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Livros.Include(l => l.Autor).ToListAsync());
        }
    }
}