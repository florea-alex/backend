using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.BiografieRepositories
{
    public interface IBiografieRepository : IGenericRepository<Biografie>
    {
        Task<Biografie> GetByAnNastere(int an_nastere);
        public Task<Biografie> GetById(int id);
        Task<List<Biografie>> GetAllBiografii();
    }
}
