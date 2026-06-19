/*
 * Created by SharpDevelop.
 * User: henri
 * Date: 19/06/2026
 * Time: 12:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace domos.forms
{
	partial class FormComissao
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
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtValorComissao = new System.Windows.Forms.TextBox();
			this.lblIdCorretor = new System.Windows.Forms.Label();
			this.txtIdCorretor = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblValorPorVenda = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblMsg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(405, 286);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(120, 31);
			this.btnLimpar.TabIndex = 90;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimparClick);
			// 
			// txtValorComissao
			// 
			this.txtValorComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorComissao.Location = new System.Drawing.Point(236, 228);
			this.txtValorComissao.Name = "txtValorComissao";
			this.txtValorComissao.Size = new System.Drawing.Size(350, 30);
			this.txtValorComissao.TabIndex = 88;
			// 
			// lblIdCorretor
			// 
			this.lblIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdCorretor.Location = new System.Drawing.Point(68, 192);
			this.lblIdCorretor.Name = "lblIdCorretor";
			this.lblIdCorretor.Size = new System.Drawing.Size(134, 27);
			this.lblIdCorretor.TabIndex = 85;
			this.lblIdCorretor.Text = "ID Corretor:";
			// 
			// txtIdCorretor
			// 
			this.txtIdCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdCorretor.Location = new System.Drawing.Point(236, 189);
			this.txtIdCorretor.Name = "txtIdCorretor";
			this.txtIdCorretor.Size = new System.Drawing.Size(350, 30);
			this.txtIdCorretor.TabIndex = 83;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(279, 286);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(120, 31);
			this.btnCalcular.TabIndex = 76;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcularClick);
			// 
			// lblValorPorVenda
			// 
			this.lblValorPorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorPorVenda.Location = new System.Drawing.Point(68, 228);
			this.lblValorPorVenda.Name = "lblValorPorVenda";
			this.lblValorPorVenda.Size = new System.Drawing.Size(162, 30);
			this.lblValorPorVenda.TabIndex = 72;
			this.lblValorPorVenda.Text = "Valor por Venda:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(68, 364);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(518, 30);
			this.lblResultado.TabIndex = 91;
			this.lblResultado.Text = "Resultado: R$ 0,00";
			// 
			// lblMsg
			// 
			this.lblMsg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMsg.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMsg.Location = new System.Drawing.Point(220, 73);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(235, 32);
			this.lblMsg.TabIndex = 92;
			this.lblMsg.Text = "Calcular Comissão";
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormComissao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 553);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtValorComissao);
			this.Controls.Add(this.lblIdCorretor);
			this.Controls.Add(this.txtIdCorretor);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblValorPorVenda);
			this.Name = "FormComissao";
			this.Text = "FormComissao";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblValorPorVenda;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtIdCorretor;
		private System.Windows.Forms.Label lblIdCorretor;
		private System.Windows.Forms.TextBox txtValorComissao;
		private System.Windows.Forms.Button btnLimpar;
	}
}
