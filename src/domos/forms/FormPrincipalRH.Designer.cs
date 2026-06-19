/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 01:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormPrincipalRH
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
			this.btnCorretores = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnComissao = new System.Windows.Forms.Button();
			this.lblBemVindo = new System.Windows.Forms.Label();
			this.btnCadastroRH = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCorretores
			// 
			this.btnCorretores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCorretores.Location = new System.Drawing.Point(216, 187);
			this.btnCorretores.Name = "btnCorretores";
			this.btnCorretores.Size = new System.Drawing.Size(235, 50);
			this.btnCorretores.TabIndex = 0;
			this.btnCorretores.Text = "Gerênciar Corretores";
			this.btnCorretores.UseVisualStyleBackColor = true;
			this.btnCorretores.Click += new System.EventHandler(this.btnCorretoresClick);
			// 
			// btnSair
			// 
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(216, 355);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(235, 50);
			this.btnSair.TabIndex = 1;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSairClick);
			// 
			// btnComissao
			// 
			this.btnComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComissao.Location = new System.Drawing.Point(216, 243);
			this.btnComissao.Name = "btnComissao";
			this.btnComissao.Size = new System.Drawing.Size(235, 50);
			this.btnComissao.TabIndex = 2;
			this.btnComissao.Text = "Calcular Comissão";
			this.btnComissao.UseVisualStyleBackColor = true;
			this.btnComissao.Click += new System.EventHandler(this.btnComissaoClick);
			// 
			// lblBemVindo
			// 
			this.lblBemVindo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBemVindo.Location = new System.Drawing.Point(176, 107);
			this.lblBemVindo.Name = "lblBemVindo";
			this.lblBemVindo.Size = new System.Drawing.Size(303, 32);
			this.lblBemVindo.TabIndex = 3;
			this.lblBemVindo.Text = "Seja Bem-Vindo, ";
			this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCadastroRH
			// 
			this.btnCadastroRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastroRH.Location = new System.Drawing.Point(216, 299);
			this.btnCadastroRH.Name = "btnCadastroRH";
			this.btnCadastroRH.Size = new System.Drawing.Size(235, 50);
			this.btnCadastroRH.TabIndex = 4;
			this.btnCadastroRH.Text = "Gerênciar RH";
			this.btnCadastroRH.UseVisualStyleBackColor = true;
			this.btnCadastroRH.Click += new System.EventHandler(this.btnCadastroRHClick);
			// 
			// FormPrincipalRH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.btnCadastroRH);
			this.Controls.Add(this.lblBemVindo);
			this.Controls.Add(this.btnComissao);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnCorretores);
			this.Name = "FormPrincipalRH";
			this.Text = "FormPrincipalRH";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCadastroRH;
		private System.Windows.Forms.Label lblBemVindo;
		private System.Windows.Forms.Button btnComissao;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnCorretores;
		
		
	}
}
