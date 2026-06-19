using System;
using System.Windows.Forms;
using domos.models;

namespace domos.forms
{
    public partial class FormPrincipalRH : Form
    {
        private RH rhLogado;

        public FormPrincipalRH(RH rh)
        {
            InitializeComponent();
            rhLogado = rh;
            lblBemVindo.Text = "Seja Bem-Vindo, " + rh.Nome;
        }

        private void btnCorretoresClick(object sender, EventArgs e)
        {
            FormCorretor tela = new FormCorretor();
            tela.Show();
        }

        private void btnCadastroRHClick(object sender, EventArgs e)
        {
            FormRH tela = new FormRH();
            tela.Show();
        }

        private void btnComissaoClick(object sender, EventArgs e)
        {
            FormComissao tela = new FormComissao();
            tela.Show();
        }

        private void btnSairClick(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
		
		
		
	
    }
}