using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Models;

namespace PasswordManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordManagersController : ControllerBase
    {
        private readonly PasswordManagerDevContext _context;

        public PasswordManagersController(PasswordManagerDevContext context)
        {
            _context = context;
        }

        // GET: api/PasswordManagers
        [HttpGet]
        public IEnumerable<PasswordManager> GetPasswordManager()
        {
            return _context.PasswordManager;
        }

        // GET: api/PasswordManagers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPasswordManager([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var passwordManager = await _context.PasswordManager.FindAsync(id);

            if (passwordManager == null)
            {
                return NotFound();
            }

            return Ok(passwordManager);
        }

        // PUT: api/PasswordManagers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasswordManager([FromRoute] int id, [FromBody] PasswordManager passwordManager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != passwordManager.PasswordId)
            {
                return BadRequest();
            }

            _context.Entry(passwordManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasswordManagerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PasswordManagers
        [HttpPost]
        public async Task<IActionResult> PostPasswordManager([FromBody] PasswordManager passwordManager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PasswordManager.Add(passwordManager);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasswordManager", new { id = passwordManager.PasswordId }, passwordManager);
        }

        // DELETE: api/PasswordManagers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePasswordManager([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var passwordManager = await _context.PasswordManager.FindAsync(id);
            if (passwordManager == null)
            {
                return NotFound();
            }

            _context.PasswordManager.Remove(passwordManager);
            await _context.SaveChangesAsync();

            return Ok(passwordManager);
        }

        private bool PasswordManagerExists(int id)
        {
            return _context.PasswordManager.Any(e => e.PasswordId == id);
        }
    }
}