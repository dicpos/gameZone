using System;
using GameZone.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameZone.API.Data;

namespace GameZone.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {

        private readonly DataContext _context;
        public GameController(DataContext context)
        {
          _context = context;
        }

        [HttpGet]
        public IEnumerable<Games> Get()
        {
          return _context.Game;
        }

        [HttpGet("{id}")]
        public Games GetById(int id)
        {
          return _context.Game.FirstOrDefault(game => game.Id == id);
        }

        [HttpPost]
        public string Post()
        {
          return "Exemplo de Post";
        }


        [HttpPut("{id}")]
        public string Put(int id)
        {
          return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
          return $"Exemplo de Delete com id = {id}";
        }
    }
}