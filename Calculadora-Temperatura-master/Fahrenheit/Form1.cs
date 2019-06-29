using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rdbCelsiuspfahr.Checked)
            {
                try
                {
                    Conversor conversor = new Conversor();
                    conversor.TemperaturaC = Double.Parse(txtCelsius.Text);
                    txtFahrenheit.Text = Convert.ToString(conversor.converterParaFahrenheit());
                }
                catch (Exception)
                {
                    MessageBox.Show("digite apenas numeros");
                }
            }

            else if(rdbFahrenheitpCelsius.Checked)
            {
                Conversor conversor = new Conversor();
                conversor.TemperaturaF = Double.Parse(txtFahrenheit.Text);
                txtCelsius.Text = Convert.ToString(conversor.converterParaCelsius());
            }

            else
            {
               MessageBox.Show("selecione uma das opcoes");
            }
        }

        private void rdbCelsiuspfahr_CheckedChanged(object sender, EventArgs e)
        {
            txtFahrenheit.Enabled = false;
            txtCelsius.Enabled = true;
        }

        private void rdbFahrenheitpCelsius_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtFahrenheit.Enabled = true;
        }
    }

}
