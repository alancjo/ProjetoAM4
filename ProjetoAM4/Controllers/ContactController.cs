using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoAM4.AuxiliaresCode;
using ProjetoAM4.Models;
using ProjetoAM4.Repositories;
using ProjetoAM4.Services;

namespace ProjetoAM4.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        protected readonly IContactRepository _contactRepo;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepo = contactRepository;
        }

        [Route("admin/fale-conosco")]
        public IActionResult Index()
        {
            var contacts = _contactRepo.GetAll();

            return View(contacts);
        }

        [Route("/fale-conosco")]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        [Route("/fale-conosco")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (!ValidationCPF.IsValid(model.CPF)) // se o CPF for válido
            {
                ModelState.AddModelError("CPF", "Cpf invalido");
            }

            if (ModelState.IsValid)
            {
                var saved = _contactRepo.Create(model);
                if (saved)
                {
                    SendMail.SendContactUs(model.Email, model.MotiveMessage); // envio de email 
                    ViewBag.Message = "Contato enviado com sucesso!";
                    return View(new Contact());
                }

                return View(model);
            }

            return View(model);

        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            if (id != 0)
            {
                _contactRepo.Delete(id);
                return Json(new { status = true, Msg = "Contato excluido com sucesso" });
            }

            return Json(new { status = false, Msg = "O id não pode ser 0." });
        }

        [Route("detalhes")]
        public IActionResult Details(int id)
        {
            var contact = _contactRepo.GetDetails(id);

            return View(contact);
        }

        public IActionResult Respond(int id)
        {
            var contact = _contactRepo.GetDetails(id);

            var email = new Email()
            {
                To = contact.Email
            };

            return View(email);
        }

        [HttpPost]
        public IActionResult Respond(Email email)
        {

            SendMail.AnswerEmail(email);
            ViewBag.Message = "O Email foi enviado para " + email.To + " Com sucesso..!";

            email.Subject = "";
            email.Body = "";

            return View(email);

        }
    }
}
