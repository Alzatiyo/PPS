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
    [Route("api/Lineas")]
    public class LineasController : Controller
    {
        private readonly DataContext _context;
        public LineasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Lineas.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var linea = await _context.Lineas.FirstOrDefaultAsync(m => m.Id == id);
            if (linea == null)
                return NotFound();
            else
                return Ok(linea);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Linea linea)
        {
            _context.Add(linea);
            await _context.SaveChangesAsync();
            return Ok(linea);
        }
        [HttpPut]
        public async Task<ActionResult> Put(Linea linea)
        {
            _context.Update(linea);
            await _context.SaveChangesAsync();
            return Ok(linea);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var linea = await _context.Lineas.Where(m => m.Id == id).ExecuteDeleteAsync();

            if (linea == 0)
                return NotFound();
            else
                return NoContent();
        }
    }
}
