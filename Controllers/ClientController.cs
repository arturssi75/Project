using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClientController : ControllerBase
    {
        private readonly TransportContext _context;
        private readonly NotificationService _notificationService;

        public ClientController(TransportContext context, NotificationService notificationService)
        {
            _context = context;
            _notificationService = notificationService;
        }

        [HttpPost]
        public IActionResult SendNotification(string klientaId, string ziņa)
        {
            var klients = _context.Clients.FirstOrDefault(k => k.KlientaId == klientaId);
            if (klients == null)
            {
                return NotFound();
            }
            _notificationService.SendNotification(klients, ziņa);
            return Ok(new { Message = "Paziņojums nosūtīts" });
        }
    }
}