using System;
using System.Data; // para usar o CommandType
using PetShop.MODEL; //Chamar a MODEL
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PetShop.DAO
{
    class ConsultaDAO
    {
        //Instancia de MySqlCommand
        private MySqlCommand comando = new MySqlCommand();

        //CRIAR CONSULTA
        public void Cadastrar(Atendimento atendimento)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into atendimento(codserv,codpet,codfunc,datahora,situacao) values(@codserv,@codpet,@codfunc,@datahora,@situacao)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codserv", atendimento.Servico.CodServico);
                comando.Parameters.AddWithValue("@codpet", atendimento.Pet.CodPet);
                comando.Parameters.AddWithValue("@codfunc", atendimento.Funcionario.Codigo);
                comando.Parameters.AddWithValue("@datahora", atendimento.DtHora);
                comando.Parameters.AddWithValue("@situacao", atendimento.Situacao);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco! : " + ex.Message);
            }
        }

        //BUSCAR POR ID DA CONSULTA
        public IList<Atendimento> BuscarPorId(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from atendimento where codatend = @codatend";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codatend", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Atendimento> atendimentos = new List<Atendimento>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Atendimento atendimento = new Atendimento();
                        atendimento.CodAtendimento = (int)dr["codatend"];
                        atendimento.Servico.CodServico = (int)dr["codserv"];
                        atendimento.Pet.CodPet = (int)dr["codpet"];
                        atendimento.Funcionario.Codigo = (int)dr["codfunc"];
                        atendimento.DtHora = (DateTime)dr["datahora"];
                        atendimento.Situacao = (string)dr["situacao"];

                        atendimentos.Add(atendimento);
                    }
                }
                else
                {
                    atendimentos = null;
                }
                return atendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR DATA DA CONSULTA
        public IList<Atendimento> BuscarPorData(string dateTime)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from atendimento where datahora like @datahora";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@datahora", "%" + dateTime + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Atendimento> atendimentos = new List<Atendimento>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Atendimento atendimento = new Atendimento();
                        atendimento.CodAtendimento = (int)dr["codatend"];
                        atendimento.Servico.CodServico = (int)dr["codserv"];
                        atendimento.Pet.CodPet = (int)dr["codpet"];
                        atendimento.Funcionario.Codigo = (int)dr["codfunc"];
                        atendimento.DtHora = (DateTime)dr["datahora"];
                        atendimento.Situacao = (string)dr["situacao"];

                        atendimentos.Add(atendimento);
                    }
                }
                else
                {
                    atendimentos = null;
                }
                return atendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR TIPO DE SERVIÇO
        public IList<Atendimento> BuscarPorServico(string tipo)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from atendimento a inner join servico s on a.codserv = s.codserv where tipo like @tipo";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@tipo", "%" + tipo + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Atendimento> atendimentos = new List<Atendimento>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Atendimento atendimento = new Atendimento();
                        atendimento.CodAtendimento = (int)dr["codatend"];

                        atendimento.Servico.CodServico = (int)dr["codserv"];
                        atendimento.Servico.Tipo = (string)dr["tipo"];
                        atendimento.Servico.Porte = (string)dr["porte"];
                        atendimento.Servico.Valor = (decimal)dr["valor"];

                        atendimento.Pet.CodPet = (int)dr["codpet"];
                        atendimento.Funcionario.Codigo = (int)dr["codfunc"];

                        atendimento.DtHora = (DateTime)dr["datahora"];
                        atendimento.Situacao = (string)dr["situacao"];

                        atendimentos.Add(atendimento);
                    }
                }
                else
                {
                    atendimentos = null;
                }
                return atendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR FUNCIONAIRO
        public IList<Atendimento> BuscarPorFuncionario(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                //comando.CommandText = "Select Ate.codatend, P.nome, Cli.nome, Fun.nome, Ate.datahora, Serv.tipo, Serv.valor, Ate.situacao from atendimento Ate " +
                //                      "Inner Join Servico Serv on Ate.codserv = Serv.codserv " +
                //                      "Inner Join Pet P on P.codpet = Ate.codpet " +
                //                      "Inner Join Cliente Cli on Cli.codcli = P.codcli " +
                //                      "Inner Join Funcionario Fun on Fun.codfunc = Ate.codfunc " +
                //                            "where Fun.nome like  @funcionario";
                comando.CommandText = "select * from atendimento where codfunc = @codfunc";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codfunc", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Atendimento> atendimentos = new List<Atendimento>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Atendimento atendimento = new Atendimento();

                        //atendimento.Servico.Tipo = (string)dr["tipo"];
                        //atendimento.Servico.Porte = (string)dr["Serv.porte"];
                        //atendimento.Servico.Valor = (double)dr["valor"];

                        //atendimento.Pet.Nome = (string)dr["P.nome"];
                        //atendimento.Pet.Porte = (string)dr["P.porte"];

                        //atendimento.Funcionario.Nome = (string)dr["Fun.nome"];

                        atendimento.CodAtendimento = (int)dr["codatend"];
                        atendimento.Servico.CodServico = (int)dr["codserv"];
                        atendimento.Pet.CodPet = (int)dr["codpet"];
                        atendimento.Funcionario.Codigo = (int)dr["codfunc"];
                        atendimento.DtHora = (DateTime)dr["datahora"];
                        atendimento.Situacao = (string)dr["situacao"];

                        atendimentos.Add(atendimento);
                    }
                }
                else
                {
                    atendimentos = null;
                }
                return atendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR PET
        public IList<Atendimento> BuscarPorPet(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from atendimento where codpet = @codpet";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codpet", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Atendimento> atendimentos = new List<Atendimento>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Atendimento atendimento = new Atendimento();
                        atendimento.CodAtendimento = (int)dr["codatend"];
                        atendimento.Servico.CodServico = (int)dr["codserv"];
                        atendimento.Pet.CodPet = (int)dr["codpet"];
                        atendimento.Funcionario.Codigo = (int)dr["codfunc"];
                        atendimento.DtHora = (DateTime)dr["datahora"];
                        atendimento.Situacao = (string)dr["situacao"];

                        atendimentos.Add(atendimento);
                    }
                }
                else
                {
                    atendimentos = null;
                }
                return atendimentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }
    }
}
