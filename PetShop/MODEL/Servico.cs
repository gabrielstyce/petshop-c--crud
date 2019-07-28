using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Servico
    {
        private int codServico;
        private string tipo;
        private string porte;
        private decimal valor;

        public int CodServico { get => codServico; set => codServico = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Porte { get => porte; set => porte = value; }
        public decimal Valor { get => valor; set => valor = value; }

        public override string ToString()
        {
            return CodServico.ToString();
        }
    }
}
