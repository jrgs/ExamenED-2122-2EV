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
        double Scj2122CantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double Scj2122Importe = Convert.ToDouble(txtImporte.Text);
            double Scj2122IVA = 1.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                Scj2122IVA = 1.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                Scj2122IVA = 1.04;
            Scj2122Importe = Scj2122Importe * Scj2122IVA; // Calculamos el importe con IVA
            Scj2122CantidadTotal = Scj2122CantidadTotal + Scj2122Importe; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(Scj2122Importe);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Scj2122CantidadTotal);
        }
    }
}
