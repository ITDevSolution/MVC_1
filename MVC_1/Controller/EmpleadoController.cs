using MVC_1.Model;
using MVC_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_1.Controller
{
    public class EmpleadoController
    {
        // Declaramos la variable clase EmpleadoModel
        EmpleadoModel empModel;
        //constructor
        public EmpleadoController()
        {
            empModel = new EmpleadoModel();
        }
        //Metodo Negocio
        public string calcularSueldo(Empleado emp)
        {
            empModel.procesarDatos(emp);
            string boleta = "BOLETA DE PAGO\n" +
                "Empleado       : " + emp.Nombre + "\n" +
                "Dias Trab      : " + emp.Dias + "\n" +
                "Horas Trab     : " + emp.Horas + "\n" +
                "Pago x Hora    : " + emp.pagoXhora + "\n" +
                "Total          : " + emp.Total + "\n" +
                "Renta          : " + emp.Renta + "\n" +
                "Sueldo Neto    : " + emp.Neto;
            return boleta;
        }

    }
}
