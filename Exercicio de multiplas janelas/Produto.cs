using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exercicio_de_multiplas_janelas
{
    public class Produto
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Produto")] public string Nome { get; set; }
        [DisplayName("Nome do Fabricante")] public string Fabricante {  get; set; }
        [DisplayName("Preço de Compra")] public decimal PrecoCompra {  get; set; }
        [DisplayName("Preço de Venda")] public decimal PrecoVenda {  get; set; }

        public void loadData(string dataString)
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            Nome = data[1];
            Fabricante = data[2];
            PrecoCompra = decimal.Parse(data[3]);
            PrecoVenda = decimal.Parse(data[4]);
        }

        public override string ToString()
        {
            return $"{Id};{Nome};{Fabricante};{PrecoCompra};{PrecoVenda}";
        }
    }
}
