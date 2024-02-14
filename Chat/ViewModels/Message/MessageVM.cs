namespace Chat.ViewModels.Message
{
    public class MessageVM
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public string ChatName { get; set; }
        public DateTime Date { get; set; }
    }
}
