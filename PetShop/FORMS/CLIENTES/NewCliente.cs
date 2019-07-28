using System;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.MODEL;

namespace PetShop.FORMS.CLIENTES
{
    public partial class NewCliente : UserControl
    {
        public NewCliente()
        {
            InitializeComponent();
        }

        private Cep buscar = new Cep();
        private Pessoa pessoa = new Pessoa();
        private Cliente cliente = new Cliente();
        private ClienteBO clienteBo = new ClienteBO();

        //CONTROLE DE PREENCHIMENTO
        public Boolean Preeche()
        {
            if (txtNome.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Nome' não esta preenchida!");
                return false;
            }
            if (txtCPF.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'CPF' não esta preenchida!");
                return false;
            }
            if (txtCEP.Text == "" || txtCEP.Text.Length != 9)
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'CEP' não esta preenchida!");
                return false;
            }
            if (txtNum.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Número' não esta preenchida!");
                return false;
            }
            if (txtCidade.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Cidade' não esta preenchida!");
                return false;
            }
            if (txtEndereco.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Endereço' não esta preenchida!");
                return false;
            }
            if (txtTel.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Telefone' não esta preenchida!");
                return false;
            }
            else
            {
                return true;
            }
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

        //KEYPRESS CEP
        private void TxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCEP.Text.Length)
                {
                    case 0:
                        txtCEP.Text = "";
                        break;
                    case 5:
                        txtCEP.Text = txtCEP.Text + "-";
                        txtCEP.SelectionStart = 6;
                        break;
                }
            }
        }

        //KEYPRESS TELEFONE
        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTel.Text.Length)
                {
                    case 0:
                        txtTel.Text = "(";
                        txtTel.SelectionStart = 1;
                        break;
                    case 4:
                        txtTel.Text = txtTel.Text + ")";
                        txtTel.SelectionStart = 5;
                        break;
                    case 6:
                        txtTel.Text = txtTel.Text + "-";
                        txtTel.SelectionStart = 7;
                        break;
                    case 11:
                        txtTel.Text = txtTel.Text + "-";
                        txtTel.SelectionStart = 12;
                        break;
                }
            }
        }

        //KEYPRESS NUMERO
        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //BTN CADASTRAR
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Preeche() == true)
            {
                try
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Cep = txtCEP.Text.Replace("-", "");
                    cliente.Numero = txtNum.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Telefone = txtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                    cliente.Email = txtEmail.Text;

                    clienteBo.Cadastrar(cliente);
                    MyMessageBox.Show(this, "O cliente foi cadastrado com sucesso!.", "Cadastro efetuado!");
                }
                catch
                {
                    MyMessageBox.Show(this, "Não foi possível cadastrar o cliente!.", "Cadastro NÃO efetuado!");
                }
            }
        }

        //CARREGAR CEP
        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                pessoa.Cep = txtCEP.Text;
                pessoa = buscar.BuscarCep(pessoa);
                txtCidade.Text = pessoa.Cidade;
                txtEndereco.Text = pessoa.Endereco;
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(this, ex.Message, "CEP INVÁLIDO!", 150, 500);
            }
        }
    }
}
