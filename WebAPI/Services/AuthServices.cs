using System.ComponentModel.DataAnnotations;


namespace DNDProject.WebAPI.Services;
public class AuthService : IAuthService
{
    public AuthService(HotelContext context)
    {
        users = context.Users.ToList();
    }
    private readonly IList<User> users;

    public Task<User> ValidateUser(string username, string password)
    {
        User? existingUser = users.FirstOrDefault(u =>
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) ?? throw new Exception("User not found");

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return Task.FromResult(existingUser);
    }

    public Task RegisterUser(User user)
    {

        if (string.IsNullOrEmpty(user.Username))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(user.Password))
        {
            throw new ValidationException("Password cannot be null");
        }
        // Do more user info validation here

        // save to persistence instead of list

        users.Add(user);

        return Task.CompletedTask;
    }
}
