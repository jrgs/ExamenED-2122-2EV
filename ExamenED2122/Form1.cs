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
        double cantidadTotalJMR2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeJMR2122 = Convert.ToDouble(txtImporte.Text);
            double IVAJMR2122 = 1.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAJMR2122 = 1.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAJMR2122 = 1.04;
            importeJMR2122 = importeJMR2122 * IVAJMR2122; // Calculamos el importe con IVA
            cantidadTotalJMR2122 += importeJMR2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeJMR2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalJMR2122);
        }
    }
}
