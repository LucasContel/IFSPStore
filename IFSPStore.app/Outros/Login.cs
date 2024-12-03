using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
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

namespace IFSPStore.app.Outros
{
    public partial class Login : MaterialForm
    {

        private readonly IBaseService<Usuario> _usuarioService;

        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (usuario.Ativo == false)
                {
                    MessageBox.Show("Usuário inativo!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usuario.DataLogin = DateTime.Now;
                    usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    FormPrincipal.Usuario = usuario;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Login == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }

            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Login = "admin",
                    Senha = "admin",
                    Nome = "Admnistrador do Sistema",
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
