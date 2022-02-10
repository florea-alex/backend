using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.EdituraRepositories
{
    public interface IEdituraRepository : IGenericRepository<Editura>
    {
        public Task<Editura> GetByIdSiDenumire(int id);
        public Task<Editura> GetById(int id);
        Task<List<Editura>> GetAllEdituri();
    }
}
