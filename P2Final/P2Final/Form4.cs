using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2Final
{
    public partial class frmClientes : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        private string caminhoArquivo = "clientes.csv";
        public frmClientes()
        {
            InitializeComponent();
            CarregarClientes();
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
        }
        private void CarregarClientes()
        {
            listaClientes.Clear();
            if (File.Exists(caminhoArquivo))
            {
                foreach (var linha in File.ReadAllLines(caminhoArquivo))
                {
                    var campos = linha.Split(';');
                    if (campos.Length >= 11)
                    {
                        listaClientes.Add(new Cliente
                        {
                            Nome = campos[0],
                            CPF = campos[1],
                            Email = campos[2],
                            CEP = campos[3],
                            Logradouro = campos[4],
                            Numero = campos[5],
                            Bairro = campos[6],
                            Cidade = campos[7],
                            Estado = campos[8],
                            Telefone = campos[9],
                            WhatsApp = campos[10]
                        });
                    }
                }
            }
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }



        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            BuscarEndereco(txtCEP.Text);
        }
        private async void BuscarEndereco(string cep)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var endereco = JsonSerializer.Deserialize<ViaCepResponse>(json);

                        if (endereco.erro == true)
                        {
                            MessageBox.Show("CEP não encontrado.");
                            return;
                        }

                        txtLogradouro.Text = endereco.logradouro;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.localidade;
                        txtEstado.Text = endereco.uf;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consultar o CEP.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o endereço: " + ex.Message);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                txtNome.Text = cliente.Nome;
                txtCPF.Text = cliente.CPF;
                txtEmail.Text = cliente.Email;
                txtCEP.Text = cliente.CEP;
                txtLogradouro.Text = cliente.Logradouro;
                txtNumero.Text = cliente.Numero;
                txtBairro.Text = cliente.Bairro;
                txtCidade.Text = cliente.Cidade;
                txtEstado.Text = cliente.Estado;
                txtTelefone.Text = cliente.Telefone;
                txtWhatsApp.Text = cliente.WhatsApp;
            }
        }
        private void SalvarCSV()
        {
            try
            {
                using (var writer = new StreamWriter(caminhoArquivo, false))
                {
                    foreach (var c in listaClientes)
                    {
                        writer.WriteLine($"{c.Nome};{c.CPF};{c.Email};{c.CEP};{c.Logradouro};{c.Numero};{c.Bairro};{c.Cidade};{c.Estado};{c.Telefone};{c.WhatsApp}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cpf = txtCPF.Text;
            listaClientes.RemoveAll(c => c.CPF == cpf);
            SalvarCSV();
            AtualizarGrid();

            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtWhats.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                {
                    var cliente = new Cliente
                    {
                        Nome = txtNome.Text,
                        CPF = txtCPF.Text,
                        Email = txtEmail.Text,
                        CEP = txtCEP.Text,
                        Logradouro = txtLogradouro.Text,
                        Numero = txtNumero.Text,
                        Bairro = txtBairro.Text,
                        Cidade = txtCidade.Text,
                        Estado = txtEstado.Text,
                        Telefone = txtTelefone.Text,
                        WhatsApp = txtWhatsApp.Text
                    };

                    listaClientes.RemoveAll(c => c.CPF == cliente.CPF);
                    listaClientes.Add(cliente);
                    SalvarCSV();
                    AtualizarGrid();

                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtCEP.Clear();
                    txtLogradouro.Clear();
                    txtNumero.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtTelefone.Clear();
                    txtWhats.Clear();
                }

            }
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string WhatsApp { get; set; }
    }

    public class ViaCepResponse
    {
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public bool? erro { get; set; }
    }
}
