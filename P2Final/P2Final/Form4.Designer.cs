namespace P2Final
{
    partial class frmClientes
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
            btnSalvar = new Button();
            btnBuscarCep = new Button();
            btnExcluir = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEstado = new TextBox();
            txtEmail = new TextBox();
            txtCEP = new TextBox();
            txtWhats = new TextBox();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtCPF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtWhatsApp = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(278, 519);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnBuscarCep
            // 
            btnBuscarCep.Location = new Point(359, 519);
            btnBuscarCep.Name = "btnBuscarCep";
            btnBuscarCep.Size = new Size(75, 23);
            btnBuscarCep.TabIndex = 1;
            btnBuscarCep.Text = "Buscar Cep";
            btnBuscarCep.UseVisualStyleBackColor = true;
            btnBuscarCep.Click += btnBuscarCep_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(440, 519);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(55, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(55, 471);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(183, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(55, 423);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(183, 23);
            txtEstado.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(55, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(55, 184);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(183, 23);
            txtCEP.TabIndex = 7;
            // 
            // txtWhats
            // 
            txtWhats.Location = new Point(55, 519);
            txtWhats.Name = "txtWhats";
            txtWhats.Size = new Size(183, 23);
            txtWhats.TabIndex = 8;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(55, 376);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(183, 23);
            txtCidade.TabIndex = 9;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(55, 232);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(183, 23);
            txtLogradouro.TabIndex = 10;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(55, 328);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(183, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(55, 280);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(183, 23);
            txtNumero.TabIndex = 12;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(55, 88);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(183, 23);
            txtCPF.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(55, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 14;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(55, 354);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 15;
            label2.Text = "Cidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(55, 306);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 16;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(51, 162);
            label4.Name = "label4";
            label4.Size = new Size(33, 19);
            label4.TabIndex = 17;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(55, 258);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 18;
            label5.Text = "Número";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.AutoSize = true;
            txtWhatsApp.Font = new Font("Segoe UI", 10F);
            txtWhatsApp.Location = new Point(55, 497);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(73, 19);
            txtWhatsApp.TabIndex = 19;
            txtWhatsApp.Text = "WhatsApp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(55, 401);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 20;
            label7.Text = "Estado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(55, 449);
            label8.Name = "label8";
            label8.Size = new Size(59, 19);
            label8.TabIndex = 21;
            label8.Text = "Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(55, 210);
            label9.Name = "label9";
            label9.Size = new Size(81, 19);
            label9.TabIndex = 22;
            label9.Text = "Logradouro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(55, 114);
            label10.Name = "label10";
            label10.Size = new Size(41, 19);
            label10.TabIndex = 23;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(55, 66);
            label11.Name = "label11";
            label11.Size = new Size(33, 19);
            label11.TabIndex = 24;
            label11.Text = "CPF";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(278, 40);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(785, 390);
            dgvClientes.TabIndex = 25;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 575);
            Controls.Add(dgvClientes);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtWhatsApp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCPF);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCidade);
            Controls.Add(txtWhats);
            Controls.Add(txtCEP);
            Controls.Add(txtEmail);
            Controls.Add(txtEstado);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(btnExcluir);
            Controls.Add(btnBuscarCep);
            Controls.Add(btnSalvar);
            Name = "frmClientes";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnBuscarCep;
        private Button btnExcluir;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEstado;
        private TextBox txtEmail;
        private TextBox txtCEP;
        private TextBox txtWhats;
        private TextBox txtCidade;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtCPF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtWhatsApp;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView dgvClientes;
    }
}