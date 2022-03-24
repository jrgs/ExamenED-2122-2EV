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
        double cantidadTotalJPBC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeJPBC = Convert.ToDouble(txtImporte.Text);
            double IVAJPBC = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAJPBC = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAJPBC = 0.04;
            importeJPBC = importeJPBC + (importeJPBC * IVAJPBC); // Calculamos el importe con IVA
            cantidadTotalJPBC = cantidadTotalJPBC + importeJPBC; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeJPBC);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalJPBC);
        }
    }
}
