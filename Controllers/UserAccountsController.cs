using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GraphQLTesting.Models;

namespace GraphQLTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly CarlistDbContext _context;

        public UserAccountsController(CarlistDbContext context)
        {
            _context = context;
        }

        // GET: api/UserAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserAccounts>>> GetUserAccounts()
        {
            return await _context.UserAccounts.ToListAsync();
        }

        // GET: api/UserAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserAccounts>> GetUserAccounts(int id)
        {
            var userAccounts = await _context.UserAccounts.FindAsync(id);

            if (userAccounts == null)
            {
                return NotFound();
            }

            return userAccounts;
        }

        // PUT: api/UserAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAccounts(int id, UserAccounts userAccounts)
        {
            if (id != userAccounts.Id)
            {
                return BadRequest();
            }

            _context.Entry(userAccounts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAccountsExists(id))
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

        // POST: api/UserAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserAccounts>> PostUserAccounts(UserAccounts userAccounts)
        {
            _context.UserAccounts.Add(userAccounts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAccounts", new { id = userAccounts.Id }, userAccounts);
        }

        // DELETE: api/UserAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAccounts(int id)
        {
            var userAccounts = await _context.UserAccounts.FindAsync(id);
            if (userAccounts == null)
            {
                return NotFound();
            }

            _context.UserAccounts.Remove(userAccounts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserAccountsExists(int id)
        {
            return _context.UserAccounts.Any(e => e.Id == id);
        }
    }
}
