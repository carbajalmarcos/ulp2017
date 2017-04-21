using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval=500;
            timer1.Start();
        }
        /*
         Realizar un programa para ingresar los datos de un cliente (Nombre, Domicilio, Documento,
Saldo) que serán almacenados en una tabla en memoria, mientras en la cabecera del
formulario se desliza un banner de izquierda a derecha con el nombre de la empresa.
         
             */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 384;
           
            //750 limite dercho,20 izquierdo

            if (x == 750) {
                lblEmpresa.Location = new System.Drawing.Point(x, 20);

            }
            if (x == 20) {

                lblEmpresa.Location = new System.Drawing.Point(x, 20);

            }

        }
    }
}
