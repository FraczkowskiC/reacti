using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var value = await _context.Values.FindAsync(id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] Value value)
        {
            await _context.Values.AddAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] Value value)
        {
            // await _context.Values.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            // await _context.Values.Update(value);

        }
    }
}
