/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 08:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormImovel
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCep = new System.Windows.Forms.TextBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.dgvImoveis = new System.Windows.Forms.DataGridView();
			this.bntExcluir = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblRua = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblQuartos = new System.Windows.Forms.Label();
			this.txtQuartos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbGaragem = new System.Windows.Forms.ComboBox();
			this.lblIptu = new System.Windows.Forms.Label();
			this.lblTaxaCondominio = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.txtTaxaCondominio = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtIptu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEscritura = new System.Windows.Forms.TextBox();
			this.lblEstritura = new System.Windows.Forms.Label();
			this.cmbFinanciamento = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCep.Location = new System.Drawing.Point(453, 477);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(150, 30);
			this.txtCep.TabIndex = 69;
			// 
			// lblCep
			// 
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCep.Location = new System.Drawing.Point(453, 453);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(153, 21);
			this.lblCep.TabIndex = 68;
			this.lblCep.Text = "CEP:";
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(298, 477);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(149, 30);
			this.txtCidade.TabIndex = 67;
			// 
			// lblCidade
			// 
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(298, 453);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(117, 21);
			this.lblCidade.TabIndex = 66;
			this.lblCidade.Text = "Cidade:";
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPesquisar.Location = new System.Drawing.Point(12, 175);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(106, 30);
			this.lblPesquisar.TabIndex = 65;
			this.lblPesquisar.Text = "Pesquisar:";
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisar.Location = new System.Drawing.Point(115, 175);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(437, 30);
			this.txtPesquisar.TabIndex = 64;
			// 
			// dgvImoveis
			// 
			this.dgvImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImoveis.Location = new System.Drawing.Point(12, 19);
			this.dgvImoveis.Name = "dgvImoveis";
			this.dgvImoveis.RowTemplate.Height = 24;
			this.dgvImoveis.Size = new System.Drawing.Size(658, 150);
			this.dgvImoveis.TabIndex = 63;
			this.dgvImoveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImoveis_CellClick);
			// 
			// bntExcluir
			// 
			this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntExcluir.Location = new System.Drawing.Point(389, 513);
			this.bntExcluir.Name = "bntExcluir";
			this.bntExcluir.Size = new System.Drawing.Size(78, 29);
			this.bntExcluir.TabIndex = 62;
			this.bntExcluir.Text = "Excluir";
			this.bntExcluir.UseVisualStyleBackColor = true;
			this.bntExcluir.Click += new System.EventHandler(this.bntExcluirClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Location = new System.Drawing.Point(558, 175);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(112, 30);
			this.btnPesquisar.TabIndex = 61;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisarClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(298, 513);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(85, 29);
			this.btnLimpar.TabIndex = 60;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(214, 513);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 29);
			this.btnSalvar.TabIndex = 59;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(87, 477);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(205, 30);
			this.txtBairro.TabIndex = 57;
			// 
			// txtRua
			// 
			this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRua.Location = new System.Drawing.Point(87, 420);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(411, 30);
			this.txtRua.TabIndex = 55;
			// 
			// lblBairro
			// 
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBairro.Location = new System.Drawing.Point(87, 453);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(137, 21);
			this.lblBairro.TabIndex = 54;
			this.lblBairro.Text = "Bairro";
			// 
			// lblRua
			// 
			this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRua.Location = new System.Drawing.Point(87, 396);
			this.lblRua.Name = "lblRua";
			this.lblRua.Size = new System.Drawing.Size(95, 21);
			this.lblRua.TabIndex = 53;
			this.lblRua.Text = "Rua:";
			// 
			// txtValor
			// 
			this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.Location = new System.Drawing.Point(216, 243);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(126, 30);
			this.txtValor.TabIndex = 50;
			// 
			// lblTipo
			// 
			this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipo.Location = new System.Drawing.Point(87, 216);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(121, 21);
			this.lblTipo.TabIndex = 49;
			this.lblTipo.Text = "Tipo:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(504, 420);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(99, 30);
			this.txtNumero.TabIndex = 71;
			// 
			// lblNumero
			// 
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(504, 396);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(102, 21);
			this.lblNumero.TabIndex = 70;
			this.lblNumero.Text = "Número:";
			// 
			// cmbTipo
			// 
			this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"Alugel",
									"Venda"});
			this.cmbTipo.Location = new System.Drawing.Point(87, 240);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(123, 33);
			this.cmbTipo.TabIndex = 72;
			// 
			// lblValor
			// 
			this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValor.Location = new System.Drawing.Point(216, 216);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(126, 21);
			this.lblValor.TabIndex = 73;
			this.lblValor.Text = "Valor:";
			// 
			// lblQuartos
			// 
			this.lblQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuartos.Location = new System.Drawing.Point(348, 216);
			this.lblQuartos.Name = "lblQuartos";
			this.lblQuartos.Size = new System.Drawing.Size(126, 21);
			this.lblQuartos.TabIndex = 75;
			this.lblQuartos.Text = "Quartos:";
			// 
			// txtQuartos
			// 
			this.txtQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuartos.Location = new System.Drawing.Point(348, 243);
			this.txtQuartos.Name = "txtQuartos";
			this.txtQuartos.Size = new System.Drawing.Size(109, 30);
			this.txtQuartos.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(457, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 21);
			this.label1.TabIndex = 77;
			this.label1.Text = "Possui Garagem:";
			// 
			// cmbGaragem
			// 
			this.cmbGaragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGaragem.FormattingEnabled = true;
			this.cmbGaragem.Items.AddRange(new object[] {
									"Sim",
									"Não"});
			this.cmbGaragem.Location = new System.Drawing.Point(463, 243);
			this.cmbGaragem.Name = "cmbGaragem";
			this.cmbGaragem.Size = new System.Drawing.Size(140, 33);
			this.cmbGaragem.TabIndex = 78;
			// 
			// lblIptu
			// 
			this.lblIptu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIptu.Location = new System.Drawing.Point(436, 279);
			this.lblIptu.Name = "lblIptu";
			this.lblIptu.Size = new System.Drawing.Size(167, 21);
			this.lblIptu.TabIndex = 85;
			this.lblIptu.Text = "IPTU Mensal:";
			// 
			// lblTaxaCondominio
			// 
			this.lblTaxaCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaxaCondominio.Location = new System.Drawing.Point(247, 279);
			this.lblTaxaCondominio.Name = "lblTaxaCondominio";
			this.lblTaxaCondominio.Size = new System.Drawing.Size(183, 21);
			this.lblTaxaCondominio.TabIndex = 82;
			this.lblTaxaCondominio.Text = "Taxa Condomínio:";
			// 
			// cmbStatus
			// 
			this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Disponivel",
									"Alugado",
									"Vendido"});
			this.cmbStatus.Location = new System.Drawing.Point(87, 303);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(154, 33);
			this.cmbStatus.TabIndex = 81;
			// 
			// txtTaxaCondominio
			// 
			this.txtTaxaCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaxaCondominio.Location = new System.Drawing.Point(247, 306);
			this.txtTaxaCondominio.Name = "txtTaxaCondominio";
			this.txtTaxaCondominio.Size = new System.Drawing.Size(183, 30);
			this.txtTaxaCondominio.TabIndex = 80;
			// 
			// lblStatus
			// 
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(87, 279);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(121, 21);
			this.lblStatus.TabIndex = 79;
			this.lblStatus.Text = "Status:";
			// 
			// txtIptu
			// 
			this.txtIptu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIptu.Location = new System.Drawing.Point(436, 306);
			this.txtIptu.Name = "txtIptu";
			this.txtIptu.Size = new System.Drawing.Size(167, 30);
			this.txtIptu.TabIndex = 86;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(337, 339);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 21);
			this.label2.TabIndex = 89;
			this.label2.Text = "Aceita Financiamento:\r\n";
			// 
			// txtEscritura
			// 
			this.txtEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEscritura.Location = new System.Drawing.Point(87, 363);
			this.txtEscritura.Name = "txtEscritura";
			this.txtEscritura.Size = new System.Drawing.Size(244, 30);
			this.txtEscritura.TabIndex = 88;
			// 
			// lblEstritura
			// 
			this.lblEstritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstritura.Location = new System.Drawing.Point(87, 339);
			this.lblEstritura.Name = "lblEstritura";
			this.lblEstritura.Size = new System.Drawing.Size(154, 21);
			this.lblEstritura.TabIndex = 87;
			this.lblEstritura.Text = "Valor Escritura:";
			// 
			// cmbFinanciamento
			// 
			this.cmbFinanciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbFinanciamento.FormattingEnabled = true;
			this.cmbFinanciamento.Items.AddRange(new object[] {
									"Sim",
									"Não"});
			this.cmbFinanciamento.Location = new System.Drawing.Point(337, 363);
			this.cmbFinanciamento.Name = "cmbFinanciamento";
			this.cmbFinanciamento.Size = new System.Drawing.Size(266, 33);
			this.cmbFinanciamento.TabIndex = 90;
			// 
			// FormImovel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.cmbFinanciamento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEscritura);
			this.Controls.Add(this.lblEstritura);
			this.Controls.Add(this.txtIptu);
			this.Controls.Add(this.lblIptu);
			this.Controls.Add(this.lblTaxaCondominio);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.txtTaxaCondominio);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.cmbGaragem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblQuartos);
			this.Controls.Add(this.txtQuartos);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.lblCep);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.lblPesquisar);
			this.Controls.Add(this.txtPesquisar);
			this.Controls.Add(this.dgvImoveis);
			this.Controls.Add(this.bntExcluir);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtRua);
			this.Controls.Add(this.lblBairro);
			this.Controls.Add(this.lblRua);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.lblTipo);
			this.Name = "FormImovel";
			this.Text = "FormImovel";
			((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtEscritura;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtTaxaCondominio;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label lblTaxaCondominio;
		private System.Windows.Forms.TextBox txtIptu;
		private System.Windows.Forms.Label lblEstritura;
		private System.Windows.Forms.Label lblIptu;
		private System.Windows.Forms.ComboBox cmbFinanciamento;
		private System.Windows.Forms.ComboBox cmbGaragem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQuartos;
		private System.Windows.Forms.Label lblQuartos;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label lblRua;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button bntExcluir;
		private System.Windows.Forms.DataGridView dgvImoveis;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.TextBox txtCep;
		
	}
}
