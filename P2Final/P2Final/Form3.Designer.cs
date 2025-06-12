namespace P2Final
{
    partial class frmUsuarios
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
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(26, 164);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adcionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(144, 164);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(261, 164);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(26, 108);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(193, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(26, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(193, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 6;
            label2.Text = "Senha";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(356, 19);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(432, 299);
            dgvUsuarios.TabIndex = 7;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(dgvUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Name = "frmUsuarios";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private DataGridView dgvUsuarios;
    }
}