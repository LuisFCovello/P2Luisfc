using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace P2Final
{
    public partial class frmPedidos : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Produto> listaProdutos = new List<Produto>();
        private List<ItemPedido> itensPedido = new List<ItemPedido>();
        private string caminhoClientes = "clientes.csv";
        private string caminhoProdutos = "produtos.csv";
        private string caminhoPedidos = "pedidos.csv";
        public frmPedidos()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
            AtualizarComboProdutos();
        }
        private void CarregarClientes()
        {
            if (File.Exists(caminhoClientes))
            {
                foreach (var linha in File.ReadAllLines(caminhoClientes))
                {
                    var campos = linha.Split(';');
                    if (campos.Length >= 2)
                    {
                        listaClientes.Add(new Cliente { Nome = campos[0], CPF = campos[1] });
                    }
                }
            }
        }
        private void CarregarProdutos()
        {
            if (File.Exists(caminhoProdutos))
            {
                foreach (var linha in File.ReadAllLines(caminhoProdutos))
                {
                    var campos = linha.Split(';');
                    if (campos.Length >= 2)
                    {
                        listaProdutos.Add(new Produto
                        {
                            Nome = campos[0],
                            Preco = decimal.Parse(campos[1])
                        });
                    }
                }
            }
        }

        private void AtualizarComboProdutos()
        {

        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            var cliente = listaClientes.FirstOrDefault(c => c.CPF == txtCPFCliente.Text);
            if (cliente != null)
            {
                lblNomeCliente.Text = cliente.Nome;
                CarregarPedidosDoCliente(cliente.CPF);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }
        }
             private void CarregarPedidosDoCliente(string cpf)
        {
            string pasta = Directory.GetCurrentDirectory();
            var arquivos = Directory.GetFiles(pasta, $"pedidos_{cpf}_*.csv");

            if (arquivos.Length == 0)
            {
                MessageBox.Show("Nenhum pedido encontrado para esse cliente.");
                return;
            }

            string caminho = arquivos.OrderByDescending(File.GetLastWriteTime).First();

            itensPedido.Clear();

            foreach (var linha in File.ReadAllLines(caminho))
            {
                var campos = linha.Split(';');
                if (campos.Length >= 4)
                {
                    itensPedido.Add(new ItemPedido
                    {
                        NomeProduto = campos[0],
                        Quantidade = int.Parse(campos[1]),
                        PrecoUnitario = decimal.Parse(campos[2])
                    });
                }
            }

            AtualizarGrid();
            AtualizarTotal();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                    !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                    !decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                    return;
                }

                var item = new ItemPedido
                {
                    NomeProduto = txtNomeProduto.Text,
                    Quantidade = quantidade,
                    PrecoUnitario = preco
                };

                itensPedido.Add(item);
                AtualizarGrid();
                AtualizarTotal();

                txtNomeProduto.Clear();
                txtQuantidade.Clear();
                txtPreco.Clear();
                txtNomeProduto.Focus();
            }
        }
        private void AtualizarGrid()
        {
            dgvItensPedido.DataSource = null;
            dgvItensPedido.DataSource = itensPedido;
        }

        private void AtualizarTotal()
        {
            decimal total = itensPedido.Sum(item => item.Total);
            lblTotalPedido.Text = $"Total do Pedido: R$ {total:N2}";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtCPFCliente.Text))
                {
                    MessageBox.Show("Informe o CPF do cliente!");
                    return;
                }

                if (itensPedido.Count == 0)
                {
                    MessageBox.Show("Nenhum item foi adicionado ao pedido!");
                    return;
                }

                try
                {
                    string nomeArquivo = $"pedidos_{txtCPFCliente.Text}_{DateTime.Now:yyyyMMddHHmmss}.csv";
                    MessageBox.Show("Arquivo que será salvo:\n" + nomeArquivo);

                    using (var writer = new StreamWriter(nomeArquivo, false))
                    {
                        foreach (var item in itensPedido)
                        {
                            writer.WriteLine($"{item.NomeProduto};{item.Quantidade};{item.PrecoUnitario};{item.Total}");
                        }
                    }

                    MessageBox.Show("Pedido salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar pedido: " + ex.Message);
                }
            }
        }
        public class ItemPedido
        {
            public string NomeProduto { get; set; }
            public decimal PrecoUnitario { get; set; }
            public int Quantidade { get; set; }
            public decimal Total => PrecoUnitario * Quantidade;
        }
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvItensPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            var itemSelecionado = (ItemPedido)dgvItensPedido.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"Deseja excluir o item '{itemSelecionado.NomeProduto}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                itensPedido.Remove(itemSelecionado);

                AtualizarGrid();
                AtualizarTotal();

                if (!string.IsNullOrWhiteSpace(txtCPFCliente.Text))
                {
                    var cpf = txtCPFCliente.Text.Trim();
                    var arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), $"pedidos_{cpf}_*.csv");

                    if (arquivos.Length > 0)
                    {
                        string ultimoArquivo = arquivos.OrderByDescending(File.GetLastWriteTime).First();

                        using (var writer = new StreamWriter(ultimoArquivo, false))
                        {
                            foreach (var item in itensPedido)
                            {
                                writer.WriteLine($"{item.NomeProduto};{item.Quantidade};{item.PrecoUnitario};{item.Total}");
                            }
                        }
                    }
                }
            }
        }
    }
}