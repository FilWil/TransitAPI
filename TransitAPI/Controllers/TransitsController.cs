using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransitAPI.Models;
using TransitAPI.Models.Data;

namespace TransitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransitsController : Controller
    {
        private readonly TirContext _context;

        public TransitsController(TirContext context)
        {
            _context = context;

            //if (_context.Transits.Count() == 0)
            //{
            //    _context.Transits.Add(new Transit { SourceAddress = "Dont delete whole table from database!" });
            //}
        }

        [HttpGet]
        public ActionResult<List<Transit>> GetAll()
        {
            return _context.Transits.ToList();
        }

        [HttpGet("{id}", Name = "GetTransit")]
        public ActionResult<Transit> GetById(int id)
        {
            var item = _context.Transits.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult AddTransit([FromForm]Transit transit)
        {
            _context.Transits.Add(transit);
            _context.SaveChanges();

            string url = Request.Path;
            return Redirect(url);
            
        }
    }
}
