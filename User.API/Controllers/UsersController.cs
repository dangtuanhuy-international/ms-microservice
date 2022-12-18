using Microsoft.AspNetCore.Mvc;
using User.API.Models;
using User.API.Services;

namespace User.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService userService;

    public UsersController(IUserService _userService)
    {
        userService = _userService;
    }

    [HttpGet]
    public IEnumerable<Users> UserList()
    {
        var userList = userService.GetUserList();
        return userList;
    }

    [HttpGet("{id}")]
    public Users GetUserById(int Id)
    {
        return userService.GetUserById(Id);
    }

    [HttpPost]
    public Users AddUser(Users user)
    {
        return userService.AddUser(user);
    }

    [HttpPut]
    public Users UpdateUser(Users user)
    {
        return userService.UpdateUser(user);
    }

    [HttpDelete("{id}")]
    public bool DeleteUser(int id)
    {
        return userService.DeleteUser(id);
    }
}