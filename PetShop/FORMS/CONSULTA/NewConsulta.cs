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

namespace PetShop.FORMS.CONSULTA
{
    public partial class NewConsulta : UserControl
    {
        public NewConsulta()
        {
            InitializeComponent();
        }
        Atendimento consulta = new Atendimento();
        ConsultaBO consultaBo = new ConsultaBO();

        public Boolean Preencher()
        {
            if (txtData.Text == "")
            {
                return false;
            }
            if (txtServico.Text == "")
            {
                return false;
            }
            if (txtFuncionario.Text == "")
            {
                return false;
            }
            if (txtPet.Text == "")
            {
                return false;
            }
            if (txtSituacao.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TxtData_Enter(object sender, EventArgs e)
        {
            txtData.Text = Convert.ToString(DateTime.Now);
        }

        private void BtnBuscarPet_Click(object sender, EventArgs e)
        {
            buscarPet1.Visible = true;
            newPet1.Visible = false;
            buscarFuncionario1.Visible = false;
            newServico1.Visible = false;
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            buscarPet1.Visible = false;
            newPet1.Visible = true;
            buscarFuncionario1.Visible = false;
            newServico1.Visible = false;
        }

        private void BtnBuscarFunc_Click(object sender, EventArgs e)
        {
            buscarPet1.Visible = false;
            newPet1.Visible = false;
            buscarFuncionario1.Visible = true;
            newServico1.Visible = false;
        }

        private void BtnAddServico_Click(object sender, EventArgs e)
        {
            buscarPet1.Visible = false;
            newPet1.Visible = false;
            buscarFuncionario1.Visible = false;
            newServico1.Visible = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Preencher() == true)
            {
                try
                {
                    consulta.DtHora = Convert.ToDateTime(txtData.Text);
                    consulta.Servico.CodServico = Convert.ToInt32(txtServico.Text);
                    consulta.Situacao = txtSituacao.Text;
                    consulta.Pet.CodPet = Convert.ToInt32(txtPet.Text);
                    consulta.Funcionario.Codigo = Convert.ToInt32(txtFuncionario.Text);

                    consultaBo.Criar(consulta);
                    MyMessageBox.Show(this, "", "CONSULTA CRIADA!");
                }
                catch (Exception ex)
                {
                    MyMessageBox.Show(this, ex.Message, "Dados incorretos");
                }
            }
            else
            {
                MyMessageBox.Show(this, "Preencha todos os campos!", "Campo de busca vazio!", 150, 500);
            }
        }

        private void TxtServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}