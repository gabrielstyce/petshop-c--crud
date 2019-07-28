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
    public partial class FuncionarioMenu : MetroFramework.Forms.MetroForm
    {
        public FuncionarioMenu()
        {
            InitializeComponent();
        }

        //BTN VOLTAR
        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeInit home = new HomeInit();
            home.Show();
            this.Close();
        }

        //BTN CRIAR NOVA CONSULTA
        private void BtnNovaConsulta_Click(object sender, EventArgs e)
        {
            newFunc1.Visible = true;
            buscarFuncionario1.Visible = false;
            calcularSalario1.Visible = false;
        }

        //BTN BUSCAR FUNCIONARIO
        private void BtnBuscarConsulta_Click(object sender, EventArgs e)
        {
            newFunc1.Visible = false;
            buscarFuncionario1.Visible = true;
            calcularSalario1.Visible = false;
        }

        private void FuncionarioMenu_Load(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            calcularSalario1.Visible = true;
            newFunc1.Visible = false;
            buscarFuncionario1.Visible = false;
        }
    }
}
