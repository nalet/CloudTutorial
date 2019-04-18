using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_new_app.SQLite;

namespace my_new_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjektController : Controller
    {
        private readonly MyAppContext _context;

        public ObjektController(MyAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objekt>>> GetObjekts()
        {
            return await _context.Objekt.Include(objekt => objekt.besitzer).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Objekt>> GetObjekt(int id)
        {
            var objekt = await _context.Objekt.FindAsync(id);
            if (objekt == null) return NotFound();

            return objekt;
        }

        [HttpPost]
        public async Task<ActionResult<Objekt>> PostObjekt(Objekt item)
        {
            if(item.besitzer != null) item.besitzer = _context.Person.Find(item.besitzer.PersonId);
            _context.Objekt.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetObjekt), new { id = item.ObjektId }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjekt(int id, Objekt item)
        {
            if (id != item.ObjektId) return BadRequest();

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjekt(int id)
        {
            var Objekt = await _context.Objekt.FindAsync(id);
            if (Objekt == null) return NotFound();

            _context.Objekt.Remove(Objekt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
