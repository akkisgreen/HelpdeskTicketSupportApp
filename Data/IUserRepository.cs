/// <summary>
/// User Interface repository
/// </summary>
public interface IUserRepository
{   /// <summary>
    /// bringt All user mit Async
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<User>> GetAllUsersAsync();
    /// <summary>
    /// bringt user nach ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>

    Task<User?> GetUserByIdAsync(int id);

    /// <summary>
    /// erstellt neue user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<User> CreateUserAsync(User user);

    /// <summary>
    /// update eine user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<User> UpdateUserAsync(User user);

    /// <summary>
    /// löscht den user nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    Task DeleteUserAsync(int id);
}