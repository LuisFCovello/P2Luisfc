using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static P2Final.frmPedidos;

namespace P2Final
{
    public partial class frmProdutos : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private List<string> arquivosPedidosCliente = new List<string>();
        public frmProdutos()
        {
            InitializeComponent();

            listViewPedidos.View = View.Details;
            listViewPedidos.Columns.Clear();
            listViewPedidos.Columns.Add("Número Pedido", 120);
            listViewPedidos.Columns.Add("Total", 100);

            listViewItens.View = View.Details;
            listViewItens.Columns.Clear();
            listViewItens.Columns.Add("Produto", 150);
            listViewItens.Columns.Add("Quantidade", 80);
            listViewItens.Columns.Add("Preço Unitário", 100);
            listViewItens.Columns.Add("Subtotal", 100);


            listViewPedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged;
        }
        private void listViewPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                string cpf = txtCPF.Text.Trim();

                if (string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Digite o CPF para buscar.");
                    return;
                }

                string pasta = Directory.GetCurrentDirectory();
                arquivosPedidosCliente = Directory.GetFiles(pasta, $"pedidos_{cpf}_*.csv").ToList();

                listViewPedidos.Items.Clear();
                listViewItens.Items.Clear();

                if (arquivosPedidosCliente.Count == 0)
                {
                    MessageBox.Show("Nenhum pedido encontrado para este CPF.");
                    return;
                }

                foreach (var arquivo in arquivosPedidosCliente)
                {
                    string primeiroProduto = "Pedido";

                    try
                    {
                        var primeiraLinha = File.ReadLines(arquivo).FirstOrDefault();
                        if (!string.IsNullOrEmpty(primeiraLinha))
                        {
                            var campos = primeiraLinha.Split(';');
                            if (campos.Length >= 1)
                            {
                                primeiroProduto = campos[0];
                            }
                        }
                    }
                    catch { }

                    ListViewItem item = new ListViewItem(primeiroProduto);
                    item.Tag = arquivo;
                    listViewPedidos.Items.Add(item);
                }
            }
        }

        private void CarregarPedidos(string cpf)
        {

            pedidos.Clear();

            string caminhoArquivo = "pedidos.csv";

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de pedidos não encontrado.");
                return;
            }

            var linhas = File.ReadAllLines(caminhoArquivo);
            var dictPedidos = new Dictionary<string, Pedido>();

            foreach (var linha in linhas)
            {
                var campos = linha.Split(';');

                if (campos.Length < 5)
                    continue;
                string cpfPedido = campos[0].Trim().Replace(".", "").Replace("-", "");
                if (cpfPedido != cpf)
                    continue;

                string numeroPedido = campos[1].Trim();
                string produto = campos[2].Trim();

                if (!int.TryParse(campos[3].Trim(), out int quantidade))
                    continue;

                if (!decimal.TryParse(campos[4].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precoUnit))
                    continue;

                if (!dictPedidos.ContainsKey(numeroPedido))
                {
                    dictPedidos[numeroPedido] = new Pedido
                    {
                        NumeroPedido = numeroPedido,
                        CPFCliente = cpf,
                        Itens = new List<ItemPedido>()
                    };
                }

                dictPedidos[numeroPedido].Itens.Add(new ItemPedido
                {
                    NomeProduto = produto,
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnit
                });
            }

            foreach (var pedido in dictPedidos.Values)
            {
                pedido.CalcularTotal();
            }

            pedidos = dictPedidos.Values.ToList();
        }
        private void PreencherListViewPedidos()
        {
            listViewPedidos.Items.Clear();

            if (pedidos.Count == 0)
            {
                MessageBox.Show("Nenhum pedido encontrado para este CPF.");
                return;
            }

            foreach (var pedido in pedidos)
            {
                var item = new ListViewItem(pedido.NumeroPedido);
                item.SubItems.Add(pedido.Total.ToString("F2"));
                listViewPedidos.Items.Add(item);
            }
        }

        private void listViewPedidos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewPedidos.SelectedIndices.Count == 0)
                return;

            int indiceSelecionado = listViewPedidos.SelectedIndices[0];

            if (indiceSelecionado < 0 || indiceSelecionado >= arquivosPedidosCliente.Count)
                return;

            string caminhoArquivoPedido = arquivosPedidosCliente[indiceSelecionado];

            listViewItens.Items.Clear();

            foreach (var linha in File.ReadAllLines(caminhoArquivoPedido))
            {
                var campos = linha.Split(';');
                if (campos.Length >= 4)
                {
                    string nomeProduto = campos[0];
                    string quantidade = campos[1];
                    string precoUnitario = campos[2];
                    string total = campos[3];

                    ListViewItem item = new ListViewItem(nomeProduto);
                    item.SubItems.Add(quantidade);
                    item.SubItems.Add(precoUnitario);
                    item.SubItems.Add(total);

                    listViewItens.Items.Add(item);
                }
            }
        }
        public class Pedido
        {
            public string CPFCliente { get; set; }
            public string NumeroPedido { get; set; }
            public List<ItemPedido> Itens { get; set; }
            public decimal Total { get; private set; }

            public void CalcularTotal()
            {
                Total = Itens.Sum(i => i.Subtotal);
            }
        }

        public class ItemPedido
        {
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }
            public decimal Subtotal => Quantidade * PrecoUnitario;
        }
    }
}