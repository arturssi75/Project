using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CargoController : ControllerBase
    {
        private readonly TransportContext _context;

        public CargoController(TransportContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult RegisterCargo(Cargo cargo)
        {
            _context.Cargos.Add(cargo);
            _context.SaveChanges();
            return Ok(cargo);
        }

        [HttpGet("{id}")]
        public ActionResult<Cargo> GetCargoById(string id)
        {
            var cargo = _context.Cargos
                .Include(c => c.Sensors)  // Iekļauj sensorus
                .Include(c => c.Gps)      // Iekļauj GPS datus
                .FirstOrDefault(c => c.KravasId == id);
            if (cargo == null)
            {
                return NotFound();
            }
            return Ok(cargo);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cargo>> GetAllCargo()
        {
            var cargos = _context.Cargos
                .Include(c => c.Sensors)
                .Include(c => c.Gps)
                .ToList();
            return Ok(cargos);
        }

        [HttpPost("{id}/Sensors")]
        public IActionResult AddSensorsToCargo(string id, List<Sensors> sensors)
        {
            var cargo = _context.Cargos.FirstOrDefault(c => c.KravasId == id);
            if (cargo == null)
            {
                return NotFound();
            }

            cargo.Sensors.AddRange(sensors);
            _context.SaveChanges();
            return Ok(cargo);
        }
    }
}