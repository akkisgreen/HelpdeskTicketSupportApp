// Models/User.cs
/// <summary>
/// User Objekt
/// </summary>
public class User
{   /// <summary>
    /// user objekts ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// user objekts Name
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// user objekt pasword
    /// </summary>
    public string Password { get; set; } = string.Empty;// Notiz Verschlusselung muss beutzen

    /// <summary>
    /// user mail
    /// </summary>
    public string Email { get; set; } = string.Empty;   
}
