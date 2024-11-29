using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace DNDProject.Domain.Auth;
public static class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("Customer", a =>
                a.RequireAuthenticatedUser().RequireClaim("SecurityLevel", "1"));

            options.AddPolicy("Admin", a =>
                a.RequireAuthenticatedUser().RequireClaim("SecurityLevel", "2"));
        });
    }
}
