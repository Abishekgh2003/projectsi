using Microsoft.AspNetCore.Components.Sections;
using Microsoft.AspNetCore.Mvc;
using scopewebsite.Models;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using System.Diagnostics;
using MailKit.Net.Smtp;
using MimeKit;

namespace scopewebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult page5()
        {
            return View();
        }
        [HttpPost]
        public IActionResult page5(Class1 con)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("abishekgh88@gmail.com"));
            email.To.Add(MailboxAddress.Parse("abishekgh88@gmail.com"));
            email.Body = new TextPart(TextFormat.Html) { Text = $"<h1>hello new message<h1/><h2>{con.Name}<h2/><h2>{con.Email}<h2/><h2>{con.Subject}<h2/><h2>{con.Message}< h2/>" };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("abishekgh88@gmail.com", "tbyq bamc hbqd fgyp");
            smtp.Send(email);
            smtp.Disconnect(true);
            return View();

        }
        
    }
}

