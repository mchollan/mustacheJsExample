using Microsoft.AspNetCore.Mvc;
using mustacheJsExample.Models;
using System.Diagnostics;
using System.Text.Json;

namespace mustacheJsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Contacts()
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact { Id = Guid.NewGuid(), Name = "Matt", Address = new ContactAddress { AddressLine1 = "123 Fake St", City = "Lakeland", State = "FL", PostalCode = "33813"}, PhoneNumber = "3219876544" });
            contacts.Add(new Contact { Id = Guid.NewGuid(), Name = "Ralph", Address = new ContactAddress { AddressLine1 = "456 Other St", City = "St. Pete", State = "FL", PostalCode = "33333" }, PhoneNumber = "9876543211" });
            contacts.Add(new Contact { Id = Guid.NewGuid(), Name = "Gage", Address = new ContactAddress { AddressLine1 = "987 way Rd", City = "Bartow", State = "FL", PostalCode = "34344" }, PhoneNumber = "8527419633" });

            return Json(contacts, new JsonSerializerOptions { PropertyNamingPolicy = null }); // Keeps the default json serializer from lowercasing all my models
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}