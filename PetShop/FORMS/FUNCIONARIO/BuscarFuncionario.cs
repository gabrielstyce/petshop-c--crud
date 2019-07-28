using System;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.MODEL;

namespace PetShop
{
    public partial class BuscarFuncionario : UserControl
    {
        public BuscarFuncionario()
        {
            InitializeComponent();
        }

        private Funcionario funcionario = new Funcionario();
        private FuncionarioBO funcionarioBo = new FuncionarioBO();

        //BTN BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtFunId.Text != "" || txtCPF.Text != "")
            {
                if (txtFunId.Text != "")
                {
                    funcionario.Codigo = Convert.ToInt32(txtFunId.Text);
                    funcionarioBo.BuscarPorId(funcionario);
                }
                else if (txtCPF.Text != "")
                {
                    funcionario.Cpf = txtCPF.Text.Replace(".","").Replace("-","");
                    funcionarioBo.BuscarPorCpf(funcionario);
                }
                else
                {
                    funcionario.Nome = txtNome.Text;
                }
                if (funcionario != null)
                {
                    dtGridFunc.DataSource = funcionarioBo.BuscarPorNome(funcionario);
                }
                
            }
            else
            {
                MyMessageBox.Show(this, "Verifique os campos e complete-os corretamente!.", "Preencha um dos campos corretamente!");
            }
        }

        //BTN LIMPAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtGridFunc.DataSource = null;
        }

        //KEY PRESS DO FUNCIONARIO ID 
        private void TxtFunId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //KEY PRESS DO CPF
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

        //UPDATE PELO DATA GRID
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show(this, "", "Deseja editar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    funcionario.Codigo = Convert.ToInt32(dtGridFunc.CurrentRow.Cells["codigo"].Value.ToString());
                    funcionario.Nome = dtGridFunc.CurrentRow.Cells["nome"].Value.ToString();
                    funcionario.Cpf = dtGridFunc.CurrentRow.Cells["cpf"].Value.ToString();
                    funcionario.Cep = dtGridFunc.CurrentRow.Cells["cep"].Value.ToString();
                    funcionario.Endereco = dtGridFunc.CurrentRow.Cells["endereco"].Value.ToString();
                    funcionario.Cidade = dtGridFunc.CurrentRow.Cells["cidade"].Value.ToString();
                    funcionario.Numero = dtGridFunc.CurrentRow.Cells["numero"].Value.ToString();
                    funcionario.Telefone = dtGridFunc.CurrentRow.Cells["telefone"].Value.ToString();
                    funcionario.CarTrabalho = dtGridFunc.CurrentRow.Cells["cartrabalho"].Value.ToString();
                    funcionario.Salario = Convert.ToDecimal(dtGridFunc.CurrentRow.Cells["salario"].Value);

                    funcionarioBo.Editar(funcionario);
                }
                catch
                {
                    MyMessageBox.Show(this, "Verifique os campos e complete-os corretamente!.", "NÃO cadastrado!");
                }
            }
        }
    }
}
