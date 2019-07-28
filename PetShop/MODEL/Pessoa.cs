using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{

    public class Pessoa //NÂO ESQUECER DE COLOCAR PULIC NA FRENTE DA CLASSE
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string endereco;
        private string cep;
        private string numero;
        private string cidade;
        private string telefone;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public override string ToString()
        {
            return Codigo.ToString();
        }
    }
}
