using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using MovieShop.Models;
using Microsoft.AspNet.Identity;

[assembly: OwinStartupAttribute(typeof(MovieShop.Startup))]
namespace MovieShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User 
            if (!roleManager.RoleExists("Admin"))
            {

                // create admin roole
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //create default admin user 
                var user = new ApplicationUser();
                user.UserName = "AdminUser";
                user.Email = "adminguser@yahoo.com";

                string userPWD = "@Lexicon11";

                var chkUser = UserManager.Create(user, userPWD);

                //Add Stefan to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }



         
        }

    }
}

