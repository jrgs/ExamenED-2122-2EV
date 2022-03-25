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
        double cantidadTotalFAM;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeFAM = Convert.ToDouble(txtImporte.Text);
            double IVAFAM = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAFAM = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAFAM = 0.04;
            importeFAM = importeFAM + (importeFAM * IVAFAM); // Calculamos el importe con IVA
            cantidadTotalFAM = cantidadTotalFAM + importeFAM; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeFAM);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalFAM);
        }
    }
}
