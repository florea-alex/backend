using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.ClientRepositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        public Task<List<Client>> GetFemeiClienti();
        public Task<List<Client>> GetBarbatiClienti();
        public Task<List<Client>> GetClient();
        public Task<Client> GetById(int id);
        Task<List<Client>> GetAllClienti();
    }
}
