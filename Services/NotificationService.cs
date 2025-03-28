using Project.Models;

namespace Project.Services
{
    public class NotificationService
    {
        public void SendNotification(Client sanemejs, string zina)
        {
             Console.WriteLine($"Paziņojums nosūtīts klientam {sanemejs.Vards} ({sanemejs.KlientaId}): {zina}");
        }
    }
}