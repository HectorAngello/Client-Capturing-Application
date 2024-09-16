using Microsoft.AspNetCore.Mvc;
using ClientManagementLibrary.Models;
using System.Linq;
using System.Threading.Tasks;
using ClientAnalyticsApp.data;
using Microsoft.EntityFrameworkCore;

namespace ClientAnalyticsApp.Controllers
{
    public class ClientAnalyticsController : Controller
    {
        private readonly ClientDbContext _context;

        public ClientAnalyticsController(ClientDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch the data from the database
            var clients = _context.Clients.ToList(); // Ensure this returns a list

            // If there are no clients, return an empty list to avoid a null exception
            if (clients == null)
            {
                clients = new List<Client>();
            }

            // Pass the clients to the view
            return View(clients);
        }
    }
}

