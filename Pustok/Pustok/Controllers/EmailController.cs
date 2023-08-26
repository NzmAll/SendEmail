using Microsoft.AspNetCore.Mvc;
using Pustok.ViewModels.Client;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pustok.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(SendEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your-email@gmail.com", "your-email-password"),
                    EnableSsl = true,
                };

                var message = new MailMessage
                {
                    From = new MailAddress("your-email@gmail.com"),
                    Subject = model.EmailTitle,
                    Body = model.EmailContent,
                };

                foreach (var recipient in model.EmailRecipients.Split(','))
                {
                    message.To.Add(recipient.Trim());
                }

                await smtpClient.SendMailAsync(message);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
