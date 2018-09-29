
using ProjectManager.BusinessLogic.Models;

namespace ProjectManager.BusinessLogic.Interfaces
{
    public interface IUser
    {
        User GetUserById(int id);
    }
}
