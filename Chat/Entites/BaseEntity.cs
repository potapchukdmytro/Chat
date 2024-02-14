using System.ComponentModel.DataAnnotations;

namespace Chat.Entites
{
    public interface IBaseEntity<T> where T : notnull
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class BaseEntity<T> : IBaseEntity<T> where T : notnull
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
