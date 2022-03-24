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
         double cantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeMLMJ2122 = Convert.ToDouble(txtImporte.Text);
            double IVAMLMJ2122 = 0.21;
          
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAMLMJ2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAMLMJ2122 = 0.4;
            importeMLMJ2122 = importeMLMJ2122 * IVAMLMJ2122; // Calculamos el importe con IVA
            
            cantidadTotal = importeMLMJ2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(cantidadTotal);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotal);
        }
    }
}
