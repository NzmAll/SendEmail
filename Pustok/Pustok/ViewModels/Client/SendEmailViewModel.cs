using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels.Client
{
    public class SendEmailViewModel
    {
        [Required(ErrorMessage = "Use email title")]
        public string EmailTitle { get; set; }

        [Required(ErrorMessage = "Use email content")]
        public string EmailContent { get; set; }

        [Required(ErrorMessage = "Use email recipients")]
        public string EmailRecipients { get; set; }
    }
}
