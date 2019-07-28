using System;
using PetShop.DAO;
using PetShop.MODEL;

namespace PetShop.BO
{
    class Cep
    {
        private ConexaoCorreios correios = new ConexaoCorreios();

        public Pessoa BuscarCep(Pessoa pessoa)
        {
            try
            {
                if (pessoa.Cep != "")
                {
                    Pessoa pessoaTemp = correios.BuscarCep(pessoa);
                    return pessoaTemp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
