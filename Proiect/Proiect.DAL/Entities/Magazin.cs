using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Magazin
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string Cod_postal { get; set; }
        public int AngajatId { get; set; }
        public virtual ICollection<CarteMagazin> CarteMagazine { get; set; }
        public virtual ICollection<Angajat> Angajati { get; set; }
    }
}
