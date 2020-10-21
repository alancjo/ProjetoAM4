using System.Collections.Generic;
using ProjetoAM4.Models;

namespace ProjetoAM4.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetAll();

        Contact GetDetails(int id);

        bool Create(Contact contact);

        void Delete(int id);

    }
}
