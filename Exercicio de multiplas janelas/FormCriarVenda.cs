using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_de_multiplas_janelas
{
    public partial class FormCriarVenda : Form
    {
        BindingList<Cliente> Clientes { get; set; }
        Cliente Cliente { get; set; }
        public int IdCliente { get { return (int)comboBoxCliente.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }

        public FormCriarVenda(BindingList<Cliente> clientes, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Clientes = clientes;
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.DataSource = Clientes;
            comboBoxCliente.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.SelectedIndex = 0;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoUnitario.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
