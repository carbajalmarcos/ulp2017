using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class frmForm1 : Form
    {
        String estado = "ABIERTO";
        public frmForm1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Temporizador.Interval = 5000;
            Temporizador.Start();
            lblEstado.Text = "ABIERTO";
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if(estado=="ABIERTO")
            {
                lblEstado.Text="CERRADO";
                estado = "CERRADO";
                btnVerEstado.Click -= entrar;
                btnVerEstado.Click += noEntrar;
            }
            else
            {
                lblEstado.Text = "ABIERTO";
                estado = "ABIERTO";
                btnVerEstado.Click -= noEntrar;
                btnVerEstado.Click += entrar;
            }
        }

        private void entrar(Object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }

        private void noEntrar(Object sender, EventArgs e)
        {
            MessageBox.Show("Tienda cerrada");
        }





        
    }
}
