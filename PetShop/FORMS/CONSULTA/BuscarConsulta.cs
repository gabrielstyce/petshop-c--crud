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
    public partial class BuscarConsulta : UserControl
    {
        public BuscarConsulta()
        {
            InitializeComponent();
        }
        Atendimento atendimento = new Atendimento();
        ConsultaBO consulta = new ConsultaBO();
        public Boolean Preenche()
        {
            if (txtAtendimento.Text != "")
            {
                return true;
            }
            if (txtData.Text != "")
            {
                return true;
            }
            if (txtFuncionarios.Text != "")
            {
                return true;
            }
            if (txtPet.Text != "")
            {
                return true;
            }
            if (txtServico.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (Preenche() == true)
            {
                if (txtAtendimento.Text != "")
                {
                    atendimento.CodAtendimento = Convert.ToInt32(txtAtendimento.Text);
                    dtGridConsulta.DataSource = consulta.BuscarPorId(atendimento);
                }
                else if (txtData.Text != "")
                {
                    dtGridConsulta.DataSource = consulta.BuscarPorData(txtData.Text);
                }
                else if (txtFuncionarios.Text != "")
                {
                    atendimento.Funcionario.Codigo = Convert.ToInt32(txtFuncionarios.Text);
                    dtGridConsulta.DataSource = consulta.BuscarPorFuncionario(atendimento);
                }
                else if (txtPet.Text != "")
                {
                    atendimento.Pet.CodPet = Convert.ToInt32(txtPet.Text);
                    dtGridConsulta.DataSource = consulta.BuscarPorPet(atendimento);
                }
                else if (txtServico.Text != "")
                {
                    atendimento.Servico.Tipo = txtServico.Text;
                    dtGridConsulta.DataSource = consulta.BuscarPorServico(atendimento);
                }
            }
            else
            {
                MyMessageBox.Show(this, "Por favor preencha um dos campos de busca!", "CAMPOS DE BUSCA VAZIOS");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            dtGridConsulta.DataSource = null;
        }
    }
}
