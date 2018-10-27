using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransitAPI.Models;
using TransitAPI.Models.Data;

namespace TransitAPI.Controllers
{
    [ApiController]
    public class ReportsController : Controller
    {
        private readonly TirContext _context;

        public ReportsController(TirContext context)
        {
            _context = context;
        }

        [Route("api/[controller]/range")]
        [HttpGet]
        public ActionResult<Report> GetDistanceAndPrice([FromQuery]string start_date, [FromQuery]string end_date)
        {
            return new Report { TotalDistance = 90, TotalPrice = 220 };
        }
    }
}
