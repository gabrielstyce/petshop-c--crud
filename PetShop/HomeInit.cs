using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.FORMS.CLIENTES;
using PetShop.FORMS.PETS;

using PetShop.MODEL;

namespace PetShop
{
    public partial class HomeInit : MetroFramework.Forms.MetroForm
    {
        public HomeInit()
        {
            InitializeComponent();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultaMenu consulta = new ConsultaMenu();
            this.Hide();
            consulta.ShowDialog();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioMenu funcionario = new FuncionarioMenu();
            this.Hide();
            funcionario.ShowDialog();
        }

        private void HomeInit_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ClienteMenu cliente = new ClienteMenu();
            this.Hide();
            cliente.ShowDialog();
        }

        private void BtnPets_Click(object sender, EventArgs e)
        {
            PetsMenu pets = new PetsMenu();
            this.Hide();
            pets.ShowDialog();
        }
    }
}
