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
    public partial class NewPet : UserControl
    {
        public NewPet()
        {
            InitializeComponent();
        }

        private void NewPet_Load(object sender, EventArgs e)
        {
            this.Size = new Size(798, 329);
        }

        //FUNÇÂO PARA VERIFICAR O PREENCHIMENTO DAS TEXT BOX
        public Boolean Preenche()
        {
            if (txtNome.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Nome' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtCor.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Cor' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtEspecie.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Espécie' não preenchida!", 120, 500);
                return false;
            }
            if (txtPorte.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Porte' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtRaca.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Raça' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtSexo.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Sexo' não esta preenchida!", 120, 500);
                return false;
            }
            else
            {
                return true;
            }
        }

        //BTN CADASTRAR PET
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Preenche() == true)
            {
                try
                {
                    Pet pet = new Pet();
                    PetsBO petsBo = new PetsBO();

                    pet.Cliente.Codigo = Convert.ToInt32(txtDono.Text);
                    pet.Nome = txtNome.Text;
                    pet.Especie = txtEspecie.Text;
                    pet.Raca = txtRaca.Text;
                    pet.Porte = txtPorte.Text;
                    pet.Sexo = txtSexo.Text;
                    pet.Cor = txtCor.Text;

                    petsBo.Cadastrar(pet);
                    MyMessageBox.Show(this, "O pet foi cadastrado com sucesso!", "Pet Cadastrado!");
                }
                catch
                {
                    MyMessageBox.Show(this, "Por favor, preencha todas as caixas corretamente.", "Pet NÃO Cadastrado!");
                }
            }
        }

        //BTN BUSCAR PET
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (buscarCliente2.Visible == true)
            {
                buscarCliente2.Visible = false;
            }
            else
            {
                buscarCliente2.Visible = true;
            }
        }
    }
}
