using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parquimetro
{

    public partial class frmParquimetro : Form
    {
        private int escolha;
        Parquimetro parquimetro = new Parquimetro();
        public frmParquimetro()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(rdb10.Checked)
            {
                parquimetro.addMoeda(0.10M);
            }
            else if(rdb25.Checked)
            {
                parquimetro.addMoeda(0.25M);
            }
            else if (rdb50.Checked)
            {
                parquimetro.addMoeda(0.50M);
            }
            else if (rdb1.Checked)
            {
                parquimetro.addMoeda(1M);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaldo2.Text = parquimetro.SaldoCons().ToString();
        }

        public bool testa(string mensagem)
        {
            if (mensagem == "Saldo insuficiente")
                return false;
            else
                return true;
        }
      

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string teste = parquimetro.Confirmar();
            bool decide = testa(teste);
            if(decide)
            {
                MessageBox.Show(
                teste + "\nTroco: " + parquimetro.Troco());
            }
            else
            {
                MessageBox.Show(teste);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            decimal depositado = parquimetro.Cancel();
            MessageBox.Show("Compra cancelada\n Valor devolvido: " + depositado);
        }

    }
}
