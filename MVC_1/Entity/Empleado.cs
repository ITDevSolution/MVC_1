using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_1.Entity
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Dias { get; set; }
        public int Horas { get; set; }
        public decimal pagoXhora { get; set; }
        public decimal Total { get; set; }
        public decimal Renta { get; set; }
        public decimal Neto { get; set; }
    }
}
