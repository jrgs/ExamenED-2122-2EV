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
        double YAGcantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double YAGimporte = Convert.ToDouble(txtImporte.Text);
            double YAGIVA = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                YAGIVA = 0.1 ;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                YAGIVA = 0.4 ;
            // si 5 * 0.21 = 1.05 + 5
            // 3 * 0.10  = 0.3
            YAGimporte = (YAGimporte * YAGIVA) + YAGimporte; // Calculamos el importe con IVA
            YAGcantidadTotal = YAGimporte; // Se lo añadimos a la cantidad total12.0
            txtResultado.Text = Convert.ToString(YAGimporte);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(YAGcantidadTotal);
        }
    }
}
