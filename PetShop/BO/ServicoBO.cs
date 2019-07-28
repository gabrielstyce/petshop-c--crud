using System;
using PetShop.DAO;
using PetShop.MODEL;
using System.Collections.Generic;

namespace PetShop.BO
{
    class ServicoBO
    {
        private ServicoDAO servicoDao = new ServicoDAO();

        //CADASTRAR SERVICO
        public void Cadastrar(Servico servico)
        {
            try
            {
                if (servico.Tipo != "")
                {
                    servicoDao.Cadastrar(servico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //EDITAR SERVICO
        public void Editar(Servico servico)
        {
            try
            {
                if (servico.CodServico > 0)
                {
                    servicoDao.Editar(servico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //BUSCAR SERVICO
        public IList<Servico> BuscarPorNome(Servico servico)
        {
            try
            {
                if (servico.Tipo != "")
                {
                    var servicoTemp = servicoDao.BuscarPorNome(servico.Tipo);
                    return servicoTemp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }
    }
}
