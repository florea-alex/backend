using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.AngajatRepositories
{
    public class AngajatRepository : GenericRepository<Angajat>, IAngajatRepository
    {
        public AngajatRepository(AppDbContext context) : base(context) { }

        public async Task<List<Angajat>> GetAllAngajatiDupaJob(string job)
        {
            return await _context.Angajati.Where(a => a.Job.Equals(job)).ToListAsync();
        }

        public async Task<Angajat> GetJobById(int id)
        {
            return await _context.Angajati.Include(a => a.Job).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Angajat> GetByPrenume(string prenume)
        {
            return await _context.Angajati.Where(a => a.Prenume.Equals(prenume)).FirstOrDefaultAsync();
        }

        public async Task<List<Angajat>> GetAng()
        {
            return await _context.Angajati.ToListAsync();
        }

        public async Task<Angajat> GetById(int id)
        {
            return await _context.Angajati.Where(a => a.Id == id).FirstOrDefaultAsync();
        }
    }
}
