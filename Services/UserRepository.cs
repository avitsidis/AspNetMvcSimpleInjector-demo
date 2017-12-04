using System.Collections.Generic;

namespace Services
{
    public class DummyUserRepository : IUserRepository
    {
        public List<string> GetAllUsernames()
        {
            return new List<string> { "asidis","golum01" };
        }
    }
}
