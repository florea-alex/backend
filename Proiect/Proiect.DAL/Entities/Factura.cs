using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Factura
    {
        public int Id { get; set; }
        public string Data_factura { get; set; }
        public virtual Angajat Angajat { get; set; }
        public virtual Client Client { get; set; }
    }
}
