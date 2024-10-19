namespace Exercicio_de_multiplas_janelas
{
    partial class Form1
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
            buttonAdicionarProduto = new Button();
            buttonRemoverProduto = new Button();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonViewProdutos = new Button();
            buttonViewClientes = new Button();
            buttonViewVendas = new Button();
            buttonViewFornecedores = new Button();
            buttonViewCompras = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            buttonAdicionarVenda = new Button();
            buttonRemoverVenda = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonRemoverFornecedor = new Button();
            buttonAdicionarCompra = new Button();
            buttonRemoverCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdicionarProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdicionarProduto.ForeColor = Color.FromArgb(0, 64, 0);
            buttonAdicionarProduto.Location = new Point(5, 51);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(150, 23);
            buttonAdicionarProduto.TabIndex = 2;
            buttonAdicionarProduto.Text = "Adicionar Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = false;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonRemoverProduto
            // 
            buttonRemoverProduto.BackColor = Color.FromArgb(192, 255, 192);
            buttonRemoverProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemoverProduto.ForeColor = Color.FromArgb(0, 64, 0);
            buttonRemoverProduto.Location = new Point(5, 74);
            buttonRemoverProduto.Name = "buttonRemoverProduto";
            buttonRemoverProduto.Size = new Size(150, 23);
            buttonRemoverProduto.TabIndex = 3;
            buttonRemoverProduto.Text = "Remover Produto";
            buttonRemoverProduto.UseVisualStyleBackColor = false;
            buttonRemoverProduto.Click += buttonRemoverProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.Location = new Point(5, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.Size = new Size(750, 457);
            dataGridView1.TabIndex = 0;
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.BackColor = Color.FromArgb(192, 255, 192);
            buttonViewProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewProdutos.ForeColor = Color.FromArgb(0, 64, 0);
            buttonViewProdutos.Location = new Point(5, 5);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(150, 46);
            buttonViewProdutos.TabIndex = 1;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewProdutos.UseVisualStyleBackColor = false;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.BackColor = Color.FromArgb(255, 192, 255);
            buttonViewClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewClientes.ForeColor = Color.FromArgb(64, 0, 64);
            buttonViewClientes.Location = new Point(155, 5);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(150, 46);
            buttonViewClientes.TabIndex = 4;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewClientes.UseVisualStyleBackColor = false;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.BackColor = Color.FromArgb(255, 255, 192);
            buttonViewVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewVendas.ForeColor = Color.FromArgb(64, 64, 0);
            buttonViewVendas.Location = new Point(305, 5);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(150, 46);
            buttonViewVendas.TabIndex = 7;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.BackColor = Color.FromArgb(192, 255, 255);
            buttonViewFornecedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewFornecedores.ForeColor = Color.FromArgb(0, 64, 64);
            buttonViewFornecedores.Location = new Point(455, 5);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(150, 46);
            buttonViewFornecedores.TabIndex = 10;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.BackColor = Color.FromArgb(192, 192, 255);
            buttonViewCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewCompras.ForeColor = Color.FromArgb(0, 0, 64);
            buttonViewCompras.Location = new Point(605, 5);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(150, 46);
            buttonViewCompras.TabIndex = 13;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.FromArgb(255, 192, 255);
            buttonAdicionarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdicionarCliente.ForeColor = Color.FromArgb(64, 0, 64);
            buttonAdicionarCliente.Location = new Point(155, 51);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(150, 23);
            buttonAdicionarCliente.TabIndex = 5;
            buttonAdicionarCliente.Text = "Adicionar Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.FromArgb(255, 192, 255);
            buttonRemoverCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemoverCliente.ForeColor = Color.FromArgb(64, 0, 64);
            buttonRemoverCliente.Location = new Point(155, 74);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(150, 23);
            buttonRemoverCliente.TabIndex = 6;
            buttonRemoverCliente.Text = "Remover Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // buttonAdicionarVenda
            // 
            buttonAdicionarVenda.BackColor = Color.FromArgb(255, 255, 192);
            buttonAdicionarVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdicionarVenda.ForeColor = Color.FromArgb(64, 64, 0);
            buttonAdicionarVenda.Location = new Point(305, 51);
            buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            buttonAdicionarVenda.Size = new Size(150, 23);
            buttonAdicionarVenda.TabIndex = 8;
            buttonAdicionarVenda.Text = "Adicionar Venda";
            buttonAdicionarVenda.UseVisualStyleBackColor = false;
            buttonAdicionarVenda.Click += buttonAdicionarVenda_Click;
            // 
            // buttonRemoverVenda
            // 
            buttonRemoverVenda.BackColor = Color.FromArgb(255, 255, 192);
            buttonRemoverVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemoverVenda.ForeColor = Color.FromArgb(64, 64, 0);
            buttonRemoverVenda.Location = new Point(305, 74);
            buttonRemoverVenda.Name = "buttonRemoverVenda";
            buttonRemoverVenda.Size = new Size(150, 23);
            buttonRemoverVenda.TabIndex = 9;
            buttonRemoverVenda.Text = "Remover Venda";
            buttonRemoverVenda.UseVisualStyleBackColor = false;
            buttonRemoverVenda.Click += buttonRemoverVenda_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = Color.FromArgb(192, 255, 255);
            buttonAdicionarFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdicionarFornecedor.ForeColor = Color.FromArgb(0, 64, 64);
            buttonAdicionarFornecedor.Location = new Point(455, 51);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(150, 23);
            buttonAdicionarFornecedor.TabIndex = 11;
            buttonAdicionarFornecedor.Text = "Adicionar Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonRemoverFornecedor
            // 
            buttonRemoverFornecedor.BackColor = Color.FromArgb(192, 255, 255);
            buttonRemoverFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemoverFornecedor.ForeColor = Color.FromArgb(0, 64, 64);
            buttonRemoverFornecedor.Location = new Point(455, 74);
            buttonRemoverFornecedor.Name = "buttonRemoverFornecedor";
            buttonRemoverFornecedor.Size = new Size(150, 23);
            buttonRemoverFornecedor.TabIndex = 12;
            buttonRemoverFornecedor.Text = "Remover Fornecedor";
            buttonRemoverFornecedor.UseVisualStyleBackColor = false;
            buttonRemoverFornecedor.Click += buttonRemoverFornecedor_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = Color.FromArgb(192, 192, 255);
            buttonAdicionarCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdicionarCompra.ForeColor = Color.FromArgb(0, 0, 64);
            buttonAdicionarCompra.Location = new Point(605, 51);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(150, 23);
            buttonAdicionarCompra.TabIndex = 14;
            buttonAdicionarCompra.Text = "Adicionar Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.BackColor = Color.FromArgb(192, 192, 255);
            buttonRemoverCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemoverCompra.ForeColor = Color.FromArgb(0, 0, 64);
            buttonRemoverCompra.Location = new Point(605, 74);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(150, 23);
            buttonRemoverCompra.TabIndex = 15;
            buttonRemoverCompra.Text = "Remover Compra";
            buttonRemoverCompra.UseVisualStyleBackColor = false;
            buttonRemoverCompra.Click += buttonRemoverCompra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 568);
            Controls.Add(buttonViewCompras);
            Controls.Add(buttonViewFornecedores);
            Controls.Add(buttonViewVendas);
            Controls.Add(buttonViewClientes);
            Controls.Add(buttonViewProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemoverCompra);
            Controls.Add(buttonRemoverFornecedor);
            Controls.Add(buttonRemoverVenda);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonRemoverProduto);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonAdicionarVenda);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonAdicionarProduto);
            Name = "Form1";
            Text = "Inventário";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonRemoverProduto;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonViewProdutos;
        private Button buttonViewClientes;
        private Button buttonViewVendas;
        private Button buttonViewFornecedores;
        private Button buttonViewCompras;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
        private Button buttonAdicionarVenda;
        private Button buttonRemoverVenda;
        private Button buttonAdicionarFornecedor;
        private Button buttonRemoverFornecedor;
        private Button buttonAdicionarCompra;
        private Button buttonRemoverCompra;
    }
}
