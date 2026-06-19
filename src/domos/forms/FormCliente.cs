using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormCliente : Form
    {
        private ClienteData clienteData = new ClienteData();
        // controla se o usuário clicou no grid (edição) ou digitou manualmente (novo)
        private bool modoEdicao = false;
        private int idSelecionado = 0;

        public FormCliente()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            dgvClientes.DataSource = clienteData.Listar();
        }

        // quando clica em uma linha do grid, preenche os campos e entra em modo edição
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvClientes.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdCliente"].Value);
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtCpf.Text = linha.Cells["Cpf"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                dtpNascimento.Value = Convert.ToDateTime(linha.Cells["DataNascimento"].Value);
                txtRenda.Text = linha.Cells["RendaMensal"].Value.ToString();
                // marca que veio do grid — vai fazer UPDATE
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text.Trim();
                cliente.Cpf = txtCpf.Text.Trim();
                cliente.Telefone = txtTelefone.Text.Trim();
                cliente.Email = txtEmail.Text.Trim();
                cliente.DataNascimento = dtpNascimento.Value;
                cliente.RendaMensal = double.Parse(txtRenda.Text.Trim());

                if (modoEdicao)
                {
                    // veio do grid — faz UPDATE
                    cliente.IdCliente = idSelecionado;
                    clienteData.Atualizar(cliente);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // digitado manualmente — faz INSERT
                    clienteData.Inserir(cliente);
                    MessageBox.Show("Cliente salvo com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregarClientes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = clienteData.BuscarPorNome(txtBuscar.Text.Trim());
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
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um cliente para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IdCliente"].Value);
                clienteData.Excluir(id);
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarClientes();
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
            txtRenda.Text = "";
            dtpNascimento.Value = DateTime.Today;
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
        }
    }
}