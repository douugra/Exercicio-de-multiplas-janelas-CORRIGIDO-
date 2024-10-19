using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Compra
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Id do Produto")] public int IdProduto { get; set; }
        [DisplayName("Id do Fornecedor")] public int IdFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal Desconto { get; set; }
        [DisplayName("Data da compra")] public DateTime DataCompra { get; set; }

        public void loadData(string dataString) 
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            IdProduto = int.Parse(data[1]);
            IdFornecedor = int.Parse(data[2]);
            Quantidade = int.Parse(data[3]);
            Desconto = decimal.Parse(data[4]);
            DataCompra = DateTime.Parse(data[5]);
        }

        public override string ToString()
        {
            return $"{Id};{IdProduto};{IdFornecedor};{Quantidade};{Desconto.ToString()};{DataCompra}";
        }
    }
}
