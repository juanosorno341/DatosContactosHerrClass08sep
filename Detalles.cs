using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosContactosHerrClass08sep
{
    public partial class Detalles : Form
    {
        private Negocio2 _Negocio2;

        public Detalles()
        {
            InitializeComponent();
            _Negocio2 = new Negocio2();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Contacto2 contactos = new Contacto2();

            contactos.Nombre = txtnombre.Text;
            contactos.Apellido = txtapellido.Text;
            contactos.Telefono = txttelefono.TextLength;
            contactos.Dirección = txtdireccion.Text;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
