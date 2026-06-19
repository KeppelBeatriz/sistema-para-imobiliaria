using System;
using System.Windows.Forms;
using domos.models;
using domos.data;

namespace domos.forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrarClick(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            // validação básica antes de consultar o banco
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha email e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // primeiro tenta login como RH
                RHData rhData = new RHData();
                RH rh = rhData.Login(email, senha);
                if (rh != null)
                {
                    FormPrincipalRH telaRH = new FormPrincipalRH(rh);
                    telaRH.Show();
                    this.Hide();
                    return;
                }

                // se não for RH, tenta como Corretor
                CorretorData corretorData = new CorretorData();
                Corretor corretor = corretorData.Login(email, senha);
                if (corretor != null)
                {
                    FormPrincipalCorretor telaCorretor = new FormPrincipalCorretor(corretor);
                    telaCorretor.Show();
                    this.Hide();
                    return;
                }

                // se não encontrou nenhum dos dois
                MessageBox.Show("Email ou senha incorretos.", "Acesso negado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
    }
}