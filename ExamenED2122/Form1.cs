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
        double cantidadTotalAPÑ2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeAPÑ2122 = Convert.ToDouble(txtImporte.Text);
            double IVAAPÑ2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAAPÑ2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                                          // Correción código 4% es 0.04
                IVAAPÑ2122 = 0.04;
            // Corrección código
            importeAPÑ2122 = importeAPÑ2122 * (1 + IVAAPÑ2122); // Calculamos el importe con IVA

            // Corrección código
            cantidadTotalAPÑ2122 = cantidadTotalAPÑ2122 + importeAPÑ2122; // Se lo añadimos a la cantidad total

            txtResultado.Text = Convert.ToString(importeAPÑ2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalAPÑ2122);
        }
    }
}
