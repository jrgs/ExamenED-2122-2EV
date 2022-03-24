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
        double cantidadTotalJBG1DAW2022;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeJBG1DAW2022 = Convert.ToDouble(txtImporte.Text);

            double IVAJBG1DAW2022 = 0.21;
            
            if (rbReducido.Checked == true)  // IVA reducido, 10%
            
                IVAJBG1DAW2022 = 0.1;
            
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
            
                IVAJBG1DAW2022 = 0.04;
            
            importeJBG1DAW2022 = importeJBG1DAW2022  +  importeJBG1DAW2022 * IVAJBG1DAW2022; // Calculamos el importe con IVA
            
            cantidadTotalJBG1DAW2022 = cantidadTotalJBG1DAW2022 + importeJBG1DAW2022; // Se lo añadimos a la cantidad total
            
            txtResultado.Text = Convert.ToString(importeJBG1DAW2022);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {

            txtResultado.Text = Convert.ToString(cantidadTotalJBG1DAW2022);
        }
    }
}
