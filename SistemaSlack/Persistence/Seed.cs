using Domain;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any()) {
                var users = new List<AppUser>
             {
                 new AppUser
                 {
                     Id="1",
                     UserName = "Rodrigo",
                     Email = "rodrigo23@gmail.com"
                 },

                 new AppUser
                 {
                     Id="2",
                     UserName = "kevin",
                     Email = "kevin23@gmail.com"
                 },

                 new AppUser
                 {
                     Id="3",
                     UserName = "Rosa",
                     Email = "rosa23@gmail.com"
                 }

             };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user,"1*Pruebas");
                }

            }
        }
    }
}
