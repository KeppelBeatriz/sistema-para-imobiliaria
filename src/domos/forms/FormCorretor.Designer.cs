/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 07:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormCorretor
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
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvCorretores = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCPFCliente = new System.Windows.Forms.Label();
			this.lblTelefoneCliente = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNomeCliente = new System.Windows.Forms.Label();
			this.txtCreci = new System.Windows.Forms.TextBox();
			this.lblCreci = new System.Windows.Forms.Label();
			this.txtTaxaComissao = new System.Windows.Forms.TextBox();
			this.lblTaxaComissao = new System.Windows.Forms.Label();
			this.bntExcluir = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCorretores)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(12, 175);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(170, 30);
			this.lblBuscar.TabIndex = 41;
			this.lblBuscar.Text = "Buscar por nome:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(188, 175);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(394, 30);
			this.txtBuscar.TabIndex = 40;
			// 
			// dgvCorretores
			// 
			this.dgvCorretores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCorretores.Location = new System.Drawing.Point(12, 19);
			this.dgvCorretores.Name = "dgvCorretores";
			this.dgvCorretores.RowTemplate.Height = 24;
			this.dgvCorretores.Size = new System.Drawing.Size(658, 150);
			this.dgvCorretores.TabIndex = 39;
			this.dgvCorretores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorretores_CellClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(588, 175);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(82, 30);
			this.btnBuscar.TabIndex = 37;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscarClick);
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(342, 319);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(263, 30);
			this.txtCpf.TabIndex = 34;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(87, 454);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(205, 30);
			this.txtSenha.TabIndex = 33;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(87, 319);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(246, 30);
			this.txtTelefone.TabIndex = 32;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(87, 388);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(518, 30);
			this.txtEmail.TabIndex = 31;
			// 
			// lblSenha
			// 
			this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.Location = new System.Drawing.Point(87, 430);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(137, 21);
			this.lblSenha.TabIndex = 30;
			this.lblSenha.Text = "Senha:";
			// 
			// lblEmail
			// 
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(87, 364);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(95, 21);
			this.lblEmail.TabIndex = 28;
			this.lblEmail.Text = "Email:";
			// 
			// lblCPFCliente
			// 
			this.lblCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPFCliente.Location = new System.Drawing.Point(342, 295);
			this.lblCPFCliente.Name = "lblCPFCliente";
			this.lblCPFCliente.Size = new System.Drawing.Size(95, 21);
			this.lblCPFCliente.TabIndex = 27;
			this.lblCPFCliente.Text = "CPF:";
			// 
			// lblTelefoneCliente
			// 
			this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefoneCliente.Location = new System.Drawing.Point(87, 295);
			this.lblTelefoneCliente.Name = "lblTelefoneCliente";
			this.lblTelefoneCliente.Size = new System.Drawing.Size(105, 21);
			this.lblTelefoneCliente.TabIndex = 26;
			this.lblTelefoneCliente.Text = "Telefone:";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(87, 248);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(518, 30);
			this.txtNome.TabIndex = 25;
			// 
			// lblNomeCliente
			// 
			this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCliente.Location = new System.Drawing.Point(87, 224);
			this.lblNomeCliente.Name = "lblNomeCliente";
			this.lblNomeCliente.Size = new System.Drawing.Size(169, 21);
			this.lblNomeCliente.TabIndex = 24;
			this.lblNomeCliente.Text = "Nome Completo:";
			// 
			// txtCreci
			// 
			this.txtCreci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCreci.Location = new System.Drawing.Point(298, 454);
			this.txtCreci.Name = "txtCreci";
			this.txtCreci.Size = new System.Drawing.Size(149, 30);
			this.txtCreci.TabIndex = 46;
			// 
			// lblCreci
			// 
			this.lblCreci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreci.Location = new System.Drawing.Point(298, 430);
			this.lblCreci.Name = "lblCreci";
			this.lblCreci.Size = new System.Drawing.Size(117, 21);
			this.lblCreci.TabIndex = 45;
			this.lblCreci.Text = "CRECI:";
			// 
			// txtTaxaComissao
			// 
			this.txtTaxaComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaxaComissao.Location = new System.Drawing.Point(453, 454);
			this.txtTaxaComissao.Name = "txtTaxaComissao";
			this.txtTaxaComissao.Size = new System.Drawing.Size(153, 30);
			this.txtTaxaComissao.TabIndex = 48;
			// 
			// lblTaxaComissao
			// 
			this.lblTaxaComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaxaComissao.Location = new System.Drawing.Point(448, 430);
			this.lblTaxaComissao.Name = "lblTaxaComissao";
			this.lblTaxaComissao.Size = new System.Drawing.Size(158, 21);
			this.lblTaxaComissao.TabIndex = 47;
			this.lblTaxaComissao.Text = "Taxa Comissão:";
			// 
			// bntExcluir
			// 
			this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntExcluir.Location = new System.Drawing.Point(389, 505);
			this.bntExcluir.Name = "bntExcluir";
			this.bntExcluir.Size = new System.Drawing.Size(78, 36);
			this.bntExcluir.TabIndex = 65;
			this.bntExcluir.Text = "Excluir";
			this.bntExcluir.UseVisualStyleBackColor = true;
			this.bntExcluir.Click += new System.EventHandler(this.bntExcluirClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(298, 505);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(85, 36);
			this.btnLimpar.TabIndex = 64;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(214, 505);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 36);
			this.btnSalvar.TabIndex = 63;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
			// 
			// FormCorretor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.bntExcluir);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtTaxaComissao);
			this.Controls.Add(this.lblTaxaComissao);
			this.Controls.Add(this.txtCreci);
			this.Controls.Add(this.lblCreci);
			this.Controls.Add(this.lblBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvCorretores);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblCPFCliente);
			this.Controls.Add(this.lblTelefoneCliente);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNomeCliente);
			this.Name = "FormCorretor";
			this.Text = "FormCorretor";
			((System.ComponentModel.ISupportInitialize)(this.dgvCorretores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblTaxaComissao;
		private System.Windows.Forms.TextBox txtTaxaComissao;
		private System.Windows.Forms.Label lblCreci;
		private System.Windows.Forms.TextBox txtCreci;
		private System.Windows.Forms.Label lblNomeCliente;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblTelefoneCliente;
		private System.Windows.Forms.Label lblCPFCliente;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button bntExcluir;
		private System.Windows.Forms.DataGridView dgvCorretores;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblBuscar;
		
		
		
		
	}
}
