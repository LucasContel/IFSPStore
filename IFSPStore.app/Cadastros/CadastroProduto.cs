
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Base
{
    public partial class CadastroProduto : CadastroBase
    {
        
        private readonly IBaseService<Produto> _produtoService;
        //private IBaseService<GrupoModel> _grupoService;
        private List<Produto>? produtos;
        
        public CadastroProduto(IBaseService<Produto> produtoService, IBaseService<Grupo> grupoService)
        {
            _produtoService = produtoService;
            InitializeComponent();
        }
        
        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = txtNome.Text;
            produto.Preco = float.Parse(txtPreco.Text);
            produto.UnidadeVenda = txtUnidadeVenda.Text;
            produto.DataCompra = DateTime.Parse(txtDataCompra.Text);
            //produto.Grupo.Nome = cbGrupo.Text;
        }
        
        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
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
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCombo()
        {
            cboGrupo.ValueMember = "Id";
            cboGrupo.DisplayMember = "NomeEstado";
            cboGrupo.DataSource = _grupoService.Get<GrupoModel>().ToList();
        }

        protected override void CarregaGrid()
        {
            produtos = _produtoService.Get<Produto>().ToList();
            dataGridViewConsulta.DataSource = produtos;
            dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preço"].Value.ToString();
            txtUnidadeVenda.Text = linha?.Cells["Unidade Venda"].Value.ToString();
            txtDataCompra.Text = linha?.Cells["Data Compra"].Value.ToString();
            cboGrupo.Text = linha?.Cells["Grupo"].Value.ToString();
        }
    }
}
