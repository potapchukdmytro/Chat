namespace Chat.Entites
{
    public class LogEntity : BaseEntity<Guid>
    {
        public string Message { get; set; }
        public string Type { get; set; }
    }
}
