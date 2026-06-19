using System;
using System.Windows.Forms;
using domos.data;

namespace domos.forms
{
    public partial class FormComissao : Form
    {
        private CorretorData corretorData = new CorretorData();

        public FormComissao()
        {
            InitializeComponent();
        }

        private void btnCalcularClick(object sender, EventArgs e)
        {
            try
            {
                int idCorretor = int.Parse(txtIdCorretor.Text.Trim());
                double valorPorVenda = double.Parse(txtValorComissao.Text.Trim());

                // busca o corretor pelo ID para pegar a quantidade de vendas
                var corretor = corretorData.BuscarPorId(idCorretor);
                if (corretor == null)
                {
                    MessageBox.Show("Corretor não encontrado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // calcula a comissão usando o método da classe Corretor
                double comissao = corretor.CalcularComissao(valorPorVenda * corretor.QuantidadeVendas);
                lblResultado.Text = "Resultado: R$ " + comissao.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparClick(object sender, EventArgs e)
        {
            txtIdCorretor.Text = "";
            txtValorComissao.Text = "";
            lblResultado.Text = "Resultado: R$ 0,00";
        }
		
		
		
		
    }
}