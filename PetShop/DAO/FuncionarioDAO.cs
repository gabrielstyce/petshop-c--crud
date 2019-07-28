using System;
using System.Data; // para usar o CommandType
using PetShop.MODEL; //Chamar a MODEL
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PetShop.DAO
{
    class FuncionarioDAO
    {
        private Funcionario funcionario = new Funcionario();
        private MySqlCommand comando = new MySqlCommand();

        //CADASTRAR FUNCIONARIO
        public void Cadastrar(Funcionario funcionario)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Funcionario(nome,cpf,cep,endereco,numero,cidade,telefone,carttrab,salario)" +
                                      "values(@nome,@cpf,@cep,@endereco,@numero,@cidade,@telefone,@carttrab,@salario)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.CarTrabalho);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //EDITAR FUNCIONARIO
        public void Editar(Funcionario funcionario)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Funcionario set nome=@nome,cpf=@cpf,cep=@cep,endereco=@endereco,numero=@numero,cidade=@cidade,telefone=@telefone,carttrab=@carttrab,salario=@salario " +
                    "where codfunc=@codfunc";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codfunc", funcionario.Codigo);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.CarTrabalho);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //CALCULAR SALARIO
        public Funcionario CalcularSalario(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select f.codfunc, f.nome, " +
                            "round(f.salario * 0.1 * (select count(*) from atendimento a where a.codfunc = f.codfunc) + f.salario)" +
                            " as comissao from funcionario f where f.codfunc = @codfunc";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codfunc", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                if (dr.HasRows)
                {
                    dr.Read();

                    funcionario.Codigo = (int)dr["codfunc"];
                    funcionario.Nome = (string)dr["nome"];
                    funcionario.Salario = (decimal)dr["comissao"];
                }
                else
                {
                    funcionario = null;
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR CPF
        public Funcionario BuscarPorCpf(string cpf)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from Funcionario where cpf like @cpf";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cpf", "%" + cpf + "%");

                //MySqlDataReader retorna uma tabela do db
                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                if (dr.HasRows)
                {
                    dr.Read();
                    funcionario.Codigo = (int)dr["codfunc"];
                    funcionario.Nome = (string)dr["nome"];
                    funcionario.Cpf = (string)dr["cpf"];
                    funcionario.Endereco = (string)dr["endereco"];
                    funcionario.Cep = (string)dr["cep"];
                    funcionario.Numero = (string)dr["numero"];
                    funcionario.Cidade = (string)dr["cidade"];
                    funcionario.Telefone = (string)dr["telefone"];
                    funcionario.CarTrabalho = (string)dr["carttrab"];
                    funcionario.Salario = (decimal)dr["salario"];
                }
                else
                {
                    //Retorna o obj nulo
                    funcionario = null;
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR ID
        public Funcionario BuscarPorId(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from Funcionario where codfunc=@id";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);

                //MySqlDataReader retorna uma tabela do db
                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                if (dr.HasRows)
                {
                    dr.Read();
                    funcionario.Codigo = (int)dr["codfunc"];
                    funcionario.Nome = (string)dr["nome"];
                    funcionario.Cpf = (string)dr["cpf"];
                    funcionario.Endereco = (string)dr["endereco"];
                    funcionario.Cep = (string)dr["cep"];
                    funcionario.Numero = (string)dr["numero"];
                    funcionario.Cidade = (string)dr["cidade"];
                    funcionario.Telefone = (string)dr["telefone"];
                    funcionario.CarTrabalho = (string)dr["carttrab"];
                    funcionario.Salario = (decimal)dr["salario"];
                }
                else
                {
                    //Retorna o obj nulo
                    funcionario = null;
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR NOME
        public IList<Funcionario> BuscarPorNome(string nome)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from Funcionario where nome like @nome";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                //Instancia uma nova lista do funcionario
                IList<Funcionario> funcionarios = new List<Funcionario>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //instancia autor dentro do looping para ser criado um obj para cada elemento da lista
                        Funcionario funcionario = new Funcionario();
                        funcionario.Codigo = (int)dr["codfunc"];
                        funcionario.Nome = (string)dr["nome"];
                        funcionario.Cpf = (string)dr["cpf"];
                        funcionario.Endereco = (string)dr["endereco"];
                        funcionario.Cep = (string)dr["cep"];
                        funcionario.Numero = (string)dr["numero"];
                        funcionario.Cidade = (string)dr["cidade"];
                        funcionario.Telefone = (string)dr["telefone"];
                        funcionario.CarTrabalho = (string)dr["carttrab"];
                        funcionario.Salario = (decimal)dr["salario"];

                        funcionarios.Add(funcionario); //Add na lista funcionarios os valores encontrados.
                    }
                }
                else
                {
                    funcionarios = null;
                }
                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }
    }
}
