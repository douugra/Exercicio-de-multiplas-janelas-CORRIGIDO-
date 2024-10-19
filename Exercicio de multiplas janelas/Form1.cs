using System.ComponentModel;
using System.Linq;
namespace Exercicio_de_multiplas_janelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> Produtos { get; set; }
        public BindingList<Cliente> Clientes { get; set; }
        public BindingList<Fornecedor> Fornecedores { get; set; }
        public BindingList<Venda> Vendas { get; set; }
        public BindingList<Compra> Compras { get; set; }

        public Form1()
        {
            InitializeComponent();
            Produtos = new BindingList<Produto>();
            Clientes = new BindingList<Cliente>();
            Fornecedores = new BindingList<Fornecedor>();
            Vendas = new BindingList<Venda>();
            Compras = new BindingList<Compra>();

            CarregarDados();

            this.dataGridView1.DataSource = Produtos;

            buttonViewProdutos.Image = Image.FromFile("imagens/produto.png");
            buttonViewClientes.Image = Image.FromFile("imagens/cliente.png");
            buttonViewFornecedores.Image = Image.FromFile("imagens/fornecedor.png");
            buttonViewVendas.Image = Image.FromFile("imagens/venda.png");
            buttonViewCompras.Image = Image.FromFile("imagens/compra.png");
        }

        private const string arquivoProdutos = "produtos.db";
        private const string arquivoClientes = "clients.db";
        private const string arquivoFornecedores = "fornecedores.db";
        private const string arquivoVendas = "vendas.db";
        private const string arquivoCompras = "compras.db";

        public void CarregarDados()
        {
            if (!File.Exists(arquivoProdutos)) File.Create(arquivoProdutos).Close();
            if (!File.Exists(arquivoClientes)) File.Create(arquivoClientes).Close();
            if (!File.Exists(arquivoFornecedores)) File.Create(arquivoFornecedores).Close();
            if (!File.Exists(arquivoVendas)) File.Create(arquivoVendas).Close();
            if (!File.Exists(arquivoCompras)) File.Create(arquivoCompras).Close();

            List<string> LinhasDeDadosProdutos = File.ReadLines(arquivoProdutos).ToList();
            List<string> LinhasDeDadosClientes = File.ReadLines(arquivoClientes).ToList();
            List<string> LinhasDeDadosFornecedores = File.ReadLines(arquivoFornecedores).ToList();
            List<string> LinhasDeDadosVendas = File.ReadLines(arquivoVendas).ToList();
            List<string> LinhasDeDadosCompras = File.ReadLines(arquivoCompras).ToList();

            foreach (string dataLine in LinhasDeDadosProdutos)
            {
                Produto produto = new Produto();
                produto.loadData(dataLine);
                Produtos.Add(produto);
            }

            foreach (string dataLine in LinhasDeDadosClientes) 
            {
                Cliente cliente = new Cliente();
                cliente.loadData(dataLine);
                Clientes.Add(cliente);
            }

            foreach (string dataLine in LinhasDeDadosFornecedores) 
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.loadData(dataLine);
                Fornecedores.Add(fornecedor);
            }

            foreach (string dataLine in LinhasDeDadosVendas) 
            {
                Venda venda = new Venda();
                venda.loadData(dataLine);
                Vendas.Add(venda); 
            }
            foreach (string dataLine in LinhasDeDadosCompras) 
            {
                Compra compra = new Compra();
                compra.loadData(dataLine);
                Compras.Add(compra); 
            }
        }

        public void SalvarDados() 
        {
            List<string> LinhasDeDadosProdutos = new List<string>();
            List<string> LinhasDeDadosClientes = new List<string>();
            List<string> LinhasDeDadosFornecedores = new List<string>();
            List<string> LinhasDeDadosVendas = new List<string>();
            List<string> LinhasDeDadosCompras = new List<string>();

            foreach (Produto produto in Produtos) LinhasDeDadosProdutos.Add(produto.ToString());
            foreach (Cliente cliente in Clientes) LinhasDeDadosClientes.Add(cliente.ToString());
            foreach (Fornecedor fornecedor in Fornecedores) LinhasDeDadosFornecedores.Add(fornecedor.ToString());
            foreach (Venda venda in Vendas) LinhasDeDadosVendas.Add(venda.ToString());
            foreach (Compra compra in Compras) LinhasDeDadosCompras.Add(compra.ToString());

            File.WriteAllLines(arquivoProdutos, LinhasDeDadosProdutos);
            File.WriteAllLines(arquivoClientes, LinhasDeDadosClientes);
            File.WriteAllLines(arquivoFornecedores, LinhasDeDadosFornecedores);
            File.WriteAllLines(arquivoVendas, LinhasDeDadosVendas);
            File.WriteAllLines(arquivoCompras, LinhasDeDadosCompras);
        }

        private void buttonViewProdutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }
        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fcp.Nome;
                produto.Fabricante = fcp.Fabricante;
                produto.PrecoVenda = fcp.PrecoVenda;
                produto.PrecoCompra = fcp.PrecoCompra;

                Produtos.Add(produto);
            }
        }
        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonViewClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;
        }
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormCriarCliente fcc = new FormCriarCliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Nome = fcc.Nome;
                cliente.Endereco = fcc.Endereco;
                cliente.Email = fcc.Email;
                cliente.Telefone = fcc.Telefone;
                Clientes.Add(cliente);
            }
        }
        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonViewVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }
        private void buttonAdicionarVenda_Click(object sender, EventArgs e)
        {
            if (Clientes.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Clientes antes de efetuar uma venda.");
                return;
            }

            if (Produtos.Count == 0)
            {
                MessageBox.Show("Voce Precisa Cadastrar Produtos antes de efetuar uma venda.");
                return;
            }

            FormCriarVenda fcv = new FormCriarVenda(Clientes, Produtos);
            var resultado = fcv.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Venda venda = new Venda();
                if (Vendas.Count == 0) venda.Id = 1;
                else venda.Id = Vendas.Max(x => x.Id) + 1;

                venda.IdProduto = fcv.IdProduto;
                venda.IdCliente = fcv.IdCliente;
                venda.Quantidade = (int)fcv.Quantidade;
                venda.Desconto = fcv.Desconto;
                venda.DataVenda = DateTime.Now;

                Vendas.Add(venda);
            }
        }
        private void buttonRemoverVenda_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Vendas)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Vendas.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonViewFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }
        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            FormCriarFornecedor fcf = new FormCriarFornecedor();
            var resultado = fcf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fcf.NomeEmpresa;
                fornecedor.NomeContato = fcf.NomeContato;
                fornecedor.Endereco = fcf.Endereco;
                fornecedor.Email = fcf.Email;
                fornecedor.Telefone = fcf.Telefone;
                Fornecedores.Add(fornecedor);
            }
        }
        private void buttonRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonViewCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }
        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (Fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (Produtos.Count == 0)
            {
                MessageBox.Show("Voce Precisa Cadastrar Produtos antes de efetuar uma compra.");
                return;
            }

            FormCriarCompra fcc = new FormCriarCompra(Fornecedores, Produtos);
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compras.Count == 0) compra.Id = 1;
                else compra.Id = Compras.Max(x => x.Id) + 1;

                compra.IdProduto = fcc.IdProduto;
                compra.IdFornecedor = fcc.IdFornecedor;
                compra.Quantidade = (int)fcc.Quantidade;
                compra.Desconto = fcc.Desconto;
                compra.DataCompra = DateTime.Now;

                Compras.Add(compra);
            }
        }
        private void buttonRemoverCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Compras)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDados();
        }
    }
}
