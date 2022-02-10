using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.CreateDTO
{
    public class CreateBiografieDTO
    {
        public int Id { get; set; }
        public int An_nastere { get; set; }
        public string Loc_nastere { get; set; }
        public string Nume_real { get; set; }
        public string Nationalitate { get; set; }
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
