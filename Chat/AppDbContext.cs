using Chat.Entites;
using Microsoft.EntityFrameworkCore;

namespace Chat
{
    public class AppDbContext : DbContext
    {
        public DbSet<LogEntity> Logs { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<UserChatEntity> UserChats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSqlLocalDb;Database=Chat;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Logs
            builder.Entity<LogEntity>()
                .Property(e => e.Message)
                .IsRequired()
                .HasMaxLength(255);

            // Chat
            builder.Entity<ChatEntity>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(50);

            // User
            builder.Entity<UserEntity>()
                .Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<UserEntity>()
                .Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<UserEntity>()
                .Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<UserEntity>()
                .Property(e => e.Birthday)
                .IsRequired();

            // UserChat
            builder.Entity<UserChatEntity>()
                .HasKey(uc => new { uc.ChatId, uc.UserId });

            builder.Entity<ChatEntity>()
                .HasMany(c => c.UserChats)
                .WithOne(uc => uc.Chat)
                .HasForeignKey(uc => uc.ChatId);

            builder.Entity<UserEntity>()
                .HasMany(u => u.UserChats)
                .WithOne(uc => uc.User)
                .HasForeignKey(uc => uc.UserId);

            // Message
            builder.Entity<MessageEntity>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.UserId);

            builder.Entity<MessageEntity>()
                .HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId);
        }
    }
}
