using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/transitos")]
    public class transitosController : Controller
    {
        private readonly DataContext _context;
        public transitosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Transitos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var transito = await _context.Transitos.FirstOrDefaultAsync(m=>m.Id == id);
            if (transito == null)
                return NotFound();
            else
                return Ok(transito);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Transito transito)
        {
            _context.Add(transito);
            await _context.SaveChangesAsync();
            return Ok(transito);
        }
    }
}
