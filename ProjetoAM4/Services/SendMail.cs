using System;
using System.Net;
using System.Net.Mail;
using ProjetoAM4.Enums;
using ProjetoAM4.Models;

namespace ProjetoAM4.Services
{
    public class SendMail
    {
        public static bool SendContactUs(string email, TypeMotive motive)
        {
            // Envio de email

            try
            {
                MailMessage _mailMessage = new MailMessage();
                _mailMessage.From = new MailAddress(email);

                _mailMessage.CC.Add(email);
                _mailMessage.Subject = "Fale Conosco";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "<p>Recebemos sua " + motive + ". Em breve responderemos!<br><br> Obrigado pela sua opinião, ela é muito importante para nós<br><br>Att,<br>Equipe Fale Conosco</p>";

                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", 587);

                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("faleconosco.projeto@gmail.com", "988319362");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_mailMessage);

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool AnswerEmail(Email em)
        {

            MailMessage mm = new MailMessage();
            mm.To.Add(em.To);
            mm.Subject = em.Subject;
            mm.Body = em.Body;
            mm.From = new MailAddress("faleconosco.projeto@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("faleconosco.projeto@gmail.com", "988319362");
            smtp.Send(mm);

            return true;
        }

    }
}