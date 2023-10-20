using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/Liquidacion")]
    public class LiquidacionController : Controller
    {
        private readonly DataContext _context;
        public LiquidacionController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.liquidacions.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var liquidacion = await _context.liquidacions.FirstOrDefaultAsync(m => m.Id == id);
            if (liquidacion == null)
                return NotFound();
            else
                return Ok(liquidacion);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Liquidacion liquidacion)
        {
            _context.Add(liquidacion);
            await _context.SaveChangesAsync();
            return Ok(liquidacion);
        }
    }
}
