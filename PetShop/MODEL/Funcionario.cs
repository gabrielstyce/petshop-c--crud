using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Funcionario : Pessoa
    {
        private string carTrabalho;
        private decimal salario;

        public string CarTrabalho { get => carTrabalho; set => carTrabalho = value; }
        public decimal Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return Codigo.ToString();
        }
    }
}
