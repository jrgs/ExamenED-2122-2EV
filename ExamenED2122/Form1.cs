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
        double cantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importe_APC = Convert.ToDouble(txtImporte.Text);
            double IVA_APC = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVA_APC = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVA_APC = 0.04;
            importe_APC = importe_APC + importe_APC * IVA_APC; // Calculamos el importe con IVA
            cantidadTotal = cantidadTotal + importe_APC; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importe_APC);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotal);
        }
    }
}
