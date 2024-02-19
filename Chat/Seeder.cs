using Chat.Entites;

namespace Chat
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Roles.Any())
            {
                var adminRole = new RoleEntity
                {
                    Id = Guid.NewGuid(),
                    IsDeleted = false,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    CreatedDate = DateTime.UtcNow
                };

                context.Roles.Add(adminRole);

                var userRole = new RoleEntity
                {
                    Id = Guid.NewGuid(),
                    IsDeleted = false,
                    Name = "User",
                    NormalizedName = "USER",
                    CreatedDate = DateTime.UtcNow
                };

                context.Roles.Add(userRole);

                var user = new UserEntity
                {
                    Id = Guid.NewGuid(),
                    IsDeleted = false,
                    Birthday = DateTime.UtcNow,
                    CreatedDate = DateTime.UtcNow,
                    Email = "admin@gmail.com",
                    FirstName = "admin",
                    LastName = "admin",
                    Password = "12345678",
                    RoleId = adminRole.Id,
                    UserName = "admin"
                };

                context.Users.Add(user);

                context.SaveChanges();
            }
        }
    }
}
