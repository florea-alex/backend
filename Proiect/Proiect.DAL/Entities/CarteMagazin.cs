using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class CarteMagazin
    {
        public int Id { get; set; }
        public int Stoc { get; set; }
        public int Disponibilitate { get; set; }
        public int CarteId { get; set; }
        public int MagazinId { get; set; }
        public virtual Carte Carte { get; set; }
        public virtual Magazin Magazin { get; set; }
    }
}
