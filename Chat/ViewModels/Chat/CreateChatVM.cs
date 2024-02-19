namespace Chat.ViewModels.Chat
{
    public class CreateChatVM
    {
        public string Title { get; set; }
        public Guid UserId { get; set; }
        public bool IsPublic { get; set; }
    }
}
