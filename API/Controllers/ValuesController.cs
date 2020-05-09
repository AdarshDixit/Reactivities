using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        public ValuesController(DataContext context)
        {
            this.context = context;
        }
        private readonly ILogger<ValuesController> _logger;
        private readonly DataContext context;       

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            return Ok(await this.context.Values.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            return Ok(await this.context.Values.FindAsync(id));
        }
    }
}
