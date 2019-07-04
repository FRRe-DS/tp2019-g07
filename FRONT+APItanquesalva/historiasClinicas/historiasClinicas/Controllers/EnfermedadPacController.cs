using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using historiasClinicas.Models;

namespace historiasClinicas.Controllers
{
    [Route("api/enfermedadPac")]
    [ApiController]
    public class EnfermedadPacController : ControllerBase
    {
        private readonly HcContext _context;

        public EnfermedadPacController(HcContext context)
        {
            _context = context;

            if (_context.EnfermedadPacientes.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.EnfermedadPacientes.Add(new EnfermedadPaciente { Enfermedad = "Item1" });
                _context.SaveChanges();
            }

        }

        // GET: api/enfermedadPac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnfermedadPaciente>>> GetEnfermedadPacientes()
        {
            return await _context.EnfermedadPacientes.ToListAsync();
        }

        // GET: api/ enfermedadPac/(id)
        [HttpGet("{id}")]
        public async Task<ActionResult<EnfermedadPaciente>> GetEnfermedadPaciente(int id)
        {
            var enfermedadPac = await _context.EnfermedadPacientes.FindAsync(id);

            if (enfermedadPac == null)
            {
                return NotFound();
            }

            return enfermedadPac;
        }

        // POST: api/ enfermedadPac
        [HttpPost]
        public async Task<ActionResult<EnfermedadPaciente>> PostEltoAntEvaluar(EnfermedadPaciente item)
        {
            _context.EnfermedadPacientes.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEnfermedadPaciente), new { id = item.IdEnfermedad }, item);
        }

        // PUT: api/ enfermedadPac/(id)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnfermedadPac(int id, EnfermedadPaciente item)
        {
            if (id != item.IdEnfermedad)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/ enfermedadPac/(id)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnfermedadPac(int id)
        {
            var Item = await _context.EnfermedadPacientes.FindAsync(id);

            if (Item == null)
            {
                return NotFound();
            }

            _context.EnfermedadPacientes.Remove(Item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}