using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenED2122
{
    public partial class Form1 : Form
    {
        double cantidadTotalVRP2DAW;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double ImporteVRP2DAW = Convert.ToDouble(txtImporte.Text);
            double IVAVRP2DAW = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAVRP2DAW = 0.10;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAVRP2DAW = 0.04;
            ImporteVRP2DAW = (ImporteVRP2DAW * IVAVRP2DAW) + ImporteVRP2DAW; // Calculamos el ImporteVRP2DAW con IVAVRP2DAW
            cantidadTotalVRP2DAW = cantidadTotalVRP2DAW + ImporteVRP2DAW; // Se lo añadimos a la cantidad total


            //txtResultado.Text = Convert.ToString(ImporteVRP2DAW);

        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalVRP2DAW);

            
        }
    }
}
