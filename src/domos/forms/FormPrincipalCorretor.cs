using System;
using System.Windows.Forms;
using domos.models;

namespace domos.forms
{
    public partial class FormPrincipalCorretor : Form
    {
        // guarda o corretor logado para usar nas outras telas
        private Corretor corretorLogado;

        public FormPrincipalCorretor(Corretor corretor)
        {
            InitializeComponent();
            corretorLogado = corretor;
            // mostra o nome de quem está logado
            lblBemVindo.Text = "Seja Bem-Vindo, " + corretor.Nome;
        }

        private void btnClientesClick(object sender, EventArgs e)
        {
            FormCliente tela = new FormCliente();
            tela.Show();
        }

        private void btnImoveisClick(object sender, EventArgs e)
        {
            FormImovel tela = new FormImovel();
            tela.Show();
        }

        private void btnVisitasClick(object sender, EventArgs e)
        {
            FormVisita tela = new FormVisita();
            tela.Show();
        }

        private void bntPropostas_Click(object sender, EventArgs e)
        {
            FormProposta tela = new FormProposta();
            tela.Show();
        }

        private void btnSairClick(object sender, EventArgs e)
        {
            // volta para o login ao sair
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
		
		
    }
}