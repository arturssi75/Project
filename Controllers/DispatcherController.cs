using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using Route = Project.Models.Route;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DispatcherController : ControllerBase
    {
        private readonly TransportContext _context;

        public DispatcherController(TransportContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PlanRoute(string kravasId, string sakums, string galamerķis, List<string> starpposmi)
        {
            var krava = _context.Cargos.FirstOrDefault(c => c.KravasId == kravasId);
            if (krava == null)
            {
                return NotFound();
            }

            var marsruts = new Route
            {
                SakumaPunkts = sakums,
                Galamerķis = galamerķis,
                Starpposmi = starpposmi,
                ParedzamaisLaiks = DateTime.Now.AddHours(10)
            };

#pragma warning disable CS8601 // Possible null reference assignment.
            krava.Route = marsruts.ToString(); // Saglabā maršrutu kravā
#pragma warning restore CS8601 // Possible null reference assignment.
            _context.SaveChanges();
            return Ok(marsruts);
        }

        [HttpPost]
        public IActionResult RegisterCargo(Cargo cargo)
        {
            _context.Cargos.Add(cargo);
            _context.SaveChanges();
            return Ok(cargo);
        }
    }
}