using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Base
{


    public partial class CadastroCliente : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Cliente> _clienteService;
        private List<Cliente>? clientes;
        #endregion

        #region Construtor
        public CadastroCliente(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        #endregion

        #region Métodos
        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            //cliente.Cidade.Nome = cbCidade.Text;
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            dataGridViewConsulta.DataSource = clientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereço"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cboCidade.Text = linha?.Cells["Cidade"].Value.ToString();
        }
        #endregion
    }
}
