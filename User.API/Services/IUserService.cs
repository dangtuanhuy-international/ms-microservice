using User.API.Models;

namespace User.API.Services;

public interface IUserService
{
    public IEnumerable<Users> GetUserList();
    public Users GetUserById(int id);
    public Users AddUser(Users user);
    public Users UpdateUser(Users user);
    public bool DeleteUser(int Id);
}
