
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Base
{
    public partial class CadastroUsuario : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        private List<Usuario>? usuarios;
        #endregion

        #region Construtor
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Email = txtEmail.Text;
            usuario.DataCadastro = DateTime.Parse(txtDataCadastro.Text);
            usuario.DataLogin = DateTime.Parse(txtDataLogin.Text);
            usuario.Ativo = ckbxAtivo.Checked;
        }
        #endregion

        #region Eventos CRUD
        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();
            dataGridViewConsulta.DataSource = usuarios;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            txtDataCadastro.Text = linha?.Cells["Data Cadastro"].Value.ToString();
            txtDataLogin.Text = linha?.Cells["DataLogin"].Value.ToString();
            var sAtivo = linha?.Cells["Ativo"].Value.ToString();
            if (sAtivo is "true")
            {
                ckbxAtivo.Checked = true;
            }
            else
            {
                ckbxAtivo.Checked = false;
            }
        }

        #endregion
    }
}
