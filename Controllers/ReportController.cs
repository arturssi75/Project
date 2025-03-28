using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReportController : ControllerBase
    {
        private readonly TransportContext _context;

        public ReportController(TransportContext context)
        {
            _context = context;
        }

        [HttpGet("{kravasId}")]
        public ActionResult<DeliveryReport> GenerateReport(string kravasId)
        {
            var krava = _context.Cargos.FirstOrDefault(c => c.KravasId == kravasId);
            if (krava == null)
            {
                return NotFound();
            }

            var atskaite = new DeliveryReport
            {
                AtskaitesId = Guid.NewGuid().ToString(),
                PiegadesLaiks = DateTime.Now,
                SanemejaApstiprinajums = "Paraksts",
                
            };

            _context.PiegadesAtskaites.Add(atskaite); 
            _context.SaveChanges();
            return Ok(atskaite);
        }
    }
}