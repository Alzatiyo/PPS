using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/Recorridos")]
    public class RecorridosController : Controller
    {
        private readonly DataContext _context;
        public RecorridosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.recorridos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var recorrido = await _context.recorridos.FirstOrDefaultAsync(m => m.Id == id);
            if (recorrido == null)
                return NotFound();
            else
                return Ok(recorrido);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Recorrido recorrido)
        {
            _context.Add(recorrido);
            await _context.SaveChangesAsync();
            return Ok(recorrido);
        }
    }
}
