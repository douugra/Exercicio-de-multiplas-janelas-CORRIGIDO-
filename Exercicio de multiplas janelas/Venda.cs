using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int IdProduto { get; set; }
        [DisplayName("Id do Cliente")] public int IdCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal Desconto { get; set; }
        [DisplayName("Data da compra")] public DateTime DataVenda { get; set; }

        public void loadData(string dataString)
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            IdProduto = int.Parse(data[1]);
            IdCliente = int.Parse(data[2]);
            Quantidade = int.Parse(data[3]);
            Desconto = decimal.Parse(data[4]);
            DataVenda = DateTime.Parse(data[5]);
        }

        public override string ToString()
        {
            return $"{Id};{IdProduto};{IdCliente};{Quantidade};{Desconto.ToString()};{DataVenda}";
        }
    }
}
