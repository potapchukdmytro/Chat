namespace Chat.Entites
{
    public class UserChatEntity
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public UserEntity? User { get; set; }
        public ChatEntity? Chat { get; set; }
    }
}
