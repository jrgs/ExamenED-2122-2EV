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
        double cantidadTotal_PDMP2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importe_PDMP2122 = Convert.ToDouble(txtImporte.Text);
            double IVA_PDMP2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVA_PDMP2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVA_PDMP2122 = 0.04;
            importe_PDMP2122 = importe_PDMP2122 * IVA_PDMP2122+ importe_PDMP2122; // Calculamos el importe con IVA
            cantidadTotal_PDMP2122 = importe_PDMP2122+ cantidadTotal_PDMP2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importe_PDMP2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotal_PDMP2122);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
