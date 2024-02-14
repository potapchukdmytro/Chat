namespace Chat.ViewModels.Chat
{
    public class ChatVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
