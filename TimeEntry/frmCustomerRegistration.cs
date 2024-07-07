using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeEntry
{
    public partial class frmCustomerRegistration : Form
    {
        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        private void txtBoxCadCompany_TextChanged(object sender, EventArgs e)
        {
            //ToDo: Verificar se o Cliente Ja existe.
        }

        private void mskTxtBoxCadProject_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*ToDo: Verificar se o Cód. do Cliente ja existe no cadastro
             * Se existir mostrar uma mensagem e não deixando cadastrar.
             * Se der, mostrar o registro que existe no sistema para conferencia.
            */
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*ToDo: Cadastrar o cliente no banco de dados.
             * Incluir o cliente na TextBox do Form de horas.
             */
            mskTxtBoxCadProject.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(txtBoxCadCompany.Text))
            {
                MessageBox.Show(
                    "O campo Empresa está vazio, verifique e tente novamente!",
                    "Dados Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxCadCompany.Focus();
            }
            else if (string.IsNullOrWhiteSpace(mskTxtBoxCadProject.Text.Replace(mskTxtBoxCadProject.PromptChar.ToString(), string.Empty)))
            {
                MessageBox.Show(
                    "O campo Projeto, está vazio, verifique e tente novamente!",
                    "Dados Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                mskTxtBoxCadProject.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Cadastro Realizado com Sucesso!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBoxCadCompany.Text = "";
                mskTxtBoxCadProject.Text = "";
            }
        }

        private void btnCadClear_Click(object sender, EventArgs e)
        {
            txtBoxCadCompany.Text = "";
            mskTxtBoxCadProject.Text = "";
        }

        private void btnCadCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadCustRemove_Click(object sender, EventArgs e)
        {
            /*ToDo: Remover cliente que ja não existe mais no suporte.
             */
        }
    }
}
