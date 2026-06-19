/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 01:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormPrincipalCorretor
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
			this.lblBemVindo = new System.Windows.Forms.Label();
			this.btnVisitas = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnImoveis = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.bntPropostas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblBemVindo
			// 
			this.lblBemVindo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBemVindo.Location = new System.Drawing.Point(197, 105);
			this.lblBemVindo.Name = "lblBemVindo";
			this.lblBemVindo.Size = new System.Drawing.Size(287, 32);
			this.lblBemVindo.TabIndex = 7;
			this.lblBemVindo.Text = "Seja Bem-Vindo, ";
			this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVisitas
			// 
			this.btnVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVisitas.Location = new System.Drawing.Point(224, 291);
			this.btnVisitas.Name = "btnVisitas";
			this.btnVisitas.Size = new System.Drawing.Size(235, 50);
			this.btnVisitas.TabIndex = 6;
			this.btnVisitas.Text = "Visitas";
			this.btnVisitas.UseVisualStyleBackColor = true;
			this.btnVisitas.Click += new System.EventHandler(this.btnVisitasClick);
			// 
			// btnSair
			// 
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(224, 403);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(235, 50);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSairClick);
			// 
			// btnImoveis
			// 
			this.btnImoveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImoveis.Location = new System.Drawing.Point(224, 235);
			this.btnImoveis.Name = "btnImoveis";
			this.btnImoveis.Size = new System.Drawing.Size(235, 50);
			this.btnImoveis.TabIndex = 4;
			this.btnImoveis.Text = "Imóveis";
			this.btnImoveis.UseVisualStyleBackColor = true;
			this.btnImoveis.Click += new System.EventHandler(this.btnImoveisClick);
			// 
			// btnClientes
			// 
			this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.Location = new System.Drawing.Point(224, 179);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(235, 50);
			this.btnClientes.TabIndex = 8;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientesClick);
			// 
			// bntPropostas
			// 
			this.bntPropostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntPropostas.Location = new System.Drawing.Point(224, 347);
			this.bntPropostas.Name = "bntPropostas";
			this.bntPropostas.Size = new System.Drawing.Size(235, 50);
			this.bntPropostas.TabIndex = 9;
			this.bntPropostas.Text = "Propostas";
			this.bntPropostas.UseVisualStyleBackColor = true;
			this.bntPropostas.Click += new System.EventHandler(this.bntPropostas_Click);
			// 
			// FormPrincipalCorretor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.bntPropostas);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.lblBemVindo);
			this.Controls.Add(this.btnVisitas);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnImoveis);
			this.Name = "FormPrincipalCorretor";
			this.Text = "FormPrincipalCorretor";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button bntPropostas;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnImoveis;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnVisitas;
		private System.Windows.Forms.Label lblBemVindo;
		
	}
}
