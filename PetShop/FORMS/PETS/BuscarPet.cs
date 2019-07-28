using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.MODEL;

namespace PetShop.FORMS.PETS
{
    public partial class BuscarPet : UserControl
    {
        public BuscarPet()
        {
            InitializeComponent();
        }

        Pet pet = new Pet();

        PetsBO petBo = new PetsBO();

        //BTN BUSCAR PET
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "" || txtNome.Text != "" || txtDono.Text != "")
                {
                    if (txtId.Text != "")
                    {
                        pet.CodPet = Convert.ToInt16(txtId.Text);
                        dtGridPet.DataSource = petBo.Buscar(pet);
                    }
                    else if (txtNome.Text != "")
                    {
                        pet.Nome = txtNome.Text;
                        dtGridPet.DataSource = petBo.BuscarPorNome(pet);
                    }
                    else
                    {
                        pet.Cliente.Codigo = Convert.ToInt16(txtDono.Text);
                        dtGridPet.DataSource = petBo.BuscarPorCliente(pet);
                    }
                }
                else
                {
                    MyMessageBox.Show(this, "Por favor preencha um dos campos de busca!", "Campos de busca vazios!");
                }
            }
            catch
            {
                MyMessageBox.Show(this, "erro ao encontrar pet!", "NÃO ENCONTRADO!");
            }
        }

        //BTN LIMPAR DATAGRID
        private void BtnClear_Click(object sender, EventArgs e)
        {
            dtGridPet.DataSource = null;
        }

        //EDITAR PELO DATAGRID
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show(this, "", "Deseja editar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    pet.CodPet = Convert.ToInt16(dtGridPet.CurrentRow.Cells["codpet"].Value.ToString());
                    pet.Nome = dtGridPet.CurrentRow.Cells["nome"].Value.ToString();
                    pet.Especie = dtGridPet.CurrentRow.Cells["especie"].Value.ToString();
                    pet.Raca = dtGridPet.CurrentRow.Cells["raca"].Value.ToString();
                    pet.Porte = dtGridPet.CurrentRow.Cells["porte"].Value.ToString();
                    pet.Sexo = dtGridPet.CurrentRow.Cells["sexo"].Value.ToString();
                    pet.Cor = dtGridPet.CurrentRow.Cells["cor"].Value.ToString();

                    petBo.Editar(pet);
                }
                catch
                {
                    MyMessageBox.Show(this, "Por favor preencha corretamente e tente novamente.", "NÃO foi possivel editar");
                }
            }
        }
    }
}
