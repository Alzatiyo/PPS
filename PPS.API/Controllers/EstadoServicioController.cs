using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [ApiController]
    [Route("api/EstadoServicio")]
    public class EstadoServicioController : Controller
    {
        private readonly DataContext _context;
        public EstadoServicioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.estadoServicios.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var estadoServicio = await _context.estadoServicios.FirstOrDefaultAsync(m => m.Id == id);
            if (estadoServicio == null)
                return NotFound();
            else
                return Ok(estadoServicio);
        }

        [HttpPost]
        public async Task<ActionResult> Post(EstadoServicio estadoServicio)
        {
            _context.Add(estadoServicio);
            await _context.SaveChangesAsync();
            return Ok(estadoServicio);
        }
    }
}
