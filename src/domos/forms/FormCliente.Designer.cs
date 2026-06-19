/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 01:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormCliente
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
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtRenda = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblRenda = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCPFCliente = new System.Windows.Forms.Label();
			this.lblTelefoneCliente = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNomeCliente = new System.Windows.Forms.Label();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.bntExcluir = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(12, 175);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(170, 30);
			this.lblBuscar.TabIndex = 65;
			this.lblBuscar.Text = "Buscar por nome:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(174, 175);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(408, 30);
			this.txtBuscar.TabIndex = 64;
			// 
			// dgvClientes
			// 
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(12, 19);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.RowTemplate.Height = 24;
			this.dgvClientes.Size = new System.Drawing.Size(658, 150);
			this.dgvClientes.TabIndex = 63;
			this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(588, 175);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(82, 30);
			this.btnBuscar.TabIndex = 61;
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
			this.txtCpf.TabIndex = 58;
			// 
			// txtRenda
			// 
			this.txtRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRenda.Location = new System.Drawing.Point(87, 454);
			this.txtRenda.Name = "txtRenda";
			this.txtRenda.Size = new System.Drawing.Size(246, 30);
			this.txtRenda.TabIndex = 57;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(87, 319);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(246, 30);
			this.txtTelefone.TabIndex = 56;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(87, 388);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(518, 30);
			this.txtEmail.TabIndex = 55;
			// 
			// lblRenda
			// 
			this.lblRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRenda.Location = new System.Drawing.Point(87, 430);
			this.lblRenda.Name = "lblRenda";
			this.lblRenda.Size = new System.Drawing.Size(169, 21);
			this.lblRenda.TabIndex = 54;
			this.lblRenda.Text = "Renda Mensal:";
			// 
			// lblEmail
			// 
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(87, 364);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(95, 21);
			this.lblEmail.TabIndex = 53;
			this.lblEmail.Text = "Email:";
			// 
			// lblCPFCliente
			// 
			this.lblCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPFCliente.Location = new System.Drawing.Point(342, 295);
			this.lblCPFCliente.Name = "lblCPFCliente";
			this.lblCPFCliente.Size = new System.Drawing.Size(95, 21);
			this.lblCPFCliente.TabIndex = 52;
			this.lblCPFCliente.Text = "CPF:";
			// 
			// lblTelefoneCliente
			// 
			this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefoneCliente.Location = new System.Drawing.Point(87, 295);
			this.lblTelefoneCliente.Name = "lblTelefoneCliente";
			this.lblTelefoneCliente.Size = new System.Drawing.Size(105, 21);
			this.lblTelefoneCliente.TabIndex = 51;
			this.lblTelefoneCliente.Text = "Telefone:";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(87, 248);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(518, 30);
			this.txtNome.TabIndex = 50;
			// 
			// lblNomeCliente
			// 
			this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCliente.Location = new System.Drawing.Point(87, 224);
			this.lblNomeCliente.Name = "lblNomeCliente";
			this.lblNomeCliente.Size = new System.Drawing.Size(169, 21);
			this.lblNomeCliente.TabIndex = 49;
			this.lblNomeCliente.Text = "Nome Completo:";
			// 
			// lblNascimento
			// 
			this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNascimento.Location = new System.Drawing.Point(342, 430);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(169, 21);
			this.lblNascimento.TabIndex = 66;
			this.lblNascimento.Text = "Data Nascimento:";
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimento.Location = new System.Drawing.Point(342, 454);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(263, 30);
			this.dtpNascimento.TabIndex = 67;
			// 
			// bntExcluir
			// 
			this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntExcluir.Location = new System.Drawing.Point(388, 505);
			this.bntExcluir.Name = "bntExcluir";
			this.bntExcluir.Size = new System.Drawing.Size(78, 36);
			this.bntExcluir.TabIndex = 70;
			this.bntExcluir.Text = "Excluir";
			this.bntExcluir.UseVisualStyleBackColor = true;
			this.bntExcluir.Click += new System.EventHandler(this.bntExcluirClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(297, 505);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(85, 36);
			this.btnLimpar.TabIndex = 69;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(213, 505);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 36);
			this.btnSalvar.TabIndex = 68;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
			// 
			// FormCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.bntExcluir);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.dtpNascimento);
			this.Controls.Add(this.lblNascimento);
			this.Controls.Add(this.lblBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtRenda);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblRenda);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblCPFCliente);
			this.Controls.Add(this.lblTelefoneCliente);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNomeCliente);
			this.Name = "FormCliente";
			this.Text = "FormCliente";
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.Label lblNomeCliente;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblCPFCliente;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblRenda;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtRenda;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button bntExcluir;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblTelefoneCliente;
		
		
	}
}
