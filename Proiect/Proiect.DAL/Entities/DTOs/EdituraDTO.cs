using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class EdituraDTO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Cod_postal { get; set; }
        public int CarteId { get; set; }
        public List<Carte> Carti { get; set; }
        public EdituraDTO(Editura editura)
        {
            this.Id = editura.Id;
            this.Denumire = editura.Denumire;
            this.Adresa = editura.Adresa;
            this.Telefon = editura.Telefon;
            this.Cod_postal = editura.Cod_postal;
            this.CarteId = editura.CarteId;
            this.Carti = new List<Carte>();
        }
    }
}
