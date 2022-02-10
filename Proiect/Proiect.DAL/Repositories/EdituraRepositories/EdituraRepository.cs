using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.EdituraRepositories
{
    public class EdituraRepository : GenericRepository<Editura>, IEdituraRepository
    {
        public EdituraRepository(AppDbContext context) : base(context) { }
        public async Task<Editura> GetByIdSiDenumire(int id)
        {
            return await _context.Edituri.Include(a => a.Denumire).Where(a => a.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Editura> GetById(int id)
        {
            return await _context.Edituri.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Editura>> GetAllEdituri()
        {
            return await _context.Edituri.ToListAsync();
        }
    }
}
