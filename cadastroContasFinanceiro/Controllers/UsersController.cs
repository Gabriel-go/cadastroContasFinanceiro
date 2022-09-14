using cadastroContasFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cadastroContasFinanceiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Contexto _context;
        public UsersController(Contexto context)
        {
            _context = context;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> userList = _context.User.ToList();
            return userList;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            User user = await _context.User.FindAsync(id);
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        public User Post(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            return user;
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, User user)
        {
             User userFind = await _context.User.FindAsync(id);

            if (id != userFind.Id)
            {
                return NotFound();
            }
            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User userFind = await _context.User.FindAsync(id);

            if (id != null)
            {
                return NotFound();
            }
            try
            {
                _context.User.Remove(userFind);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }
    }
}
