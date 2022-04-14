using ApiEmiguremi.Models;
using ApiEmiguremi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmiguremi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectItemController : ControllerBase
    {

        private readonly EmiguremiDbContext _db;

        public ProyectItemController(EmiguremiDbContext db) 
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectItem>>> GetProyectItems() 
        {
            return await _db.ProyectItems.ToListAsync();
        }
    }
}
