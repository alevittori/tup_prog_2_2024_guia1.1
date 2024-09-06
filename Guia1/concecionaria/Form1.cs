using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concecionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCacularCosto_Click(object sender, EventArgs e)
        {
            
            string m = tbMarca.Text;
            int mod = Convert.ToInt32(nModelo.Value);
            int anCalcular = Convert.ToInt32(nAnioCalcular.Value);
            double valor = Convert.ToDouble(tbValor.Text);
            double tasa = Convert.ToDouble(tbTasa.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);



            Moto unaMoto = new Moto(m, mod ,valor);
            FVerResultados fResultado = new FVerResultados();

           
            fResultado.lBResultado.Items.Clear();
            fResultado.lBResultado.Items.Add(unaMoto.VerDescricion());
            fResultado.lBResultado.Items.Add($"Depreciacion Linel: ${unaMoto.CalcularDepreciacionLineal(anCalcular, vidaUtil)}");
            fResultado.lBResultado.Items.Add($"Depreciacion Anual: ${unaMoto.CalcularDepreciacionAnual(anCalcular, tasa)}");

            fResultado.ShowDialog();



           // MessageBox.Show("Valor modelo " + nModelo.Value );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias POr usar nuestros Sistema");
            this.Close();
        }
    }
}
