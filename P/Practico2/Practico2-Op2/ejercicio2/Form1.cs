using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread hilo = new Thread(desplazarPC);
            hilo.Start();
        }


        public void desplazarPC() {
            for (int p=0;p<30;p++) {

                

                while (pbComputadora.Left < 283)
                {
                    pbComputadora.Invoke((Action)(() => {

                        pbComputadora.Left++;
                        if (pbUsuario.Location == pbComputadora.Location)
                        {

                            MessageBox.Show("Chpqie");
                            Application.Exit();
                        }
                    })
                  );
                    Thread.Sleep(5);
                }
                while (pbComputadora.Top < 210)
                {
                    pbComputadora.Invoke((Action)(() => {

                        pbComputadora.Top++;
                        if (pbUsuario.Location == pbComputadora.Location)
                        {
                            MessageBox.Show("Chpqie");
                            Application.Exit();
                        }
                    })
                  );
                    Thread.Sleep(5);
                }
                while (pbComputadora.Left > 0)
                {
                    pbComputadora.Invoke((Action)(() => {

                        pbComputadora.Left--;
                        if (pbUsuario.Location == pbComputadora.Location)
                        {
                            MessageBox.Show("Chpqie");

                            Application.Exit();
                        }
                    })
                  );
                    Thread.Sleep(5);
                }
                while (pbComputadora.Top > 0)
                {
                    pbComputadora.Invoke((Action)(() => {

                        pbComputadora.Top--;
                        if (pbUsuario.Location == pbComputadora.Location)
                        {
                            MessageBox.Show("Chpqie");

                            Application.Exit();
                        }
                    })
                  );
                    Thread.Sleep(5);
                }

            }



        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pbUsuario.Left= pbUsuario.Left-5;
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            pbUsuario.Top= pbUsuario.Top+5;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            pbUsuario.Top= pbUsuario.Top-5;
    
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pbUsuario.Left= pbUsuario.Left+5;
        }
    }
}
