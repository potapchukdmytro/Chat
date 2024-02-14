using Chat.Entites;
using Microsoft.EntityFrameworkCore;

namespace Chat.Repositories
{
    public class GenericRepository<T, TEntity>
        where T : notnull
        where TEntity : class, IBaseEntity<T>
    {
        private readonly AppDbContext context;

        public GenericRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Create(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            entity.IsDeleted = false;
            context.Set<TEntity>().Add(entity);
            var res = context.SaveChanges();
            return res > 0;
        }

        public bool Update(TEntity entity)
        {
            context.Update(entity);
            var res = context.SaveChanges();
            context.Entry(entity).State = EntityState.Detached;
            return res > 0;
        }

        public bool Delete(T id)
        {
            var entity = context
                .Set<TEntity>()
                .FirstOrDefault(e => e.Id.Equals(id));
            if (entity == null)
            {
                return false;
            }

            entity.IsDeleted = true;
            return Update(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(e => !e.IsDeleted);
        }
    }
}
