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
        double SD2122_cantidadTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double SD2122_importe = Convert.ToDouble(txtImporte.Text);
            double SD2122_IVA = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                SD2122_IVA = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                SD2122_IVA = 0.04;
            // Calculamos el importe con IVA
            SD2122_cantidadTotal = SD2122_cantidadTotal + (SD2122_importe + (SD2122_importe * SD2122_IVA)); // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(SD2122_importe + (SD2122_importe * SD2122_IVA));
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(SD2122_cantidadTotal);
        }
    }
}
