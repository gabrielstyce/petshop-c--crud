using System;

namespace PetShop.FORMS.CLIENTES
{
    public partial class ClienteMenu : MetroFramework.Forms.MetroForm
    {
        public ClienteMenu()
        {
            InitializeComponent();
        }

        //BTN NOVA CONSLULTA
        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            buscarCliente1.Visible = false;
            newCliente1.Visible = true;
        }

        //BTN VOLTAR
        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeInit home = new HomeInit();
            home.Show();
            this.Close();
        }

        //BTN BUSCAR CLIENTE
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarCliente1.Visible = true;
            newCliente1.Visible = false;
        }
    }
}
