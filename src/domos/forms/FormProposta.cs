using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormProposta : Form
    {
        private PropostaData propostaData = new PropostaData();
        private bool modoEdicao = false;
        private int idSelecionado = 0;

        public FormProposta()
        {
            InitializeComponent();
            CarregarPropostas();
        }

        private void CarregarPropostas()
        {
            dgvPropostas.DataSource = propostaData.Listar();
        }

        // quando clica no grid, preenche os campos e entra em modo edição
        private void dgvPropostas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvPropostas.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdProposta"].Value);
                txtIdCliente.Text = linha.Cells["IdCliente"].Value.ToString();
                txtIdImovel.Text = linha.Cells["IdImovel"].Value.ToString();
                txtValor.Text = linha.Cells["Valor"].Value.ToString();
                txtCondicoes.Text = linha.Cells["CondicoesPagamento"].Value.ToString();
                cmbStatus.Text = linha.Cells["Status"].Value.ToString();
                // marca que veio do grid — vai fazer UPDATE via aprovar ou recusar
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                // proposta só permite INSERT — não se edita uma proposta, apenas aprova ou recusa
                if (modoEdicao)
                {
                    MessageBox.Show("Para alterar uma proposta use os botões Aprovar ou Recusar.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Proposta proposta = new Proposta();
                proposta.IdCliente = int.Parse(txtIdCliente.Text.Trim());
                proposta.IdImovel = int.Parse(txtIdImovel.Text.Trim());
                proposta.Valor = double.Parse(txtValor.Text.Trim());
                proposta.CondicoesPagamento = txtCondicoes.Text.Trim();
                proposta.Status = "Pendente";
                proposta.DataProposta = DateTime.Now;

                propostaData.Inserir(proposta);
                MessageBox.Show("Proposta registrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarPropostas();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar proposta: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAprovarClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropostas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma proposta para aprovar.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvPropostas.SelectedRows[0].Cells["IdProposta"].Value);
                propostaData.AtualizarStatus(id, "Aceita");
                MessageBox.Show("Proposta aprovada! Status do imóvel atualizado.", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarPropostas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aprovar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntRecusarClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropostas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma proposta para recusar.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvPropostas.SelectedRows[0].Cells["IdProposta"].Value);
                propostaData.AtualizarStatus(id, "Recusada");
                MessageBox.Show("Proposta recusada!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarPropostas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recusar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            try
            {
                dgvPropostas.DataSource = propostaData.BuscarPorStatus(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // gera um relatório em arquivo .txt com todas as propostas
        private void btnRelatorioClick(object sender, EventArgs e)
        {
            try
            {
                var propostas = propostaData.Listar();

                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "Arquivo de texto (*.txt)|*.txt";
                salvar.FileName = "relatorio_propostas_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".txt";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter arquivo = new System.IO.StreamWriter(salvar.FileName))
                    {
                        arquivo.WriteLine("========================================");
                        arquivo.WriteLine("     RELATÓRIO DE PROPOSTAS");
                        arquivo.WriteLine("     Gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        arquivo.WriteLine("========================================");
                        arquivo.WriteLine();

                        int pendentes = 0, aceitas = 0, recusadas = 0;

                        foreach (System.Data.DataRow row in propostas.Rows)
                        {
                            arquivo.WriteLine("ID Proposta: " + row["IdProposta"]);
                            arquivo.WriteLine("ID Cliente:  " + row["IdCliente"]);
                            arquivo.WriteLine("ID Imóvel:   " + row["IdImovel"]);
                            arquivo.WriteLine("Valor:       R$ " + string.Format("{0:F2}", row["Valor"]));
                            arquivo.WriteLine("Status:      " + row["Status"]);
                            arquivo.WriteLine("Data:        " + row["DataProposta"]);
                            arquivo.WriteLine("Condições:   " + row["CondicoesPagamento"]);
                            arquivo.WriteLine("----------------------------------------");

                            if (row["Status"].ToString() == "Pendente") pendentes++;
                            else if (row["Status"].ToString() == "Aceita") aceitas++;
                            else if (row["Status"].ToString() == "Recusada") recusadas++;
                        }

                        arquivo.WriteLine();
                        arquivo.WriteLine("========================================");
                        arquivo.WriteLine("RESUMO:");
                        arquivo.WriteLine("Pendentes:  " + pendentes);
                        arquivo.WriteLine("Aceitas:    " + aceitas);
                        arquivo.WriteLine("Recusadas:  " + recusadas);
                        arquivo.WriteLine("Total:      " + (pendentes + aceitas + recusadas));
                        arquivo.WriteLine("========================================");
                    }

                    MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message, "Erro",
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
            txtIdImovel.Text = "";
            txtValor.Text = "";
            txtCondicoes.Text = "";
            cmbStatus.SelectedIndex = -1;
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
        }
    }
}