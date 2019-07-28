using System;
using System.Collections.Generic;
using PetShop.MODEL;
using PetShop.DAO;


namespace PetShop.BO
{
    class FuncionarioBO
    {
        private FuncionarioDAO funcionarioDao = new FuncionarioDAO();

        //CADASTRAR FUNCIONARIO
        public void Cadastrar(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Nome != "" && funcionario.Cpf != "")
                {
                    funcionarioDao.Cadastrar(funcionario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //EDITAR FUNCIONARIO
        public void Editar(Funcionario funcionario)
        {
            try
            {
                funcionarioDao.Editar(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //CALCULAR SALARIO
        public void CalcularSalario(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Codigo > 0)
                {
                    var funTemp = funcionarioDao.CalcularSalario(funcionario.Codigo);
                    funcionario.Nome = funTemp.Nome;
                    funcionario.Salario = funTemp.Salario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado: " + ex.Message);
            }
        }

        //BUSCAR POR CPF
        public void BuscarPorCpf(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Cpf != "")
                {
                    //Armazena o resultado da busca
                    var funcTemp = funcionarioDao.BuscarPorCpf(funcionario.Cpf);
                    funcionario.Nome = funcTemp.Nome;
                    funcionario.Codigo = funcionario.Codigo;
                    funcionario.Cpf = funcionario.Cpf;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //BUSCAR POR ID DE FUNCIONARIO
        public void BuscarPorId(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Codigo > 0)
                {
                    //Armazena o resultado da busca
                    var funcTemp = funcionarioDao.BuscarPorId(funcionario.Codigo);
                    //Preenche os dados do autor;
                    funcionario.Nome = funcTemp.Nome;
                    funcionario.Cpf = funcionario.Cpf;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //BUSCAR POR NOME DO FUNCIONARIO
        public IList<Funcionario> BuscarPorNome(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Nome != "")
                {
                    IList<Funcionario> funcionarioTemp = funcionarioDao.BuscarPorNome(funcionario.Nome);
                    return funcionarioTemp;
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
