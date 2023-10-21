using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPS.API.Data;
using PPS.Shared.Entities;

namespace PPS.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/Servicio")]
    public class ServicioController : Controller
    {
        private readonly DataContext _context;
        public ServicioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Servicios.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var servicio = await _context.Servicios.FirstOrDefaultAsync(m => m.Id == id);
            if (servicio == null)
                return NotFound();
            else
                return Ok(servicio);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Servicio servicio)
        {
            _context.Add(servicio);
            await _context.SaveChangesAsync();
            return Ok(servicio);
        }
        [HttpPut]
        public async Task<ActionResult> Put(Servicio servicio)
        {
            _context.Update(servicio);
            await _context.SaveChangesAsync();
            return Ok(servicio);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var servicio = await _context.Servicios.Where(m => m.Id == id).ExecuteDeleteAsync();

            if (servicio == 0)
                return NotFound();
            else
                return NoContent();
        }
    }
}
