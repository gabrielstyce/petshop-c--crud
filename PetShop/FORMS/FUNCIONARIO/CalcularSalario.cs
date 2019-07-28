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

namespace PetShop.FORMS.FUNCIONARIO
{
    public partial class CalcularSalario : UserControl
    {
        public CalcularSalario()
        {
            InitializeComponent();
        }

        private Funcionario funcionario = new Funcionario();
        private FuncionarioBO funcionarioBo = new FuncionarioBO();

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFunId.Text != "")
            {
                funcionario.Codigo = Convert.ToInt32(txtFunId.Text);

                funcionarioBo.CalcularSalario(funcionario);

                txtNome.Text = funcionario.Nome;
                txtSalario.Text = funcionario.Salario.ToString("C");
            }
        }

        private void TxtFunId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PARA TEXTBOX ACEITAR APENAS NUMEROS
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
