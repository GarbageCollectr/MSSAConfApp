using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using MSSAConfApp.Models;

namespace MSSAConfApp.Services
{
    public class JsonFileSessionService
    {
        public IEnumerable<Session> Sessions { get; set; }

        public void InitializeSessions()
        {
            Sessions = GetSessions();
        }

        public IEnumerable<Session> GetSessions()
        {
            using (var jsonFileReader = File.OpenText("wwwroot/data/sessions.json"))
            {
                return JsonSerializer.Deserialize<Session[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        
    }
}
