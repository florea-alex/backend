using System;
using Proiect.DAL.Repositories.GenericRepository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Proiect.DAL.Repositories
{
    public class AutorRepository : GenericRepository<Autor>, IAutorRepository
    {
        public AutorRepository(AppDbContext context) : base(context) { }

        public async Task<List<Autor>> GetAllAutori()
        {
            return await _context.Autori.ToListAsync();
        }

        public async Task<Autor> GetByIdDupaNume(int id)
        {
            return await _context.Autori.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Autor> GetByPrenume(string prenume)
        {
            return await _context.Autori.Where(a => a.Prenume.Equals(prenume)).FirstOrDefaultAsync();
        }
    }
}
