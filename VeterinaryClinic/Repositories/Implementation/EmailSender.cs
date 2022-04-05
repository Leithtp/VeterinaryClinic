using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using VeterinaryClinic.Models;
using VeterinaryClinic.Repositories.Abstract;

namespace VeterinaryClinic.Repositories.Implementation
{
    public class EmailSender : IEmailSender
    {
        private IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendMessage(EmailViewModel model)
        {
            string email = model.email;
            string subject = model.subject;
            string text = model.text;

            SmtpClient client = new SmtpClient();
            client.Host = _configuration.GetSection("EmailSetting")["Host"];
            client.Port = int.Parse(_configuration.GetSection("EmailSetting")["Port"]);
            client.Credentials = new NetworkCredential(_configuration.GetSection("EmailSetting")["UserName"], _configuration.GetSection("EmailSetting")["Password"]);
            client.EnableSsl = bool.Parse(_configuration.GetSection("EmailSetting")["EnableSsl"]);

            MailMessage message = new MailMessage(email, _configuration.GetSection("EmailSetting")["UserName"]);
            message.Subject = subject;
            message.Body = text;

            client.Send(message);




        }
    }
}
