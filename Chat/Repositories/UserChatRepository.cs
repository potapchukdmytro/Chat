using Chat.Entites;
using Microsoft.EntityFrameworkCore;

namespace Chat.Repositories
{
    public class UserChatRepository
    {
        private readonly AppDbContext context;

        public UserChatRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Create(UserChatEntity entity)
        {
            context.UserChats.Add(entity);
            var res = context.SaveChanges();
            return res > 0;
        }

        public UserChatEntity? GetByIds(Guid userId, Guid chatId)
        {
            var res = context.UserChats.FirstOrDefault(uc => uc.UserId == userId && uc.ChatId == chatId);
            return res;
        }

        public void Delete(UserChatEntity entity)
        {
            context.UserChats.Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<UserChatEntity> GetAll()
        {
            return context.UserChats.AsNoTracking();
        }
    }
}
