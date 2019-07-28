using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Atendimento
    {
        private int codAtendimento;
        private DateTime dtHora;
        private string situacao;
        private Pet pet;
        private Servico servico;
        private Funcionario funcionario;

        public Atendimento()
        {
            Pet = new Pet();
            Servico = new Servico();
            Funcionario = new Funcionario();
        }

        public int CodAtendimento { get => codAtendimento; set => codAtendimento = value; }
        public DateTime DtHora { get => dtHora; set => dtHora = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public Pet Pet { get => pet; set => pet = value; }
        public Servico Servico { get => servico; set => servico = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
