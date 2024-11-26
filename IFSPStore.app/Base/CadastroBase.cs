using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.app.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool isAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos_Form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastro.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        #endregion

        #region eventos_CRUD
        protected void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Focus();
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabControlCadastro.SelectedIndex = 0;
                tabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selectione algum registro!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
        #endregion







    }
}
