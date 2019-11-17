using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TEST2.Models;

[assembly: OwinStartupAttribute(typeof(TEST2.Startup))]
namespace TEST2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRoles();
        }

        private void createRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("visitor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "visitor" };
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "admin" };
                roleManager.Create(role);
            }
            //allowed only emirates id
            if (!roleManager.RoleExists("employee_EID"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "employee_EID" };
                roleManager.Create(role);
            }
            //allowed only insurance
            if (!roleManager.RoleExists("employee_INC"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "employee_INC" };
                roleManager.Create(role);
            }
            //allowed only passport
            if (!roleManager.RoleExists("employee_PASS"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "employee_PASS" };
                roleManager.Create(role);
            }
            //allowed only visa and labor card
            if (!roleManager.RoleExists("employee_VLC"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "employee_VLC" };
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("employee_con"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "employee_con" };
                roleManager.Create(role);
            }

        }
    }
}
