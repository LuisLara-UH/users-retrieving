using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private static readonly List<User> Users = new()
    {
        new User { Id = 1, Name = "Jhon Doe" },
        new User { Id = 2, Name = "Jane Doe" }
    };

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(Users);
    }

    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }
}