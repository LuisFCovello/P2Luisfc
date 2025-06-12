namespace P2Final
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLolgin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(41, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(41, 158);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnLolgin
            // 
            btnLolgin.Location = new Point(90, 220);
            btnLolgin.Name = "btnLolgin";
            btnLolgin.Size = new Size(75, 23);
            btnLolgin.TabIndex = 2;
            btnLolgin.Text = "Login";
            btnLolgin.UseVisualStyleBackColor = true;
            btnLolgin.Click += btnLolgin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(41, 63);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(41, 127);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 361);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLolgin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "frmLogin";
            Text = "Form1";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLolgin;
        private Label label1;
        private Label label2;
    }
}
