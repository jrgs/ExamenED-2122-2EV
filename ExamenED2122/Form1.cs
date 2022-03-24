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
        double cantidadTotalAO1CFSY;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeAO1CFSY = Convert.ToDouble(txtImporte.Text);
            double IVAAO1CFSY = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAAO1CFSY = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAAO1CFSY = 0.04;
            importeAO1CFSY = importeAO1CFSY + importeAO1CFSY * IVAAO1CFSY; // Calculamos el importe con IVA
            cantidadTotalAO1CFSY = cantidadTotalAO1CFSY + importeAO1CFSY; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeAO1CFSY);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalAO1CFSY);
        }
    }
}
