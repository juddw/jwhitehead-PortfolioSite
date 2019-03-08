using System.ComponentModel.DataAnnotations;

namespace jwhitehead_PortfolioSite.Models
{
    public class EmailModel
    {
        [Required, Display(Name = "Name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }
        [Display(Name = "Email2"), EmailAddress]  // login view model, block spammers! Hidden field.
        public string FromEmail2 { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }
    }
}