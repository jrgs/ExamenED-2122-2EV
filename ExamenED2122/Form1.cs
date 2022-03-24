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
        double JSMDAWcantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double JSMDAWimporte = Convert.ToDouble(txtImporte.Text);
            double JSMDAWIVA = 0.21;
            
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                JSMDAWIVA = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                JSMDAWIVA = 0.04;
            JSMDAWimporte = (JSMDAWimporte * JSMDAWIVA) + JSMDAWimporte; // Calculamos el importe con IVA
            JSMDAWcantidadTotal = JSMDAWimporte + JSMDAWcantidadTotal; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(JSMDAWimporte);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(JSMDAWcantidadTotal);
        }
    }
}
