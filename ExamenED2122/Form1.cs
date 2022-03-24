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
        double cantidadTotalMPRG2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
          
            double importeMPRG2122 = Convert.ToDouble(txtImporte.Text);
            double IVAMPRG2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAMPRG2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAMPRG2122 = 0.04;
            importeMPRG2122 = (importeMPRG2122 * IVAMPRG2122) + importeMPRG2122; // Calculamos el importe con IVA
            cantidadTotalMPRG2122 = cantidadTotalMPRG2122+importeMPRG2122; // Se lo añadimos a la cantidad total

            txtResultado.Text = Convert.ToString(importeMPRG2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalMPRG2122);
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
