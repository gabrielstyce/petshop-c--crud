using System;
using System.Data; // para usar o CommandType
using PetShop.MODEL; //Chamar a MODEL
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace PetShop.DAO
{
    class PetsDAO
    {
        private MySqlCommand comando = new MySqlCommand();

        //CADASTRAR PET
        public void Cadastrar(Pet pet)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into pet(codcli,nome,especie,raca,porte,sexo,cor) values(@codcli,@nome,@especie,@raca,@porte,@sexo,@cor)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codcli", pet.Cliente.Codigo);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //EDITAR PET
        public void Editar(Pet pet)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Pet set nome=@nome,especie=@especie,raca=@raca,porte=@porte,sexo=@sexo,cor=@cor where codpet=@codpet";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codcli", pet.Cliente.Codigo);
                comando.Parameters.AddWithValue("@codpet", pet.CodPet);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR PET
        public IList<Pet> Buscar(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select * from Pet where codpet = @id";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Pet> pets = new List<Pet>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pet pet = new Pet();
                        pet.Cliente.Codigo = (int)dr["codcli"];
                        pet.CodPet = (int)dr["codpet"];
                        pet.Nome = (string)dr["nome"];
                        pet.Especie = (string)dr["especie"];
                        pet.Raca = (string)dr["raca"];
                        pet.Porte = (string)dr["porte"];
                        pet.Sexo = (string)dr["sexo"];
                        pet.Cor = (string)dr["cor"];

                        pets.Add(pet);
                    }
                }
                else
                {
                    pets = null;
                }
                return pets;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR DONO
        public IList<Pet> BuscarPorCliente(int id)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from pet where codcli = @codcli";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codcli", id);

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Pet> pets = new List<Pet>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pet pet = new Pet();
                        pet.Cliente.Codigo = (int)dr["codcli"];
                        pet.CodPet = (int)dr["codpet"];
                        pet.Nome = (string)dr["nome"];
                        pet.Cor = (string)dr["cor"];
                        pet.Especie = (string)dr["especie"];
                        pet.Porte = (string)dr["porte"];
                        pet.Raca = (string)dr["raca"];
                        pet.Sexo = (string)dr["sexo"];

                        pets.Add(pet);
                    }
                }
                else
                {
                    pets = null;
                }
                return pets;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }

        //BUSCAR POR NOME DO PET
        public IList<Pet> BuscarPorNome(string nome)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from Pet where nome like @nome";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Pet> pets = new List<Pet>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pet pet = new Pet();
                        pet.Cliente.Codigo = (int)dr["codcli"];
                        pet.CodPet = (int)dr["codpet"];
                        pet.Nome = (string)dr["nome"];
                        pet.Especie = (string)dr["especie"];
                        pet.Raca = (string)dr["raca"];
                        pet.Porte = (string)dr["porte"];
                        pet.Sexo = (string)dr["sexo"];
                        pet.Cor = (string)dr["cor"];

                        pets.Add(pet);
                    }
                }
                else
                {
                    pets = null;
                }
                return pets;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar-se ao banco!" + ex.Message);
            }
        }
    }
}
