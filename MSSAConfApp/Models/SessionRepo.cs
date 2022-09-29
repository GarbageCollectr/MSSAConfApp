namespace MSSAConfApp.Models
{
    public class SessionRepo
    {
        private List<Session> sessions = new List<Session>();
        

        public List<Session> GetSessions()
        {
            return sessions;
        }

        public Session GetSession(int id)
        {
            return sessions.FirstOrDefault(s => s.Id == id);
        }
    }
}
