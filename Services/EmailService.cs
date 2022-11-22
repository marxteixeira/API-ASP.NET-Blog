using System.Net.Mail;

namespace Blog.Services
{
    public class EmailService
    {
        public boll Send(
            string toName,
            string toEmail,
            string subject,
            string body,
            string fromName = "Equipe suporte.io",
            string fromEmail = "email@suporte.io")
        {
            var smtpClient = new SmtpClient(Configuration.Smtp.Host, Configuration.Smtp.Port);
        }
    }
}
