using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAntHc.Models;

namespace apiAntHc.Controllers
{
    [Route("api/InternacPac")]
    [ApiController]
    public class InternacPacController : ControllerBase
    {
        private readonly Models.HcContext _context;

        public InternacPacController(Models.HcContext context)
        {
            _context = context;

            if (_context.InternacPacientes.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.InternacPacientes.Add(new InternacPaciente { Tratamiento = "Item1" });
                _context.SaveChanges();
            }

        }

        // GET: api/internacPac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InternacPaciente>>> GetInternacPacientes()
        {
            return await _context.InternacPacientes.ToListAsync();
        }

        // GET: api/internacPac/(id)
        [HttpGet("{id}")]
        public async Task<ActionResult<InternacPaciente>> GetInternacPaciente(int id)
        {
            var internacPac = await _context.InternacPacientes.FindAsync(id);

            if (internacPac == null)
            {
                return NotFound();
            }

            return internacPac;
        }

        // POST: api/internacPac
        [HttpPost]
        public async Task<ActionResult<InternacPaciente>> PostEltoAntEvaluar(InternacPaciente item)
        {
            _context.InternacPacientes.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInternacPaciente), new { id = item.Id_internacion }, item);
        }

        // PUT: api/InternacPac/(id)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInternacPac(int id, InternacPaciente item)
        {
            if (id != item.Id_internacion)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/internacPac/(id)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInternacPac(int id)
        {
            var Item = await _context.InternacPacientes.FindAsync(id);

            if (Item == null)
            {
                return NotFound();
            }

            _context.InternacPacientes.Remove(Item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}