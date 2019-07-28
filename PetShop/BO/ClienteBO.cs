using System;
using PetShop.DAO;
using PetShop.MODEL;
using System.Collections.Generic;

namespace PetShop.BO
{
    class ClienteBO
    {
        private ClienteDAO clienteDao = new ClienteDAO();

        //CADASTRAR CLIENTE
        public void Cadastrar(Cliente cliente)
        {
            try
            {
                if (cliente.Nome != "" || cliente.Cpf != "")
                {
                    clienteDao.Cadastrar(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado!" + ex.Message);
            }
        }

        //EDITAR CLIENTE
        public void Editar(Cliente cliente)
        {
            try
            {
                clienteDao.Editar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado!" + ex.Message);
            }
        }

        //BUSCAR POR NOME DO CLIENTE
        public IList<Cliente> BuscarPorNome(Cliente cliente)
        {
            try
            {
                if (cliente.Nome != "")
                {
                    IList<Cliente> clienteTemp = clienteDao.BuscarPorNome(cliente.Nome);
                    return clienteTemp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado!" + ex.Message);
            }
        }

        //BUSCAR POR CPF
        public IList<Cliente> BuscarCpf(Cliente cliente)
        {
            try
            {
                if (cliente.Cpf != "")
                {
                    IList<Cliente> clienteTemp = clienteDao.BuscarPorCpf(cliente.Cpf);
                    return clienteTemp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado!" + ex.Message);
            }
        }
    }
}
