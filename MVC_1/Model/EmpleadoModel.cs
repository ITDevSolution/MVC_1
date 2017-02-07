using MVC_1.Entity;
using MVC_1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_1.Model
{
    public class EmpleadoModel
    {
        //Metodo para procesar dato

        public void procesarDatos(Empleado emp)
        {
            //calcular total, renta y neto
            emp.Total = emp.Dias * emp.Horas * emp.pagoXhora;
            if(emp.Total > 1500)
            {
                emp.Renta = emp.Total * Constante.RENTA;
            }
            else
            {
                emp.Renta = 0;
            }
            emp.Neto = emp.Total - emp.Renta;
        }
    }
}
