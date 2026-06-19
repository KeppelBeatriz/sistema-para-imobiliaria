using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormRH : Form
    {
        private RHData rhData = new RHData();
        private bool modoEdicao = false;
        private int idSelecionado = 0;

        public FormRH()
        {
            InitializeComponent();
            CarregarRH();
        }

        private void CarregarRH()
        {
            dgvRH.DataSource = rhData.Listar();
        }

        // quando clica no grid, preenche os campos e entra em modo edição
        private void dgvRH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvRH.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdRH"].Value);
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtCpf.Text = linha.Cells["Cpf"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                txtNivelAcesso.Text = linha.Cells["NivelAcesso"].Value.ToString();
                txtSenha.Text = "";
                // marca que veio do grid — vai fazer UPDATE
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                RH rh = new RH();
                rh.Nome = txtNome.Text.Trim();
                rh.Cpf = txtCpf.Text.Trim();
                rh.Telefone = txtTelefone.Text.Trim();
                rh.Email = txtEmail.Text.Trim();
                rh.Senha = txtSenha.Text.Trim();
                rh.NivelAcesso = int.Parse(txtNivelAcesso.Text.Trim());

                if (modoEdicao)
                {
                    // veio do grid — faz UPDATE
                    rh.Id = idSelecionado;
                    rhData.Atualizar(rh);
                    MessageBox.Show("RH atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // digitado manualmente — faz INSERT
                    rhData.Inserir(rh);
                    MessageBox.Show("RH cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregarRH();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar RH: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            try
            {
                dgvRH.DataSource = rhData.BuscarPorNome(txtBuscar.Text.Trim());
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
                if (dgvRH.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um RH para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvRH.SelectedRows[0].Cells["IdRH"].Value);
                rhData.Excluir(id);
                MessageBox.Show("RH excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarRH();
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
            txtNivelAcesso.Text = "";
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
        }
    }
}