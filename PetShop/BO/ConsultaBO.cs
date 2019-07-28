using System;
using PetShop.DAO;
using PetShop.MODEL;
using System.Collections.Generic;

namespace PetShop.BO
{
    class ConsultaBO
    {
        private ConsultaDAO consultaDao = new ConsultaDAO();

        //CRIAR CONSUTLA
        public void Criar(Atendimento atendimento)
        {
            try
            {
                consultaDao.Cadastrar(atendimento);
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dado não suportado! " + ex.Message);
            }
        }

        //BUSCAR POR ID
        public IList<Atendimento> BuscarPorId(Atendimento atendimento)
        {
            try
            {
                if (atendimento.CodAtendimento >= 0)
                {
                    var aTemp = consultaDao.BuscarPorId(atendimento.CodAtendimento);
                    return aTemp;
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

        //BUSCAR POR DATA
        public IList<Atendimento> BuscarPorData(string data)
        {
            try
            {
                if (data != "")
                {
                    var aTemp = consultaDao.BuscarPorData(data.Replace("/", "-"));
                    return aTemp;
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

        //BUSCAR POR FUNCIONÁRIO
        public IList<Atendimento> BuscarPorFuncionario(Atendimento atendimento)
        {
            try
            {
                if (atendimento.Funcionario.Codigo >= 0)
                {
                    var aTemp = consultaDao.BuscarPorFuncionario(atendimento.Funcionario.Codigo);
                    return aTemp;
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

        //BUSCAR POR PET
        public IList<Atendimento> BuscarPorPet(Atendimento atendimento)
        {
            try
            {
                if (atendimento.Pet.CodPet >= 0)
                {
                    var aTemp = consultaDao.BuscarPorPet(atendimento.Pet.CodPet);
                    return aTemp;
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

        //BUSCAR POR SERVICO
        public IList<Atendimento> BuscarPorServico(Atendimento atendimento)
        {
            try
            {
                if (atendimento.Servico.Tipo != "")
                {
                    var aTemp = consultaDao.BuscarPorServico(atendimento.Servico.Tipo);
                    return aTemp;
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
