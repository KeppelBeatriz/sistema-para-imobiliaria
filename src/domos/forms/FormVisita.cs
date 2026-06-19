using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormVisita : Form
    {
        private VisitaData visitaData = new VisitaData();
        private bool modoEdicao = false;
        private int idSelecionado = 0;

        public FormVisita()
        {
            InitializeComponent();
            CarregarVisitas();
        }

        private void CarregarVisitas()
        {
            dgvVisitas.DataSource = visitaData.Listar();
        }

        // quando clica no grid, preenche os campos e entra em modo edição
        private void dgvVisitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvVisitas.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdVisita"].Value);
                txtIdCliente.Text = linha.Cells["IdCliente"].Value.ToString();
                txtIdCorretor.Text = linha.Cells["IdCorretor"].Value.ToString();
                txtIdImovel.Text = linha.Cells["IdImovel"].Value.ToString();
                dtpDataHora.Value = Convert.ToDateTime(linha.Cells["DataHora"].Value);
                cmbStatus.Text = linha.Cells["Status"].Value.ToString();
                txtObservacao.Text = linha.Cells["Observacao"].Value.ToString();
                // marca que veio do grid — vai fazer UPDATE
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                Visita visita = new Visita();
                visita.IdCliente = int.Parse(txtIdCliente.Text.Trim());
                visita.IdCorretor = int.Parse(txtIdCorretor.Text.Trim());
                visita.IdImovel = int.Parse(txtIdImovel.Text.Trim());
                visita.DataHora = dtpDataHora.Value;
                visita.Status = cmbStatus.Text;
                visita.Observacao = txtObservacao.Text.Trim();

                if (modoEdicao)
                {
                    // veio do grid — faz UPDATE
                    visita.IdVisita = idSelecionado;
                    visitaData.Atualizar(visita);
                    MessageBox.Show("Visita atualizada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // digitado manualmente — faz INSERT
                    visitaData.Inserir(visita);
                    MessageBox.Show("Visita agendada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregarVisitas();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar visita: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            try
            {
                dgvVisitas.DataSource = visitaData.BuscarPorCliente(txtBuscar.Text.Trim());
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
                if (dgvVisitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma visita para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["IdVisita"].Value);
                visitaData.Excluir(id);
                MessageBox.Show("Visita excluída com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarVisitas();
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
            txtIdCliente.Text = "";
            txtIdCorretor.Text = "";
            txtIdImovel.Text = "";
            dtpDataHora.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            txtObservacao.Text = "";
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
        }
    }
}