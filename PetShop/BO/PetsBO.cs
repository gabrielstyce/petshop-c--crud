using System;
using PetShop.DAO;
using PetShop.MODEL;
using System.Collections.Generic;

namespace PetShop.BO
{
    class PetsBO
    {
        private PetsDAO petDao = new PetsDAO();

        //CADASTRAR PET
        public void Cadastrar(Pet pet)
        {
            try
            {
                if (pet.Cliente.Codigo != 0 && pet.Nome != "")
                {
                    petDao.Cadastrar(pet);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //EDITAR O PET
        public void Editar(Pet pet)
        {
            try
            {
                petDao.Editar(pet);
            }
            catch (Exception ex)
            {
                throw new Exception("Tipo de dados não suportado" + ex.Message);
            }
        }

        //BUSCAR POR ID DO PET
        public IList<Pet> Buscar(Pet pet)
        {
            try
            {
                if (pet.CodPet > 0)
                {
                    var petTemp = petDao.Buscar(pet.CodPet);
                    return petTemp;
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

        //BUSCAR PET POR NOME
        public IList<Pet> BuscarPorNome(Pet pet)
        {
            try
            {
                if (pet.Nome != "")
                {
                    IList<Pet> petTemp = petDao.BuscarPorNome(pet.Nome);
                    return petTemp;
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

        //BUSCAR POR NOME DO CLIENTE/DONO
        public IList<Pet> BuscarPorCliente(Pet pet)
        {
            try
            {
                if (pet.Cliente.Codigo > 0)
                {
                    IList<Pet> clienteTemp = petDao.BuscarPorCliente(pet.Cliente.Codigo);
                    return clienteTemp;
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
