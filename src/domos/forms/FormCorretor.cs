using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormCorretor : Form
    {
        private CorretorData corretorData = new CorretorData();
        private bool modoEdicao = false;
        private int idSelecionado = 0;

        public FormCorretor()
        {
            InitializeComponent();
            CarregarCorretores();
        }

        private void CarregarCorretores()
        {
            dgvCorretores.DataSource = corretorData.Listar();
        }

        // quando clica no grid, preenche os campos e entra em modo edição
        private void dgvCorretores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvCorretores.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdCorretor"].Value);
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtCpf.Text = linha.Cells["Cpf"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                txtCreci.Text = linha.Cells["Creci"].Value.ToString();
                txtTaxaComissao.Text = linha.Cells["TaxaComissao"].Value.ToString();
                txtSenha.Text = "";
                // marca que veio do grid — vai fazer UPDATE
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                Corretor corretor = new Corretor();
                corretor.Nome = txtNome.Text.Trim();
                corretor.Cpf = txtCpf.Text.Trim();
                corretor.Telefone = txtTelefone.Text.Trim();
                corretor.Email = txtEmail.Text.Trim();
                corretor.Senha = txtSenha.Text.Trim();
                corretor.Creci = txtCreci.Text.Trim();
                corretor.TaxaComissao = double.Parse(txtTaxaComissao.Text.Trim());

                if (modoEdicao)
                {
                    // veio do grid — faz UPDATE
                    corretor.Id = idSelecionado;
                    corretorData.Atualizar(corretor);
                    MessageBox.Show("Corretor atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // digitado manualmente — faz INSERT
                    corretor.QuantidadeVendas = 0;
                    corretorData.Inserir(corretor);
                    MessageBox.Show("Corretor salvo com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregarCorretores();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar corretor: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            try
            {
                dgvCorretores.DataSource = corretorData.BuscarPorNome(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExcluirClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCorretores.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um corretor para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvCorretores.SelectedRows[0].Cells["IdCorretor"].Value);
                corretorData.Excluir(id);
                MessageBox.Show("Corretor excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCorretores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparClick(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtCreci.Text = "";
            txtTaxaComissao.Text = "";
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
        }
		
		
    }
}