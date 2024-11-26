using IFSPStore.app.Base;
using IFSPStore.app.Cadastros;
using IFSPStore.app.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.app
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
