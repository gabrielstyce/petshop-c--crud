using System;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.MODEL;

namespace PetShop.FORMS.CLIENTES
{
    public partial class BuscarCliente : UserControl
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private Cliente cliente = new Cliente();
        private ClienteBO clienteBo = new ClienteBO();

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        //KEYPRESS CPF
        private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCPF.Text.Length)
                {
                    case 0:
                        txtCPF.Text = "";
                        break;
                    case 3:
                        txtCPF.Text = txtCPF.Text + ".";
                        txtCPF.SelectionStart = 5;
                        break;
                    case 7:
                        txtCPF.Text = txtCPF.Text + ".";
                        txtCPF.SelectionStart = 10;
                        break;
                    case 11:
                        txtCPF.Text = txtCPF.Text + "-";
                        txtCPF.SelectionStart = 15;
                        break;
                }
            }
        }

        //BTN CLEAR DATAGRID
        private void BtnClear_Click(object sender, EventArgs e)
        {
            dtGridCli.DataSource = null;
        }

        //BTN BUSCAR CLIENTE
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtCPF.Text != "")
            {
                try
                {
                    if (txtCPF.Text != "")
                    {
                        cliente.Cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                        dtGridCli.DataSource = clienteBo.BuscarCpf(cliente);
                    }
                    else if (txtNome.Text != "")
                    {
                        cliente.Nome = txtNome.Text;
                        dtGridCli.DataSource = clienteBo.BuscarPorNome(cliente);
                    }
                }
                catch
                {
                    MyMessageBox.Show("Cliente não encontrado!");
                }
            }
            else
            {
                MyMessageBox.Show(this, "Preencha um dos campos de busca!", "Campos de busca VAZIOS!");
            }
        }

        //BTN EDITAR CLIENTE
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show(this, "", "Deseja mesmo editar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cliente.Codigo = Convert.ToInt32(dtGridCli.CurrentRow.Cells["codigo"].Value);
                    cliente.Nome = dtGridCli.CurrentRow.Cells["nome"].Value.ToString();
                    cliente.Cpf = dtGridCli.CurrentRow.Cells["cpf"].Value.ToString();
                    cliente.Cep = dtGridCli.CurrentRow.Cells["cep"].Value.ToString();
                    cliente.Endereco = dtGridCli.CurrentRow.Cells["endereco"].Value.ToString();
                    cliente.Cidade = dtGridCli.CurrentRow.Cells["cidade"].Value.ToString();
                    cliente.Numero = dtGridCli.CurrentRow.Cells["numero"].Value.ToString();
                    cliente.Telefone = dtGridCli.CurrentRow.Cells["telefone"].Value.ToString();
                    cliente.Email = dtGridCli.CurrentRow.Cells["email"].Value.ToString();

                    clienteBo.Editar(cliente);
                }
                catch
                {
                    MyMessageBox.Show(this, "Verifique os campos e complete-os corretamente!.", "Cliente NÃO editado!");
                }
            }
        }
    }
}
