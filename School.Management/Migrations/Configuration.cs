namespace School.Management.Migrations
{
    using School.Management.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<School.Management.Data.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(School.Management.Data.SchoolContext context)
        {
            var admin = new Users()
            {
                id = Guid.NewGuid(),
                Email = "admin@gmail.com",
                Username = "Admin",
                Password = "",
                UserType = Common.UserType.Admin

            };

        }
    }
}
