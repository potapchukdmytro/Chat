namespace Chat.Entites
{
    public class RoleEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public virtual List<UserEntity> Users { get; set; } = new();
    }
}
