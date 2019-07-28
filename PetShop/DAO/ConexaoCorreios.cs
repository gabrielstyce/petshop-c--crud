using System;
using Correios.CEP;

using PetShop.MODEL;
namespace PetShop.DAO
{
    class ConexaoCorreios
    {
        public Pessoa BuscarCep(Pessoa pessoa)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(pessoa.Cep))
                {
                    cepConsulta address = correiosCEP.GetAddress(pessoa.Cep);
                    if (address != null)
                    {
                        pessoa.Cidade = address.Cidade + ", " + address.UF;
                        pessoa.Endereco = address.Rua + ", " + address.Bairro;
                        return pessoa;
                    }
                    else
                    {
                        pessoa = null;
                        return pessoa;
                    }
                }
                else
                {
                    pessoa = null;
                    return pessoa;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("CEP INVÁLIDO" + ex.Message);
            }
        }
    }
}
