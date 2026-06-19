/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormVisita
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
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblIdCorretor = new System.Windows.Forms.Label();
			this.txtIdImovel = new System.Windows.Forms.TextBox();
			this.txtIdCorretor = new System.Windows.Forms.TextBox();
			this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvVisitas = new System.Windows.Forms.DataGridView();
			this.bntExcluir = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.lblObservacao = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblTelefoneCliente = new System.Windows.Forms.Label();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.lblIdCliente = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbStatus
			// 
			this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Agendada",
									"Confirmada",
									"Cancelada"});
			this.cmbStatus.Location = new System.Drawing.Point(342, 357);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(259, 33);
			this.cmbStatus.TabIndex = 47;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(432, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 46;
			this.label1.Text = "ID Imóvel:";
			// 
			// lblIdCorretor
			// 
			this.lblIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdCorretor.Location = new System.Drawing.Point(257, 264);
			this.lblIdCorretor.Name = "lblIdCorretor";
			this.lblIdCorretor.Size = new System.Drawing.Size(137, 21);
			this.lblIdCorretor.TabIndex = 45;
			this.lblIdCorretor.Text = "ID Corretor:";
			// 
			// txtIdImovel
			// 
			this.txtIdImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdImovel.Location = new System.Drawing.Point(432, 288);
			this.txtIdImovel.Name = "txtIdImovel";
			this.txtIdImovel.Size = new System.Drawing.Size(169, 30);
			this.txtIdImovel.TabIndex = 44;
			// 
			// txtIdCorretor
			// 
			this.txtIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCorretor.Location = new System.Drawing.Point(257, 288);
			this.txtIdCorretor.Name = "txtIdCorretor";
			this.txtIdCorretor.Size = new System.Drawing.Size(169, 30);
			this.txtIdCorretor.TabIndex = 43;
			// 
			// dtpDataHora
			// 
			this.dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataHora.Location = new System.Drawing.Point(83, 357);
			this.dtpDataHora.Name = "dtpDataHora";
			this.dtpDataHora.Size = new System.Drawing.Size(249, 30);
			this.dtpDataHora.TabIndex = 42;
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(12, 190);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(88, 30);
			this.lblBuscar.TabIndex = 41;
			this.lblBuscar.Text = "Buscar:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(94, 190);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(488, 30);
			this.txtBuscar.TabIndex = 40;
			// 
			// dgvVisitas
			// 
			this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVisitas.Location = new System.Drawing.Point(12, 34);
			this.dgvVisitas.Name = "dgvVisitas";
			this.dgvVisitas.RowTemplate.Height = 24;
			this.dgvVisitas.Size = new System.Drawing.Size(658, 150);
			this.dgvVisitas.TabIndex = 39;
			this.dgvVisitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitas_CellClick);
			// 
			// bntExcluir
			// 
			this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntExcluir.Location = new System.Drawing.Point(385, 488);
			this.bntExcluir.Name = "bntExcluir";
			this.bntExcluir.Size = new System.Drawing.Size(78, 31);
			this.bntExcluir.TabIndex = 38;
			this.bntExcluir.Text = "Excluir";
			this.bntExcluir.UseVisualStyleBackColor = true;
			this.bntExcluir.Click += new System.EventHandler(this.bntExcluirClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(588, 190);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(82, 30);
			this.btnBuscar.TabIndex = 37;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscarClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(294, 488);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(85, 31);
			this.btnLimpar.TabIndex = 36;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(210, 488);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 31);
			this.btnSalvar.TabIndex = 35;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
			// 
			// txtObservacao
			// 
			this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(83, 428);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(518, 48);
			this.txtObservacao.TabIndex = 34;
			// 
			// lblObservacao
			// 
			this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblObservacao.Location = new System.Drawing.Point(83, 404);
			this.lblObservacao.Name = "lblObservacao";
			this.lblObservacao.Size = new System.Drawing.Size(137, 33);
			this.lblObservacao.TabIndex = 33;
			this.lblObservacao.Text = "Observação:";
			// 
			// lblStatus
			// 
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(338, 335);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(95, 21);
			this.lblStatus.TabIndex = 32;
			this.lblStatus.Text = "Status:";
			// 
			// lblTelefoneCliente
			// 
			this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefoneCliente.Location = new System.Drawing.Point(83, 335);
			this.lblTelefoneCliente.Name = "lblTelefoneCliente";
			this.lblTelefoneCliente.Size = new System.Drawing.Size(176, 21);
			this.lblTelefoneCliente.TabIndex = 31;
			this.lblTelefoneCliente.Text = "Data e Hora:";
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCliente.Location = new System.Drawing.Point(83, 288);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.Size = new System.Drawing.Size(169, 30);
			this.txtIdCliente.TabIndex = 30;
			// 
			// lblIdCliente
			// 
			this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdCliente.Location = new System.Drawing.Point(83, 264);
			this.lblIdCliente.Name = "lblIdCliente";
			this.lblIdCliente.Size = new System.Drawing.Size(137, 21);
			this.lblIdCliente.TabIndex = 29;
			this.lblIdCliente.Text = "ID Cliente:";
			// 
			// FormVisita
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblIdCorretor);
			this.Controls.Add(this.txtIdImovel);
			this.Controls.Add(this.txtIdCorretor);
			this.Controls.Add(this.dtpDataHora);
			this.Controls.Add(this.lblBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvVisitas);
			this.Controls.Add(this.bntExcluir);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.lblObservacao);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblTelefoneCliente);
			this.Controls.Add(this.txtIdCliente);
			this.Controls.Add(this.lblIdCliente);
			this.Name = "FormVisita";
			this.Text = "FormVisita";
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblIdCliente;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblObservacao;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.DataGridView dgvVisitas;
		private System.Windows.Forms.DateTimePicker dtpDataHora;
		private System.Windows.Forms.TextBox txtIdCorretor;
		private System.Windows.Forms.TextBox txtIdImovel;
		private System.Windows.Forms.Label lblIdCorretor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label lblTelefoneCliente;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button bntExcluir;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblBuscar;
		
	}
}
