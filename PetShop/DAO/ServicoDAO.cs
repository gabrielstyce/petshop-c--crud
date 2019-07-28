using System;
using System.Data; // para usar o CommandType
using PetShop.MODEL; //Chamar a MODEL
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PetShop.DAO
{
    class ServicoDAO
    {
        //Instancia de MySqlCommand
        private MySqlCommand comando = new MySqlCommand();

        //CADASTRAR SERVIÇO
        public void Cadastrar(Servico servico)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert Into Servico(tipo,porte,valor) values(@tipo,@porte,@valor)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("porte", servico.Porte);
                comando.Parameters.AddWithValue("valor", servico.Valor);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //EDITAR OS SERVIÇOS
        public void Editar(Servico servico)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Servico set tipo=@tipo,porte=@porte,valor=@valor where codserv=@codserv";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codserv", servico.CodServico);
                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("porte", servico.Porte);
                comando.Parameters.AddWithValue("valor", servico.Valor);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR NOME
        public IList<Servico> BuscarPorNome(string tipo)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from Servico where tipo like @nome";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", tipo);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Servico> servicos = new List<Servico>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Servico servico = new Servico();
                        servico.Tipo = (string)dr["tipo"];
                        servico.Porte = (string)dr["porte"];
                        servico.Valor = (decimal)dr["valor"];

                        servicos.Add(servico);
                    }
                }
                else
                {
                    servicos = null;
                }
                return servicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }
    }
}
