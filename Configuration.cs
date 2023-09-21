namespace Blogv2;

public static class Configuration
{
    public static string JwtKey = "ZyOIVEevTDCElAAAc4YyrA";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "|C~CE*T3CX[^aMIXYI/EZ$G-dnd.";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

