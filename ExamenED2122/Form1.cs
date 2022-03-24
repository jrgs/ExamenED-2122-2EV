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
        double cantidadTotalAERG2122;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importeAERG2122 = Convert.ToDouble(txtImporte.Text);
            double IVAAERG2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVAAERG2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVAAERG2122 = 0.04;//PONER 0,04
            if (rbNormal.Checked == true)  // normal 21%,.faltaba por documentar este boton
                IVAAERG2122 = 0.21;//iva normal


            importeAERG2122 = importeAERG2122 * IVAAERG2122; // Calculamos el importe con IVA
            cantidadTotalAERG2122 = importeAERG2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeAERG2122);//se debe de cambiar el campo de importe por cantidadtotal
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalAERG2122);
        }
    }
}
