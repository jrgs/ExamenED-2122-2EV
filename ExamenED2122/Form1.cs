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
        double cantidadTotalOBG2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeOBG2122 = Convert.ToDouble(txtImporte.Text);
            double IVAOBG2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAOBG2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAOBG2122 = 0.04;
            importeOBG2122 = importeOBG2122 +(importeOBG2122 * IVAOBG2122);        // Calculamos el importe con IVA
            cantidadTotalOBG2122 = importeOBG2122 +cantidadTotalOBG2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeOBG2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalOBG2122);
        }
    }
}
