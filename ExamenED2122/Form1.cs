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
        double cantidadTotalJFPC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeJFPC = Convert.ToDouble(txtImporte.Text);
            double IVA_JFPC = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVA_JFPC = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVA_JFPC = 0.04;
            importeJFPC = importeJFPC + (importeJFPC * IVA_JFPC); // Calculamos el importe con IVA
            cantidadTotalJFPC = cantidadTotalJFPC + importeJFPC; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeJFPC);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalJFPC);
        }
    }
}
