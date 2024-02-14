namespace Chat.Entites
{
    public class MessageEntity : BaseEntity<Guid>
    {
        public string Text { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public UserEntity? User { get; set; }
        public ChatEntity? Chat { get; set; }
    }
}
