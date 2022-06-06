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
        double cantidadtotalAIGC2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeAIGC2122 = Double.Parse(txtImporte.Text);
            double ivaAIGC2122 = 0.21;
            double ivaAIGC2122redu = 0.1;
            double ivaAIGC2122super = 0.4;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                ivaAIGC2122redu = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                ivaAIGC2122super = 0.4;
            importeAIGC2122 = importeAIGC2122 * ivaAIGC2122 / 100; // Calculamos el importe con IVA
            importeAIGC2122 = importeAIGC2122 * ivaAIGC2122 / 100;
            importeAIGC2122 = importeAIGC2122 * ivaAIGC2122redu / 100; // Calculamos el importe con IVA
            importeAIGC2122 = importeAIGC2122 * ivaAIGC2122super / 100;
            cantidadtotalAIGC2122 = importeAIGC2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeAIGC2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadtotalAIGC2122);
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
            {

            }
        }
}
