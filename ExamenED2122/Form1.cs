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
        double cantidadTotalAMG2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeAMG2122 = Convert.ToDouble(txtImporte.Text);
           
            // Declaro variables
            double IVAAMG2122=0;
            double totalIVAAMG2122;

            if (rbNormal.Checked == true)
                IVAAMG2122 = 0.21;

            // IVA reducido, 10%
            if (rbReducido.Checked == true)  
                IVAAMG2122 = 0.1;

            // IVA super reducido, 4%
            if (rbSuper.Checked == true)  
                IVAAMG2122 = 0.4;

            // Calculamos el importe con IVA
            totalIVAAMG2122 = importeAMG2122 * IVAAMG2122;
            // Añado esta linea con el fin de separar el IVA y sumarlo al importe total
            importeAMG2122 = importeAMG2122 + totalIVAAMG2122;
            // Se lo añadimos a la cantidad total
            cantidadTotalAMG2122 = importeAMG2122 ; 
            txtResultado.Text = Convert.ToString(importeAMG2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalAMG2122);
        }
    }
}
