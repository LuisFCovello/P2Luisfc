namespace P2Final
{
    partial class frmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeCliente = new Label();
            txtCPFCliente = new TextBox();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalPedido = new Label();
            btnBuscarClientes = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnGravar = new Button();
            dgvItensPedido = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI", 15F);
            lblNomeCliente.Location = new Point(23, 9);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(158, 28);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Coloque seu CPF";
            // 
            // txtCPFCliente
            // 
            txtCPFCliente.Location = new Point(23, 40);
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(193, 23);
            txtCPFCliente.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(23, 118);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(193, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(23, 175);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(193, 23);
            txtPreco.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(23, 228);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(193, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 94);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 151);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 6;
            label3.Text = "Preço da unidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 204);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 7;
            label4.Text = "Quantidade";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Font = new Font("Segoe UI", 12F);
            lblTotalPedido.Location = new Point(23, 254);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(52, 21);
            lblTotalPedido.TabIndex = 8;
            lblTotalPedido.Text = "label5";
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.Location = new Point(23, 314);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(80, 42);
            btnBuscarClientes.TabIndex = 9;
            btnBuscarClientes.Text = "Buscar Cliente";
            btnBuscarClientes.UseVisualStyleBackColor = true;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(109, 314);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(271, 314);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(190, 314);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Location = new Point(255, 22);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.Size = new Size(747, 277);
            dgvItensPedido.TabIndex = 13;
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 429);
            Controls.Add(dgvItensPedido);
            Controls.Add(btnGravar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnBuscarClientes);
            Controls.Add(lblTotalPedido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCPFCliente);
            Controls.Add(lblNomeCliente);
            Name = "frmPedidos";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCliente;
        private TextBox txtCPFCliente;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalPedido;
        private Button btnBuscarClientes;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnGravar;
        private DataGridView dgvItensPedido;
    }
}