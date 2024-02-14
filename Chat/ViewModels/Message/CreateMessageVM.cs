namespace Chat.ViewModels.Message
{
    public class CreateMessageVM
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }

    }
}
