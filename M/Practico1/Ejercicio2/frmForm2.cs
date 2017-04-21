using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class frmForm2 : Form
    {
        //mensaje a;
        int cont;
        Action<string> cambiamensaje;
        //public frmForm2(int x,mensaje d)
        public frmForm2(int contadora,Action<string> cambiamensaje)
        {
            InitializeComponent();
            this.cambiamensaje = cambiamensaje;
            cont = contadora;
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {
            cambiamensaje("Ha sido enviado con num de instancia "+cont);
            this.Close();
        }

    }
}
