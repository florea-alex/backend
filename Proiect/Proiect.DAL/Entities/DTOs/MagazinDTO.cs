using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class MagazinDTO
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string Cod_postal { get; set; }
        public int AngajatId { get; set; }
        public List<CarteMagazin> CarteMagazine { get; set; }
        public List<Angajat> Angajati { get; set; }
        public MagazinDTO(Magazin magazin)
        {
            this.Id = magazin.Id;
            this.Adresa = magazin.Adresa;
            this.Cod_postal = magazin.Cod_postal;
            this.AngajatId = magazin.AngajatId;
            this.CarteMagazine = new List<CarteMagazin>();
            this.Angajati = new List<Angajat>();
        }
    }
}
