using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
        public ActionResult<Cargo> GetCargoById(int id)
        {
            var cargo = _context.Cargos.Include(c => c.Vehicle).FirstOrDefault(c => c.CargoId == id);
            if (cargo == null)
            {
                return NotFound();
            }
            return Ok(cargo);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cargo>> GetAllCargo()
        {
            var cargos = _context.Cargos.Include(c => c.Vehicle).ToList();
            return Ok(cargos);
        }
    }
}