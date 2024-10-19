using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Fornecedor
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("CNPJ")] public string CNPJ { get; set; }
        [DisplayName("Nome da Empresa")] public string NomeEmpresa { get; set; }
        [DisplayName("Nome do Contato")] public string NomeContato { get; set; }
        [DisplayName("Número de Telefone")] public string Telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string Email { get; set; }
        [DisplayName("Endereço Físico")] public string Endereco { get; set; }

        public void loadData(string dataString)
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            CNPJ = data[1];
            NomeEmpresa = data[2];
            NomeContato = data[3];
            Telefone = data[4];
            Email = data[5];
            Endereco = data[6];
        }

        public override string ToString()
        {
            return $"{Id};{CNPJ};{NomeEmpresa};{NomeContato};{Telefone};{Email};{Endereco}";
        }
    }
}
