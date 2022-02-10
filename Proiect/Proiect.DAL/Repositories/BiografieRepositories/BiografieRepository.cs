using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.BiografieRepositories
{
    public class BiografieRepository : GenericRepository<Biografie>, IBiografieRepository
    {
        public BiografieRepository(AppDbContext context) : base(context) { }

        public async Task<Biografie> GetByAnNastere(int an_nastere)
        {
            return await _context.Biografii.Where(a => a.An_nastere == an_nastere).FirstOrDefaultAsync();
        }
        public async Task<Biografie> GetById(int id)
        {
            return await _context.Biografii.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Biografie>> GetAllBiogarfii()
        {
            return await _context.Biografii.ToListAsync();
        }
    }
}
