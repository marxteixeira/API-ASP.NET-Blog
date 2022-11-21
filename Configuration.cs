namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey { get; set; } = "ZmVkYWY3ZDg4NjNiNDhlMTk3YjkyODdkNDkyYjcwOGU=";
        public static string ApiKeyName { get; set; } = "api_key";
        public static string ApiKey { get; set; } = "curso_api_IlTevUM/z0ey3NCV/unWg==";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }

    
}
