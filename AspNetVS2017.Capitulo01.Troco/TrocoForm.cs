using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }
        
        private void calcularButton_Click(object sender, EventArgs e)
        {
            var valorPago = Convert.ToDecimal( valorPagoTextBox.Text);
            var valorCompra =Convert.ToDecimal(valorCompraTextBox.Text);
            var troco =  valorPago - valorCompra;
            // var troco = 10;

            trocoTextBox.Text = troco.ToString("c");

            var moedas1 = (int)(troco / 1); //(int)  chama-se cast
            troco = troco % 1;

            var moedas050 = (int)(troco / 0.5m);
            troco %= 0.5m;

            var moedas025 = (int)(troco / 0.25m);
            troco %= 0.25m;

            var moedas010 = (int)(troco / 0.10m);
            troco %= 0.10m;

            var moedas005 = (int)(troco / 0.05m);
            troco %= 0.25m;

            var moedas001 = (int)(troco / 0.01m);
            troco %= 0.01m;

            MoedasListView.Items[0].Text = moedas1.ToString();
            MoedasListView.Items[1].Text = moedas050.ToString();
            MoedasListView.Items[2].Text = moedas025.ToString();
            MoedasListView.Items[3].Text = moedas010.ToString();
            MoedasListView.Items[4].Text = moedas005.ToString();
            MoedasListView.Items[5].Text = moedas001.ToString();
        }
    }
}
