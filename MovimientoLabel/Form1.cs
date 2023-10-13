using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoLabel
{
    public partial class Form1 : Form
    {
        int velocidad = 50;
        int pasoH = 10;
        int pasoV = 5;
        int posicionH = 0;
        int posicionV = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btInicio_Click(object sender, EventArgs e)
        {
            btInicio.Visible = false;
            lblPantalla.Visible = false;
            Label figura = new Label();
            figura.BackColor = Color.Blue;
            figura.Text = "DvD";
            figura.Font = new System.Drawing.Font("Arial Black", 16F);
            figura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            figura.Top = posicionV;
            figura.Left = posicionH;
            figura.Width = 70;
            figura.Height = 50;

            Controls.Add(figura);

            for (int i = 0; i < 10000; i++)
            {
                posicionH = posicionH + pasoH;
                figura.Left = posicionH;
                posicionV = posicionV + pasoV;
                figura.Top = posicionV;



                if (posicionH + figura.Width > this.Width)
                {
                    pasoH = -1 * pasoH;
                }
                else if (posicionH < 0)
                {
                    pasoH = -1 * pasoH;
                }

                if (posicionV + figura.Height > this.Height)
                {
                    pasoV = -1 * pasoV;
                }
                else if (posicionV < 0)
                {
                    pasoV = -1 * pasoV;
                }

                await Task.Delay(velocidad);

            }
        }
    }
    }

