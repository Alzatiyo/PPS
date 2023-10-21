using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/TipoCarrocerias")]
    public class TipoCarroceriasController : Controller
    {
        private readonly DataContext _context;
        public TipoCarroceriasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TipoCarrocerias.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var tipoCarroceria = await _context.TipoCarrocerias.FirstOrDefaultAsync(m => m.Id == id);
            if (tipoCarroceria == null)
                return NotFound();
            else
                return Ok(tipoCarroceria);
        }

        [HttpPost]
        public async Task<ActionResult> Post(TipoCarroceria tipoCarroceria)
        {
            _context.Add(tipoCarroceria);
            await _context.SaveChangesAsync();
            return Ok(tipoCarroceria);
        }
    }
}
