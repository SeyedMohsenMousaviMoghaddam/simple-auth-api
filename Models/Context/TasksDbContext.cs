using Microsoft.EntityFrameworkCore;

namespace Auth.API.Models.Context
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext()
        {
        }

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
