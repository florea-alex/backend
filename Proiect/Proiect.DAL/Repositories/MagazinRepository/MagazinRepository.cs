using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.MagazinRepository
{
    public class MagazinRepository : GenericRepository<Magazin>, IMagazinRepository
    {
        public MagazinRepository(AppDbContext context) : base(context) { }
        public async Task<Magazin> GetById(int id)
        {
            return await _context.Magazine.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Magazin>> GetAllMagazine()
        {
            return await _context.Magazine.ToListAsync();
        }
    }
}
