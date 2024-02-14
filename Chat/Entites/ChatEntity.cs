namespace Chat.Entites
{
    public class ChatEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public virtual List<UserChatEntity> UserChats { get; set; } = new();
        public virtual List<MessageEntity> Messages { get; set; } = new();
    }
}
