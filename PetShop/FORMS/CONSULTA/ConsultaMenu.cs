using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ConsultaMenu : MetroFramework.Forms.MetroForm
    {
        public ConsultaMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeInit home = new HomeInit();
            home.Show();
            this.Close();
        }

        private void BtnNovaConsulta_Click(object sender, EventArgs e)
        {
            newConsulta1.Visible = true;
            buscarConsulta1.Visible = false;
        }

        private void BtnBuscarConsulta_Click(object sender, EventArgs e)
        {
            newConsulta1.Visible = false;
            buscarConsulta1.Visible = true;
        }
    }
}
