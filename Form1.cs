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
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Detalles detalles = new Detalles();
            detalles.ShowDialog();

        }
    }
}
