using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormImovel : Form
    {
        private ImovelData imovelData = new ImovelData();
        private bool modoEdicao = false;
        private int idSelecionado = 0;
        private string tipoSelecionado = "";

        public FormImovel()
        {
            InitializeComponent();
            CarregarImoveis();
        }

        private void CarregarImoveis()
        {
            dgvImoveis.DataSource = imovelData.Listar();
        }

        // quando clica no grid, preenche os campos e entra em modo edição
        private void dgvImoveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvImoveis.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(linha.Cells["IdImovel"].Value);
                tipoSelecionado = linha.Cells["Tipo"].Value.ToString();

                cmbTipo.Text = tipoSelecionado;
                txtValor.Text = linha.Cells["Valor"].Value.ToString();
                cmbStatus.Text = linha.Cells["Status"].Value.ToString();
                txtQuartos.Text = linha.Cells["QtdQuartos"].Value.ToString();
                cmbGaragem.Text = linha.Cells["PossuiGaragem"].Value.ToString() == "True" ? "Sim" : "Não";
                txtRua.Text = linha.Cells["Rua"].Value.ToString();
                txtNumero.Text = linha.Cells["Numero"].Value.ToString();
                txtBairro.Text = linha.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["Cidade"].Value.ToString();
                txtCep.Text = linha.Cells["Cep"].Value.ToString();

                // preenche campos específicos conforme o tipo do imóvel
                if (tipoSelecionado == "Aluguel")
                {
                    txtTaxaCondominio.Text = linha.Cells["TaxaCondominio"].Value != DBNull.Value
                        ? linha.Cells["TaxaCondominio"].Value.ToString() : "";
                    txtIptu.Text = linha.Cells["IptuMensal"].Value != DBNull.Value
                        ? linha.Cells["IptuMensal"].Value.ToString() : "";
                    txtEscritura.Text = "";
                    cmbFinanciamento.SelectedIndex = -1;
                }
                else
                {
                    txtEscritura.Text = linha.Cells["ValorEscritura"].Value != DBNull.Value
                        ? linha.Cells["ValorEscritura"].Value.ToString() : "";
                    cmbFinanciamento.Text = linha.Cells["AceitaFinanciamento"].Value != DBNull.Value
                        && Convert.ToBoolean(linha.Cells["AceitaFinanciamento"].Value) ? "Sim" : "Não";
                    txtTaxaCondominio.Text = "";
                    txtIptu.Text = "";
                }

                // marca que veio do grid — vai fazer UPDATE
                modoEdicao = true;
            }
        }

        private void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                if (modoEdicao)
                {
                    // veio do grid — faz UPDATE
                    // detecta o tipo e monta o objeto correto
                    if (tipoSelecionado == "Aluguel")
                    {
                        ImovelAluguel imovel = new ImovelAluguel();
                        imovel.IdImovel = idSelecionado;
                        imovel.Valor = double.Parse(txtValor.Text.Trim());
                        imovel.Status = cmbStatus.Text;
                        imovel.QtdQuartos = int.Parse(txtQuartos.Text.Trim());
                        imovel.PossuiGaragem = cmbGaragem.Text == "Sim";
                        imovel.TaxaCondominio = double.Parse(txtTaxaCondominio.Text.Trim());
                        imovel.IptuMensal = double.Parse(txtIptu.Text.Trim());
                        imovelData.Atualizar(imovel);
                    }
                    else
                    {
                        ImovelVenda imovel = new ImovelVenda();
                        imovel.IdImovel = idSelecionado;
                        imovel.Valor = double.Parse(txtValor.Text.Trim());
                        imovel.Status = cmbStatus.Text;
                        imovel.QtdQuartos = int.Parse(txtQuartos.Text.Trim());
                        imovel.PossuiGaragem = cmbGaragem.Text == "Sim";
                        imovel.AceitaFinanciamento = cmbFinanciamento.Text == "Sim";
                        imovel.ValorEscritura = double.Parse(txtEscritura.Text.Trim());
                        imovelData.Atualizar(imovel);
                    }

                    MessageBox.Show("Imóvel atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // digitado manualmente — faz INSERT
                    Endereco endereco = new Endereco();
                    endereco.Rua = txtRua.Text.Trim();
                    endereco.Numero = int.Parse(txtNumero.Text.Trim());
                    endereco.Bairro = txtBairro.Text.Trim();
                    endereco.Cidade = txtCidade.Text.Trim();
                    endereco.Cep = txtCep.Text.Trim();

                    if (cmbTipo.Text == "Aluguel")
                    {
                        ImovelAluguel imovel = new ImovelAluguel();
                        imovel.Tipo = "Aluguel";
                        imovel.Valor = double.Parse(txtValor.Text.Trim());
                        imovel.Status = cmbStatus.Text;
                        imovel.QtdQuartos = int.Parse(txtQuartos.Text.Trim());
                        imovel.PossuiGaragem = cmbGaragem.Text == "Sim";
                        imovel.TaxaCondominio = double.Parse(txtTaxaCondominio.Text.Trim());
                        imovel.IptuMensal = double.Parse(txtIptu.Text.Trim());
                        imovel.Endereco = endereco;
                        imovelData.InserirAluguel(imovel);
                    }
                    else if (cmbTipo.Text == "Venda")
                    {
                        ImovelVenda imovel = new ImovelVenda();
                        imovel.Tipo = "Venda";
                        imovel.Valor = double.Parse(txtValor.Text.Trim());
                        imovel.Status = cmbStatus.Text;
                        imovel.QtdQuartos = int.Parse(txtQuartos.Text.Trim());
                        imovel.PossuiGaragem = cmbGaragem.Text == "Sim";
                        imovel.AceitaFinanciamento = cmbFinanciamento.Text == "Sim";
                        imovel.ValorEscritura = double.Parse(txtEscritura.Text.Trim());
                        imovel.Endereco = endereco;
                        imovelData.InserirVenda(imovel);
                    }
                    else
                    {
                        MessageBox.Show("Selecione o tipo do imóvel.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Imóvel salvo com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregarImoveis();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar imóvel: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarClick(object sender, EventArgs e)
        {
            try
            {
                dgvImoveis.DataSource = imovelData.BuscarPorTipo(txtPesquisar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExcluirClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvImoveis.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um imóvel para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvImoveis.SelectedRows[0].Cells["IdImovel"].Value);
                imovelData.Excluir(id);
                MessageBox.Show("Imóvel excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarImoveis();
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
            cmbTipo.SelectedIndex = -1;
            txtValor.Text = "";
            txtQuartos.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbGaragem.SelectedIndex = -1;
            cmbFinanciamento.SelectedIndex = -1;
            txtTaxaCondominio.Text = "";
            txtIptu.Text = "";
            txtEscritura.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            // reseta o modo de edição ao limpar
            modoEdicao = false;
            idSelecionado = 0;
            tipoSelecionado = "";
        }
    }
}