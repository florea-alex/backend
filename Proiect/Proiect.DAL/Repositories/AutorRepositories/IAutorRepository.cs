using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories
{
        public interface IAutorRepository : IGenericRepository<Autor>
        {
            Task<Autor> GetByPrenume(string prenume);
            Task<List<Autor>> GetAllAutori();
            Task<Autor> GetByIdDupaNume(int id);
        }
}
