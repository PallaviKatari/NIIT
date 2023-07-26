using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }
    }
    public interface IConfiguration
    {
        string GetSetting(string key);
    }
    public class AppConfigConfiguration : IConfiguration
    {
        public string GetSetting(string key)
        {
            // implementation details here
            return "";
        }
    }
    public class EmailService
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        public EmailService(ILogger logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public void SendEmail(string toAddress, string subject, string body)
        {
            _logger.Log($"Sending email to {toAddress} with subject '{subject}' and body '{body}'");
            // implementation details here
        }
    }
    public class EmailServiceMain
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IConfiguration configuration = new AppConfigConfiguration();
            EmailService emailService = new EmailService(logger, configuration);
            emailService.SendEmail("pallavikatari@gmail.com", "Test Subject", "This is a test email");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
