/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 12:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormProposta
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblIdCorretor = new System.Windows.Forms.Label();
			this.txtIdImovel = new System.Windows.Forms.TextBox();
			this.txtIdCorretor = new System.Windows.Forms.TextBox();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvPropostas = new System.Windows.Forms.DataGridView();
			this.bntRecusar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAprovar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtCondicoes = new System.Windows.Forms.TextBox();
			this.lblCondicoes = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblValor = new System.Windows.Forms.Label();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.lblIdCliente = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnRelatorio = new System.Windows.Forms.Button();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPropostas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(432, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 65;
			this.label1.Text = "ID Imóvel:";
			// 
			// lblIdCorretor
			// 
			this.lblIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdCorretor.Location = new System.Drawing.Point(257, 264);
			this.lblIdCorretor.Name = "lblIdCorretor";
			this.lblIdCorretor.Size = new System.Drawing.Size(137, 21);
			this.lblIdCorretor.TabIndex = 64;
			this.lblIdCorretor.Text = "ID Corretor:";
			// 
			// txtIdImovel
			// 
			this.txtIdImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdImovel.Location = new System.Drawing.Point(432, 288);
			this.txtIdImovel.Name = "txtIdImovel";
			this.txtIdImovel.Size = new System.Drawing.Size(169, 30);
			this.txtIdImovel.TabIndex = 63;
			// 
			// txtIdCorretor
			// 
			this.txtIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCorretor.Location = new System.Drawing.Point(257, 288);
			this.txtIdCorretor.Name = "txtIdCorretor";
			this.txtIdCorretor.Size = new System.Drawing.Size(169, 30);
			this.txtIdCorretor.TabIndex = 62;
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(12, 190);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(88, 30);
			this.lblBuscar.TabIndex = 60;
			this.lblBuscar.Text = "Buscar:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(94, 190);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(488, 30);
			this.txtBuscar.TabIndex = 59;
			// 
			// dgvPropostas
			// 
			this.dgvPropostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPropostas.Location = new System.Drawing.Point(12, 34);
			this.dgvPropostas.Name = "dgvPropostas";
			this.dgvPropostas.RowTemplate.Height = 24;
			this.dgvPropostas.Size = new System.Drawing.Size(658, 150);
			this.dgvPropostas.TabIndex = 58;
			this.dgvPropostas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropostas_CellClick);
			// 
			// bntRecusar
			// 
			this.bntRecusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntRecusar.Location = new System.Drawing.Point(289, 491);
			this.bntRecusar.Name = "bntRecusar";
			this.bntRecusar.Size = new System.Drawing.Size(95, 31);
			this.bntRecusar.TabIndex = 57;
			this.bntRecusar.Text = "Recusar";
			this.bntRecusar.UseVisualStyleBackColor = true;
			this.bntRecusar.Click += new System.EventHandler(this.bntRecusarClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(588, 190);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(82, 30);
			this.btnBuscar.TabIndex = 56;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscarClick);
			// 
			// btnAprovar
			// 
			this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAprovar.Location = new System.Drawing.Point(185, 491);
			this.btnAprovar.Name = "btnAprovar";
			this.btnAprovar.Size = new System.Drawing.Size(98, 31);
			this.btnAprovar.TabIndex = 55;
			this.btnAprovar.Text = "Aprovar";
			this.btnAprovar.UseVisualStyleBackColor = true;
			this.btnAprovar.Click += new System.EventHandler(this.btnAprovarClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(101, 491);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 31);
			this.btnSalvar.TabIndex = 54;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
			// 
			// txtCondicoes
			// 
			this.txtCondicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCondicoes.Location = new System.Drawing.Point(83, 428);
			this.txtCondicoes.Multiline = true;
			this.txtCondicoes.Name = "txtCondicoes";
			this.txtCondicoes.Size = new System.Drawing.Size(518, 48);
			this.txtCondicoes.TabIndex = 53;
			// 
			// lblCondicoes
			// 
			this.lblCondicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCondicoes.Location = new System.Drawing.Point(83, 404);
			this.lblCondicoes.Name = "lblCondicoes";
			this.lblCondicoes.Size = new System.Drawing.Size(311, 33);
			this.lblCondicoes.TabIndex = 52;
			this.lblCondicoes.Text = "Condições de Pagamento:";
			// 
			// lblStatus
			// 
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(338, 335);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(95, 21);
			this.lblStatus.TabIndex = 51;
			this.lblStatus.Text = "Status:";
			// 
			// lblValor
			// 
			this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValor.Location = new System.Drawing.Point(83, 335);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(176, 21);
			this.lblValor.TabIndex = 50;
			this.lblValor.Text = "Valor:";
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCliente.Location = new System.Drawing.Point(83, 288);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.Size = new System.Drawing.Size(169, 30);
			this.txtIdCliente.TabIndex = 49;
			// 
			// lblIdCliente
			// 
			this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdCliente.Location = new System.Drawing.Point(83, 264);
			this.lblIdCliente.Name = "lblIdCliente";
			this.lblIdCliente.Size = new System.Drawing.Size(137, 21);
			this.lblIdCliente.TabIndex = 48;
			this.lblIdCliente.Text = "ID Cliente:";
			// 
			// txtValor
			// 
			this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.Location = new System.Drawing.Point(83, 360);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(253, 30);
			this.txtValor.TabIndex = 67;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(494, 491);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(85, 31);
			this.btnLimpar.TabIndex = 69;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// btnRelatorio
			// 
			this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelatorio.Location = new System.Drawing.Point(390, 491);
			this.btnRelatorio.Name = "btnRelatorio";
			this.btnRelatorio.Size = new System.Drawing.Size(98, 31);
			this.btnRelatorio.TabIndex = 68;
			this.btnRelatorio.Text = "Relatório";
			this.btnRelatorio.UseVisualStyleBackColor = true;
			this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorioClick);
			// 
			// cmbStatus
			// 
			this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Agendado",
									"Confirmada",
									"Cancelada"});
			this.cmbStatus.Location = new System.Drawing.Point(342, 359);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(259, 33);
			this.cmbStatus.TabIndex = 70;
			// 
			// FormProposta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRelatorio);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblIdCorretor);
			this.Controls.Add(this.txtIdImovel);
			this.Controls.Add(this.txtIdCorretor);
			this.Controls.Add(this.lblBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvPropostas);
			this.Controls.Add(this.bntRecusar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnAprovar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtCondicoes);
			this.Controls.Add(this.lblCondicoes);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.txtIdCliente);
			this.Controls.Add(this.lblIdCliente);
			this.Name = "FormProposta";
			this.Text = "FormProposta";
			((System.ComponentModel.ISupportInitialize)(this.dgvPropostas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRelatorio;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label lblIdCliente;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblCondicoes;
		private System.Windows.Forms.TextBox txtCondicoes;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnAprovar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button bntRecusar;
		private System.Windows.Forms.DataGridView dgvPropostas;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox txtIdCorretor;
		private System.Windows.Forms.TextBox txtIdImovel;
		private System.Windows.Forms.Label lblIdCorretor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbStatus;
		
	
	}
}
