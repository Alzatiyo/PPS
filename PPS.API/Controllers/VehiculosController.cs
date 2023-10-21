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
    [Route("api/Vehiculos")]
    public class VehiculosController : Controller
    {
        private readonly DataContext _context;
        public VehiculosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Vehiculos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(m => m.Id == id);
            if (vehiculo == null)
                return NotFound();
            else
                return Ok(vehiculo);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vehiculo vehiculo)
        {
            _context.Add(vehiculo);
            await _context.SaveChangesAsync();
            return Ok(vehiculo);
        }
        [HttpPut]
        public async Task<ActionResult> Put(Vehiculo vehiculo)
        {
            _context.Update(vehiculo);
            await _context.SaveChangesAsync();
            return Ok(vehiculo);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vehiculo = await _context.Vehiculos.Where(m => m.Id == id).ExecuteDeleteAsync();

            if (vehiculo == 0)
                return NotFound();
            else
                return NoContent();
        }
    }
}
