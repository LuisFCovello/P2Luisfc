using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2Final
{
    public partial class frmUsuarios : Form
    {
        private string usuarioLogado;
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private string arquivoUsuarios = "usuarios.csv";

        public frmUsuarios(string usuarioLogado)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
            CarregarUsuarios();
            ConfigurarPermissoes();
        }
        private void ConfigurarPermissoes()
        {
            bool isAdmin = (usuarioLogado == "ADMIN");

            btnAdicionar.Enabled = isAdmin;
            btnExcluir.Enabled = isAdmin;

            txtUsuario.Enabled = isAdmin;

            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;

            dgvUsuarios.ReadOnly = true;

            AtualizarGrid();
        }
        private void CarregarUsuarios()
        {
            listaUsuarios.Clear();

            listaUsuarios.Add(new Usuario() { UsuarioNome = "ADMIN", Senha = "123" });

            if (File.Exists(arquivoUsuarios))
            {
                var linhas = File.ReadAllLines(arquivoUsuarios);
                foreach (var linha in linhas)
                {
                    var campos = linha.Split(',');
                    if (campos.Length >= 2)
                    {
                        if (campos[0].ToUpper() != "ADMIN")
                            listaUsuarios.Add(new Usuario() { UsuarioNome = campos[0], Senha = campos[1] });
                    }
                }
            }
        }
        private void SalvarUsuarios()
        {
            var linhas = new List<string>();

            foreach (var u in listaUsuarios)
            {
                if (u.UsuarioNome.ToUpper() != "ADMIN")
                    linhas.Add($"{u.UsuarioNome},{u.Senha}");
            }

            File.WriteAllLines(arquivoUsuarios, linhas);
        }

        private void AtualizarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.Columns["Senha"].Visible = false;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txtUsuario.Text.Trim();
            string novaSenha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(novoUsuario) || string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Informe usuário e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoUsuario.ToUpper() == "ADMIN")
            {
                MessageBox.Show("Usuário ADMIN já existe e não pode ser adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaUsuarios.Exists(u => u.UsuarioNome.Equals(novoUsuario, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Usuário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaUsuarios.Add(new Usuario() { UsuarioNome = novoUsuario, Senha = novaSenha });
            SalvarUsuarios();
            AtualizarGrid();

            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != "ADMIN")
            {
                MessageBox.Show("Apenas o ADMIN pode excluir usuários.", "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioSelecionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

            if (usuarioSelecionado.UsuarioNome.ToUpper() == "ADMIN")
            {
                MessageBox.Show("O usuário ADMIN não pode ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show($"Confirma a exclusão do usuário {usuarioSelecionado.UsuarioNome}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                listaUsuarios.Remove(usuarioSelecionado);
                SalvarUsuarios();
                AtualizarGrid();
            }
        }
private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuarioSelecionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                txtUsuario.Text = usuarioSelecionado.UsuarioNome;
                txtSenha.Clear();

                txtUsuario.Enabled = (usuarioLogado == "ADMIN");
            }
        }


        public class Usuario
        {
            public string UsuarioNome { get; set; }
            public string Senha { get; set; }
        }
    }
}
