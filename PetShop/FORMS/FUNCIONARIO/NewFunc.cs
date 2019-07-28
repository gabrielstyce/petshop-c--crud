using System;
using System.Linq;
using System.Windows.Forms;
using PetShop.BO;
using PetShop.MODEL;

namespace PetShop
{
    public partial class NewFunc : UserControl
    {
        public NewFunc()
        {
            InitializeComponent();
        }

        private Cep buscar = new Cep();
        private Pessoa pessoa = new Pessoa();
        private Funcionario funcionario = new Funcionario();
        private FuncionarioBO funcionarioBo = new FuncionarioBO();

        //CONTROLE DE PREENCHIMENTO
        public Boolean Preeche()
        {
            if (txtNome.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Nome' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtCPF.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'CPF' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtCarTrabalho.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Cart. de Trabalho' não esta preenchida!", 120, 550);
                return false;
            }
            if (txtSalario.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Salário' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtCEP.Text == "" || txtCEP.Text.Length < 5)
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'CEP' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtNum.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Número' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtCidade.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Cidade' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtEndereco.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Endereço' não esta preenchida!", 120, 500);
                return false;
            }
            if (txtTel.Text == "")
            {
                MyMessageBox.Show(this, "Por favor! preencha corretamente.", "Caixa 'Telefone' não esta preenchida!", 120, 500);
                return false;
            }
            else
            {
                return true;
            }
        }
        //TXT CPF
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
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

        //TXT CEP
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

        //TXT NUMERO
        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TXT TELEFONE
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

        //TXT CARTEIRA DE TRABALHO
        private void TxtCarTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCarTrabalho.Text.Length)
                {
                    case 0:
                        txtCarTrabalho.Text = "";
                        break;
                    case 3:
                        txtCarTrabalho.Text = txtCarTrabalho.Text + ".";
                        txtCarTrabalho.SelectionStart = 4;
                        break;
                    case 9:
                        txtCarTrabalho.Text = txtCarTrabalho.Text + ".";
                        txtCarTrabalho.SelectionStart = 10;
                        break;
                    case 12:
                        txtCarTrabalho.Text = txtCarTrabalho.Text + "-";
                        txtCarTrabalho.SelectionStart = 13;
                        break;
                }
            }
        }

        //TXT SALARIO
        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtSalario.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void TxtSalario_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtSalario.Text.Length - 1; i++)
            {
                if ((txtSalario.Text[i] >= '0' &&
                    txtSalario.Text[i] <= '9') ||
                    txtSalario.Text[i] == ',')
                {
                    x += txtSalario.Text[i];
                }
            }
            txtSalario.Text = x;
            txtSalario.SelectAll();
        }

        private void TxtSalario_Leave(object sender, EventArgs e)
        {
            txtSalario.Text = Convert.ToDecimal(txtSalario.Text).ToString("C");
        }

        //BTN ADICIONAR FUNCIONARIO
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Preeche() == true)
            {
                try
                {
                    funcionario.Nome = txtNome.Text;
                    funcionario.Cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                    funcionario.Endereco = txtEndereco.Text;
                    funcionario.Cep = txtCEP.Text.Replace("-", "");
                    funcionario.Numero = txtNum.Text;
                    funcionario.Cidade = txtCidade.Text;
                    funcionario.Telefone = txtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                    funcionario.CarTrabalho = txtCarTrabalho.Text.Replace(".", "").Replace("-", "");
                    funcionario.Salario = Convert.ToDecimal(txtSalario.Text.Replace("R$", "").Trim());

                    funcionarioBo.Cadastrar(funcionario);
                    MyMessageBox.Show(this, "O funcionário foi cadastrado com sucesso!.", "Cadastro efetuado!");
                }
                catch
                {
                    MyMessageBox.Show(this, "Não foi possível cadastrar o cliente!.", "Cadastro NÃO efetuado!");
                }
            }
        }

        //BUSCAR CEP
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
