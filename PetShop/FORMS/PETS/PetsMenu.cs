using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.FORMS.PETS
{
    public partial class PetsMenu : MetroFramework.Forms.MetroForm
    {
        public PetsMenu()
        {
            InitializeComponent();
        }

        private void BtnBuscarConsulta_Click(object sender, EventArgs e)
        {
            buscarPet2.Visible = true;
            newPet2.Visible = false;
        }

        private void BtnNovaConsulta_Click(object sender, EventArgs e)
        {
            buscarPet2.Visible = false;
            newPet2.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeInit home = new HomeInit();
            home.Show();
            this.Close();
        }
    }
}
