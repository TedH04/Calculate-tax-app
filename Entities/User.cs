using Microsoft.AspNetCore.Identity;

namespace WebApi.Entities;

public class User : IdentityUser
{
    public string? BirthDate { get; set; }
}

