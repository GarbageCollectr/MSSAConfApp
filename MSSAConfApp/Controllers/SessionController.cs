using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSSAConfApp.Data;

namespace MSSAConfApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private SessionsContext _sessionsContext;
        public IEnumerable<Session> MySessions { get; private set; }
        public SessionController(SessionsContext context)
        {
            _sessionsContext = context;
        }

        [HttpGet]
        public string Get()
        {
            MySessions = _sessionsContext.NewTables;
            
            return MySessions.ToString();
        }
    }
}
