using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class BiografieDTO
    {
        public int Id { get; set; }
        public int An_nastere { get; set; }
        public string Loc_nastere { get; set; }
        public string Nume_real { get; set; }
        public string Nationalitate { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public BiografieDTO(Biografie biografie)
        {
            this.Id = biografie.Id;
            this.An_nastere = biografie.An_nastere;
            this.Loc_nastere = biografie.Loc_nastere;
            this.Nume_real = biografie.Nume_real;
            this.Nationalitate = biografie.Nationalitate;
            this.AutorId = biografie.AutorId;
            this.Autor = biografie.Autor;
        }
    }
}
