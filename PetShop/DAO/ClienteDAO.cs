using System;
using System.Data; // para usar o CommandType
using PetShop.MODEL; //Chamar a MODEL
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace PetShop.DAO
{
    class ClienteDAO
    {
        private MySqlCommand comando = new MySqlCommand();

        //CADASTRAR CLIENTE
        public void Cadastrar(Cliente cliente)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into cliente(nome,cpf,cep,endereco,numero,cidade,telefone,email) " +
                                      "values(@nome,@cpf,@cep,@endereco,@numero,@cidade,@telefone,@email)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", cliente.Codigo);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //EDITAR CLIENTE
        public void Editar(Cliente cliente)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Cliente set nome=@nome,cpf=@cpf,cep=@cep,endereco=@endereco," +
                                      "numero=@numero,cidade=@cidade,telefone=@telefone,email=@email where codcli=@codigo";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", cliente.Codigo);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR CPF DO CLIENTE
        public IList<Cliente> BuscarPorCpf(string cpf)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from Cliente where cpf like @cpf";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cpf", cpf + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Cliente> clientes = new List<Cliente>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Codigo = (int)dr["codcli"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.Cpf = (string)dr["cpf"];
                        cliente.Endereco = (string)dr["endereco"];
                        cliente.Cep = (string)dr["cep"];
                        cliente.Numero = (string)dr["numero"];
                        cliente.Cidade = (string)dr["cidade"];
                        cliente.Telefone = (string)dr["telefone"];
                        cliente.Email = (string)dr["email"];

                        clientes.Add(cliente);
                    }
                }
                else
                {
                    //Retorna o obj nulo
                    clientes = null;
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR NOME DO CLIENTE
        public IList<Cliente> BuscarPorNome(string nome)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from Cliente where nome like @nome";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                //Instancia uma nova lista para os clientes
                IList<Cliente> clientes = new List<Cliente>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //instancia cliente dentro do looping para ser criado um obj para cada elemento da lista
                        Cliente cliente = new Cliente();
                        cliente.Codigo = (int)dr["codcli"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.Cpf = (string)dr["cpf"];
                        cliente.Endereco = (string)dr["endereco"];
                        cliente.Cep = (string)dr["cep"];
                        cliente.Numero = (string)dr["numero"];
                        cliente.Cidade = (string)dr["cidade"];
                        cliente.Telefone = (string)dr["telefone"];
                        cliente.Email = (string)dr["email"];

                        clientes.Add(cliente); //Add na lista clientes os valores encontrados
                    }
                }
                else
                {
                    clientes = null;
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }
    }
}
