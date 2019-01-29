using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _contex;

        public ValuesController(DataContext contex)
         {
            _contex = contex;
        }

        
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            //return new string[] { "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", };
            var values = await _contex.Values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            //return $"value {id}";
            var value = await _contex.Values.FirstOrDefaultAsync(x => x.Id == id);
             return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
