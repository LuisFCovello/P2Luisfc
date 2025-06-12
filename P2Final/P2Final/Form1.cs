using System;
using System.IO;
using System.Windows.Forms;

namespace P2Final
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLolgin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuario == "ADMIN" && senha == "123")
            {
                AbrirMenu(usuario);
                return;
            }

            if (VerificarUsuarioCSV(usuario, senha))
            {
                AbrirMenu(usuario);
                return;
            }

            MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private bool VerificarUsuarioCSV(string usuario, string senha)
        {
            if (!File.Exists("usuarios.csv"))
                return false;

            var linhas = File.ReadAllLines("usuarios.csv");
            foreach (var linha in linhas)
            {
                var campos = linha.Split(',');
                if (campos.Length >= 2)
                {
                    if (campos[0] == usuario && campos[1] == senha)
                        return true;
                }
            }
            return false;
        }

        private void AbrirMenu(string usuario)
        {
            this.Hide();
            var frmMenu = new frmMenu(usuario);
            frmMenu.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
