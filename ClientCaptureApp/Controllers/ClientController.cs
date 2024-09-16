using Microsoft.AspNetCore.Mvc;
using ClientManagementLibrary.Models;
using ClientCaptureApp.Data;
using System.Threading.Tasks;

namespace ClientCaptureApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientDbContext _context;

        public ClientController(ClientDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Clients.Add(client);  // Add client to the database context
                await _context.SaveChangesAsync();  // Save changes to the database
                return RedirectToAction("Index");
            }

            return View(client);
        }
    }
}

