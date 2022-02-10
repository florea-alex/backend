using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.AngajatRepositories
{
    public interface IAngajatRepository : IGenericRepository<Angajat>
    {
        Task<Angajat> GetJobById(int id);
        Task<List<Angajat>> GetAllAngajatiDupaJob(string job);
        Task<Angajat> GetByPrenume(string prenume);

        Task<List<Angajat>> GetAng();
        public Task<Angajat> GetById(int id);
    }
}
