using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class CarteDTO
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Nume { get; set; }

        public int DescriereId { get; set; }
        public Descriere Descriere { get; set; }
        public Editura Editura { get; set; }
        public List<CarteAutor> CarteAutori { get; set; }
        public List<CarteMagazin> CarteMagazine { get; set; }
        public CarteDTO(Carte carte)
        {
            this.Id = carte.Id;
            this.ISBN = carte.ISBN;
            this.Nume = carte.Nume;
            this.DescriereId = carte.DescriereId;
            this.Descriere = carte.Descriere;
            this.Editura = carte.Editura;
            this.CarteAutori = new List<CarteAutor>();
            this.CarteMagazine = new List<CarteMagazin>();
        }
    }
}
