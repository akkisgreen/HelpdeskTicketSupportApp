/// <summary>
/// Users Service klasse
/// </summary>

public class UserService
{
    private readonly IUserRepository _userRepository;
    /// <summary>
    /// UserRepositry Service klass
    /// </summary>
    /// <param name="userRepository"></param>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Alle Users bringt
    /// </summary>
    /// <returns>GetAllUsersAsync()</returns>
    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return _userRepository.GetAllUsersAsync();
    }

    /// <summary>
    /// Bringt User nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>GetUserByIDAsync();</returns>
    public Task<User?> GetUserByIdAsync(int id)
    {
        return _userRepository.GetUserByIdAsync(id);
    }

    /// <summary>
    /// Erstellt User mit Name
    /// </summary>
    /// <param name="user">user</param>
    /// <returns>CreateUserAsync();</returns>
    public Task<User> CreateUserAsync(User user)
    {
        return _userRepository.CreateUserAsync(user);
    }
    /// <summary>
    /// update user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Task<User> UpdateUserAsync(User user)
    {
        return _userRepository.UpdateUserAsync(user);
    }
    /// <summary>
    /// löscht den user nach ID
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns>DeleteUserAsync(id);</returns>
    public Task DeleteUserAsync(int id)
    {
        return _userRepository.DeleteUserAsync(id);
    }
}