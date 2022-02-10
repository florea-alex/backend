using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class AutorDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<CarteAutor> CarteAutori { get; set; }
        public Biografie Biografie { get; set; }
        public AutorDTO(Autor autor)
        {
            this.Id = autor.Id;
            this.Nume = autor.Nume;
            this.Prenume = autor.Prenume;
            this.CarteAutori = new List<CarteAutor>();
            this.Biografie = autor.Biografie;
        }
    }
}
