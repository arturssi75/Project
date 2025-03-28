using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SensorController : ControllerBase
    {
        private readonly TransportContext _context;

        public SensorController(TransportContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddSensorData(Sensor sensor)
        {
            _context.Sensors.Add(sensor);
            _context.SaveChanges();
            return Ok(sensor);
        }

        [HttpGet("cargo/{cargoId}")] //get sensor data by cargo
        public ActionResult<IEnumerable<Sensor>> GetSensorDataByCargoId(int cargoId)
        {
            var sensorData = _context.Sensors.Where(s => s.CargoId == cargoId).ToList();
            if (sensorData.Count == 0)
            {
                return NotFound($"No sensor data found for cargo with id {cargoId}");
            }
            return Ok(sensorData);
        }

        [HttpPost]
        public IActionResult AddSensorLocation(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
            return Ok(location);
        }

        [HttpGet("location/{locationId}")]
        public ActionResult<Location> GetLocationById(int locationId)
        {
            var location = _context.Locations.FirstOrDefault(l => l.LocationId == locationId);
            if (location == null)
            {
                return NotFound($"No location found with id {locationId}");
            }
            return Ok(location);
        }
    }
}