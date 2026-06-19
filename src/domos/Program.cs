using System;
using System.Windows.Forms;
using domos.forms;

namespace domos
{
    // ponto de entrada do sistema
    // inicia o programa abrindo a tela de login
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // abre o FormLogin como tela inicial do sistema
            Application.Run(new FormLogin());
        }
    }
}