using System.ComponentModel.DataAnnotations;

namespace ProjetoAM4.Models
{
    public class Email
    {
        [Display(Name = "Destinatário")]
        public string To { get; set; }
        [Display(Name = "Assunto")]
        public string Subject { get; set; }
        [Display(Name = "Mensagem")]
        public string Body { get; set; }


    }
}
