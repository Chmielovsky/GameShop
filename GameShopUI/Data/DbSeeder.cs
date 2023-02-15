using Microsoft.AspNetCore.Identity;
using GameShopUI.Constants;

namespace GameShopUI.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();
            //dodawanie ról do DB

            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //podstawowy Admin

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            if (userInDb is  null) 
            {
                await userMgr.CreateAsync(admin, "Admin123!");
                await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());   
                   
            }
        }
    }
}
