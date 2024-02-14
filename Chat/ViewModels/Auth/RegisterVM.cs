namespace Chat.ViewModels.Auth
{
    public class RegisterVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
