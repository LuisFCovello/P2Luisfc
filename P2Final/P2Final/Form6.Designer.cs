namespace P2Final
{
    partial class frmProdutos
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
            lblConsulta = new Label();
            txtCPF = new TextBox();
            lblTotalPedido = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            listViewPedidos = new ListView();
            listViewItens = new ListView();
            SuspendLayout();
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Microsoft Sans Serif", 12F);
            lblConsulta.Location = new Point(12, 30);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(51, 20);
            lblConsulta.TabIndex = 0;
            lblConsulta.Text = "label1";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 102);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(178, 23);
            txtCPF.TabIndex = 1;
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotalPedido.Location = new Point(114, 30);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(51, 20);
            lblTotalPedido.TabIndex = 2;
            lblTotalPedido.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Insira o CPF";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(54, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listViewPedidos
            // 
            listViewPedidos.Location = new Point(353, 12);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(435, 245);
            listViewPedidos.TabIndex = 5;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            listViewPedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged_1;
            // 
            // listViewItens
            // 
            listViewItens.Location = new Point(353, 290);
            listViewItens.Name = "listViewItens";
            listViewItens.Size = new Size(435, 245);
            listViewItens.TabIndex = 6;
            listViewItens.UseCompatibleStateImageBehavior = false;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(listViewItens);
            Controls.Add(listViewPedidos);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(lblTotalPedido);
            Controls.Add(txtCPF);
            Controls.Add(lblConsulta);
            Name = "frmProdutos";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsulta;
        private TextBox txtCPF;
        private Label lblTotalPedido;
        private Label label1;
        private Button btnBuscar;
        private ListView listViewPedidos;
        private ListView listViewItens;
    }
}