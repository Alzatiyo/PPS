using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/marcas")]
    public class marcasController : Controller
    {
        private readonly DataContext _context;
        public marcasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Marcas.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var marca = await _context.Marcas.FirstOrDefaultAsync(m => m.Id == id);
            if (marca == null)
                return NotFound();
            else
                return Ok(marca);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Marca marca)
        {
            _context.Add(marca);
            await _context.SaveChangesAsync();
            return Ok(marca);
        }
    }
}
