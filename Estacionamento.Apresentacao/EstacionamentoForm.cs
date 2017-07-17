using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Apresentacao
{
    public partial class EstacionamentoForm : Form
    {
        public EstacionamentoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                EstacionamentoService.EstacionamentoServiceClient client = new EstacionamentoService.EstacionamentoServiceClient();
                var retorno = client.Checkin(placa);
                client.Close();
                if (string.IsNullOrWhiteSpace(retorno))
                {
                    MessageBox.Show(String.Format("Placa '{0}' adicionada.", placa));
                }
                else
                {
                    MessageBox.Show(retorno);
                }
                textBox1.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                EstacionamentoService.EstacionamentoServiceClient client = new EstacionamentoService.EstacionamentoServiceClient();
                var valor = client.Checkout(placa);
                client.Close();
                
                MessageBox.Show(String.Format("Placa '{0}' valor de R${1}.", placa, valor));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EstacionamentoService.EstacionamentoServiceClient client = new EstacionamentoService.EstacionamentoServiceClient();
                var valor = client.VagasRestantes();
                client.Close();

                MessageBox.Show(String.Format("Numero de vagas restantes: {0}.", valor));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}