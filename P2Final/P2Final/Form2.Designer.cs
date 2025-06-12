namespace P2Final
{
    partial class frmMenu
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
            btnClientes = new Button();
            btnProdutos = new Button();
            btnPedidos = new Button();
            btnUsuarios = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(65, 59);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(93, 49);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(272, 59);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(93, 49);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(65, 148);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(93, 49);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Cadastro de pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(272, 148);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(93, 49);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Cadastro de Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += button3_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 243);
            Controls.Add(btnUsuarios);
            Controls.Add(btnPedidos);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button btnPedidos;
        private Button btnUsuarios;
    }
}