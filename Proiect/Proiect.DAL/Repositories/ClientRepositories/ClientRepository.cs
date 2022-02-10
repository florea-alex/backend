using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.ClientRepositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(AppDbContext context) : base(context) { }
        public async Task<List<Client>> GetFemeiClienti()
        {
            return await _context.Clienti.Where(a => (a.CNP.Length == 13 && (a.CNP[0] == '2' || a.CNP[0] == '6'))).ToListAsync();
        }

        public async Task<List<Client>> GetBarbatiClienti()
        {
            return await _context.Clienti.Where(a => (a.CNP.Length == 13 && (a.CNP[0] == '1' || a.CNP[0] == '5'))).ToListAsync();
        }

        public async Task<List<Client>> GetClient()
        {
            return await _context.Clienti.Where(a => a.Id > 0).ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _context.Clienti.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Client>> GetAllClienti()
        {
            return await _context.Clienti.ToListAsync();
        }
    }
}
