namespace Chat.Constants
{
    public static class PathFiles
    {
        public static string Images { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "images");
        public static string UserFile { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "data", "user.xml");
    }
}
