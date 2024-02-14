namespace Chat.ViewModels.User
{
    public class UserListVM
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
