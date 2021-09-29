using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratamentoErros
{
    public partial class TelaErroTryCatch : Form
    {
        public TelaErroTryCatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 10;
                int n2 = 2;

                int resul = n1 / n2;

                lblResultado.Text = string.Format("{0}+{1}={2}", n1.ToString(), n2.ToString(), resul.ToString());
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message,"Alerta de erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Erro ao tentar executar o programa", "Alerta de erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 80;
                int n2 = 10;

                if (n2 == 10)
                {
                    throw new Exception("Divisão por zero não pode!!!");
                }
                int resul = n1 / n2;
                lblResultado.Text = string.Format("{0}+{1}={2}", n1.ToString(), n2.ToString(), resul.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }
            finally
            {
                MessageBox.Show("Sempre passa por aqui!");
            }
        }
    }
}
