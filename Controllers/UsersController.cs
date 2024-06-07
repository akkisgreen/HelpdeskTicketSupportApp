using Microsoft.AspNetCore.Mvc;
/// <summary>
/// User Datai Controlller
/// </summary>


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;


    /// <summary>
    /// UserService Controller methode
    /// </summary>
    /// <param name="userService"></param>
    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Bringt all Users
    /// </summary>
    /// <returns></returns>

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
    {
        var users = await _userService.GetAllUsersAsync();
        return Ok(users);
    }

    /// <summary>
    /// Bringt User datai nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>ok(user)</returns>

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(int id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }
    /// <summary>
    /// Erstellt eine Neue User
    /// </summary>
    /// <param name="user">user</param>
    /// <returns>CreatedAtAction</returns>


    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user)
    {
        var createdUser = await _userService.CreateUserAsync(user);
        return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
    }


    /// <summary>
    /// update user 
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="user">user</param>
    /// <returns>ok(updatedUser)</returns>

    [HttpPut("{id}")]
    public async Task<ActionResult<User>> UpdateUser(int id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }
        var updatedUser = await _userService.UpdateUserAsync(user);
        return Ok(updatedUser);
    }
    /// <summary>
    /// löscht user nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>NoContent();</returns>


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await _userService.DeleteUserAsync(id);
        return NoContent();
    }
}