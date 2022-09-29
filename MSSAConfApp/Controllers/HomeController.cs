using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MSSAConfApp.Models;
using MSSAConfApp.Services;

namespace ConferenceApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private JsonFileSessionService _fileSessionService;
        public IEnumerable<Session> MySessions { get; private set; }

        public HomeController(ILogger<HomeController> logger,
                                JsonFileSessionService sessionService)
        {
            _logger = logger;
            _fileSessionService = sessionService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sessions()
        {

            MySessions = _fileSessionService.Sessions;
            return View(MySessions);
        }

        public IActionResult SessionDetails(int id)
        {
            
            Session MySession = _fileSessionService.Sessions.FirstOrDefault(s => s.Id.Equals(id));
            return View("sessiondetails", MySession);
        }

        public IActionResult Register(int id)
        {
            Session MySession = _fileSessionService.Sessions.FirstOrDefault(s => s.Id.Equals(id));
            return View("register",MySession);
        }
        
        public IActionResult Registered(string title)
        {
            Session MySession = _fileSessionService.Sessions.FirstOrDefault(s => s.Title.Equals(title));
            return View("registered", MySession);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}