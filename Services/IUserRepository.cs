using System.Collections.Generic;

namespace Services
{
    public interface IUserRepository
    {
        List<string> GetAllUsernames();
    }
}
