using MVC_1.Controller;
using MVC_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_1.View
{
    public partial class EmpleadoView : Form
    {
        public EmpleadoView()
        {
            InitializeComponent();
        }
        EmpleadoController empC = new EmpleadoController();
        Empleado emp = new Empleado();
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            calcular();
        }
        
        private void calcular()
        {
            emp.Nombre = txtNombre.Text;
            emp.Dias = int.Parse(txtDias.Text);
            emp.Horas = int.Parse(txtHoras.Text);
            emp.pagoXhora = int.Parse(txtPagoxHora.Text);

            //Mostrar resultados
            txtBoleta.Text = "";
            txtBoleta.Text = empC.calcularSueldo(emp);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDias.Clear();
            txtHoras.Clear();
            txtPagoxHora.Clear();
            txtBoleta.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EmpleadoView_Load(object sender, EventArgs e)
        {

        }


    }
}
