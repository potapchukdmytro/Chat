namespace Chat.Entites
{
    public class UserEntity : BaseEntity<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday {get;set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; } = null;
        public virtual List<UserChatEntity> UserChats { get; set; } = new();
        public virtual List<MessageEntity> Messages { get; set; } = new();
    }
}
