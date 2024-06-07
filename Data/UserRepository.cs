using HelpdeskTicketSupportApp.Data;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// UserRepositor ertellt
/// </summary>
public class UserRepository : IUserRepository
{   /// <summary>
/// User Context
/// </summary>
    private readonly AppDbContext _context;
    /// <summary>
    /// Context Für Users
    /// </summary>
    /// <param name="context"></param>
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Bringt All user Repo
    /// </summary>
    /// <returns>Users.ToListAsync</returns>
    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
    /// <summary>
    /// Bringt Users nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>Users.FindAsync</returns>
    public async Task<User?> GetUserByIdAsync(int id)
    {   var user =await _context.Users.FindAsync(id);
        if(user== null)
        {

        }
        return  await _context.Users.FindAsync(id);
    }
    /// <summary>
    /// Erstellt neue Benutzer
    /// </summary>
    /// <param name="user">User</param>
    /// <returns>user</returns>
    public async Task<User> CreateUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
    /// <summary>
    /// update user info
    /// </summary>
    /// <param name="user">user</param>
    /// <returns>user</returns>
    public async Task<User> UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
    /// <summary>
    /// löscht User Datai nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>Contex.savechanges</returns>
    public async Task DeleteUserAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
