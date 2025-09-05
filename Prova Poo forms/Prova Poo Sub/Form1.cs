using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Poo_Sub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void rbAlim_CheckedChanged(object sender, EventArgs e)
        {


            lbDescEst.Text = "Descrição";
            lbFatAlimSaud.Text = "FatAlim";

        }

        private void rbSaud_CheckedChanged(object sender, EventArgs e)
        {


            lbDescEst.Text = "Estabelecimento";
            lbFatAlimSaud.Text = "FatSaud";

        }

        private List<Pagamento> pagamentos = new List<Pagamento>();
        

        private void btFaturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAlim.Checked)
                {
                    Alimentacao alim = new Alimentacao();
                    alim.setDescricao(txDescEstab.Text);
                    
                    alim.faturar();
                    pagamentos.Add(alim);
                }
                else if (rbSaud.Checked)
                {
                    Saude saude = new Saude();
                    saude.setEstab(txDescEstab.Text);
                    
                    saude.faturar();
                    pagamentos.Add(saude);
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Pagamento faturado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao faturar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            
            lsRelatorio.Items.Clear();
            foreach (var pagamento in pagamentos)
            {
                lsRelatorio.Items.Add($"{pagamento.getDescricao()} - Valor: R$ {pagamento.getValor():0.00}");
            }
        }

        private void LimparCampos()
        {
            txCpf.Text = "";
            
            txCod.Text = "";
            txDescEstab.Text = "";
            txFatAlimSaud.Text = "";
        }
    

       

    }
}
