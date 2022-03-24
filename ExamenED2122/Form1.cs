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
        double CCC2122cantidadTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double CCC2122importe = Convert.ToDouble(txtImporte.Text);
            double CCC2122IVA = 1.21;//Para que sume el IVA hay que multiplicar por 1,21 
                                     //Al multiplicar por 0,21 sólo nos dice a cuanto equival el IVA sin sumarlo

            if (rbReducido.Checked == true)  // IVA reducido, 10%
                CCC2122IVA = 1.1;

            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                CCC2122IVA = 1.04;

            CCC2122importe = CCC2122importe * CCC2122IVA; // Calculamos el importe con IVA

            CCC2122cantidadTotal = CCC2122cantidadTotal + CCC2122importe; // Se lo añadimos a la cantidad total
            //Pero ahora lo sumamos de verdad, hasta ahora le dabamos el valor de CCC2122Importe

            txtResultado.Text = Convert.ToString(CCC2122importe);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(CCC2122cantidadTotal);
        }
    }
}
