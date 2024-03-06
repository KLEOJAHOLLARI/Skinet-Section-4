using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "kleo",
                    Email = "kleo@test.com",
                    UserName = "kleo@test.com",
                    Address = new Address
                    {
                        FirstName = "Kleo",
                        LastName = "Jahollari",
                        Street = "yzb",
                        City = "Tirana",
                        State = "AL",
                        ZipCode = "0000"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}