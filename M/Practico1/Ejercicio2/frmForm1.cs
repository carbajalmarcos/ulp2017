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
    /*public delegate void mensaje(String msj);*/

    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }
        Action<string> mensaje;
        int contadora = 0;
        //mensaje a;

        private void cambiaMensaje(String msj)
        {
            lblEtiqueta.Text = msj;
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            frmForm2 frm2 = new frmForm2(contadora, mensaje);
            contadora++;
            frm2.ShowDialog();
        }

        private void frmForm1_Load(object sender, EventArgs e)
        {
            //a = new mensaje(cambiaMensaje);
            mensaje = cambiaMensaje;
        }
    }
}
