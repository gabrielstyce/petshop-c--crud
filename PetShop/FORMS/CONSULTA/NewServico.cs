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
    public partial class NewServico : UserControl
    {
        public NewServico()
        {
            InitializeComponent();
        }
        Servico servico = new Servico();
        ServicoBO servicoBo = new ServicoBO();

        public Boolean Preenche()
        {
            if (txtPorte.Text == "")
            {
                return false;
            }
            if (txtTipo.Text == "")
            {
                return false;
            }
            if (txtValor.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Preenche() == true)
                {
                    servico.Porte = txtPorte.Text;
                    servico.Tipo = txtTipo.Text;
                    servico.Valor = Convert.ToDecimal(txtValor.Text);

                    servicoBo.Cadastrar(servico);
                    MyMessageBox.Show(this, "", "CADASTRADO!");
                }
                else
                {
                    MyMessageBox.Show(this, "", "Preencha um dos campos de busca!");
                }
            }
            catch
            {
                MyMessageBox.Show(this, "", "dados incorretos");
            }
        }
    }
}
