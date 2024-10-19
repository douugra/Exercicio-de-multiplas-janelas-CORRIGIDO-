namespace Exercicio_de_multiplas_janelas
{
    partial class FormCriarCompra
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
            buttonOk = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxTotalComDesconto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(176, 209);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(257, 209);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 3;
            label5.Text = "Valor Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 3;
            label6.Text = "Total Com Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 125);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 3;
            label7.Text = "Preço Unitário:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(132, 64);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(200, 23);
            numericUpDownQuantidade.TabIndex = 2;
            numericUpDownQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownDesconto.Location = new Point(132, 93);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(200, 23);
            numericUpDownDesconto.TabIndex = 3;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(132, 6);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(200, 23);
            comboBoxProduto.TabIndex = 0;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(132, 35);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(200, 23);
            comboBoxFornecedor.TabIndex = 1;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.ControlDarkDark;
            textBoxPrecoUnitario.ForeColor = Color.White;
            textBoxPrecoUnitario.Location = new Point(132, 122);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(200, 23);
            textBoxPrecoUnitario.TabIndex = 4;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ControlDarkDark;
            textBoxValorTotal.ForeColor = Color.White;
            textBoxValorTotal.Location = new Point(132, 151);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(200, 23);
            textBoxValorTotal.TabIndex = 5;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = SystemColors.ControlDarkDark;
            textBoxTotalComDesconto.ForeColor = Color.White;
            textBoxTotalComDesconto.Location = new Point(132, 180);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(200, 23);
            textBoxTotalComDesconto.TabIndex = 6;
            // 
            // FormCriarCompra
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(339, 239);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormCriarCompra";
            Text = "FormCriarCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalComDesconto;
    }
}