using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.CreateDTO
{
    public class CreateFacturaDTO
    {
        public int Id { get; set; }
        public string Data_factura { get; set; }
        public virtual Angajat Angajat { get; set; }
        public virtual Client Client { get; set; }
    }
}
