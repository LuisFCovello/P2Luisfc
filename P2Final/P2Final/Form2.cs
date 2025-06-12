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
    public partial class frmMenu : Form
    {
        private string usuarioLogado;
        public frmMenu(string usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;

            btnUsuarios.Visible = (usuarioLogado == "ADMIN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmUsuarios(usuarioLogado);
            frmUsuarios.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            var frmPedidos = new frmPedidos();
            frmPedidos.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();
        }
    }
}
