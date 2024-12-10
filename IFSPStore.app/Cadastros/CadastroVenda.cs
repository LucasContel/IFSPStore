
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

namespace IFSPStore.app.Base
{
    public partial class CadastroVenda : CadastroBase
    {
        private List<VendaItemModel> _vendaItens;
        private readonly IBaseService<Venda> _vendaService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;

        private List<VendaModel>? vendas;

        public CadastroVenda(IBaseService<Venda> vendaService,
IBaseService<Usuario> usuarioService,
IBaseService<Cliente> clienteService, IBaseService<Produto> produtoService)
        {
            _vendaService = vendaService;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaItens = new List<VendaItemModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();
            Novo();
        }

        private void CarregarCombo()
        {
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
            cboUsuario.DataSource = _usuarioService.Get<Usuario>().ToList();

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
            cboProduto.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Venda venda)
        {
            if (DateTime.TryParse(txtDataVenda.Text, out var dataVenda))
            {
                venda.Data = dataVenda;
            }

            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                venda.Usuario = usuario;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                venda.Cliente = cliente;
            }
            venda.ValorTotal = _vendaItens.Sum(x => x.ValorTotal);

            foreach (var item in _vendaItens)
            {
                var itemVenda = new VendaItem
                {
                    Venda = venda,
                    Produto = _produtoService.GetById<Produto>(item.IdProduto),
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                };

                venda.Itens.Add(itemVenda);
            }

        }
        protected override void Novo()
        {
            base.Novo();
            _vendaItens.Clear();
            CarregaGridItensVenda();
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var venda = _vendaService.GetById<Venda>(id);
                        PreencheObjeto(venda);
                        venda = _vendaService.Update<Venda, Venda, VendaValidator>(venda);
                    }
                }
                else
                {
                    var venda = new Venda();
                    PreencheObjeto(venda);
                    venda = _vendaService.Add<Venda, Venda, VendaValidator>(venda);
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
                _vendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente", "Usuario" };
            vendas = _vendaService.Get<VendaModel>(includes).ToList();
            dataGridViewConsulta.DataSource = vendas;
            dataGridViewConsulta.Columns["IdUsuario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
            dataGridViewConsulta.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dataGridViewConsulta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            txtDataVenda.Text = DateTime.TryParse(linha?.Cells["Data"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

            var includes = new List<string>() { "Cliente", "Usuario", "Items", "Items.Produto" };
            var venda = _vendaService.GetById<Venda>(id, includes);
            _vendaItens = new List<VendaItemModel>();
            foreach (var item in venda.Itens)
            {
                var vendaItem = new VendaItemModel
                {
                    Id = item.Id,
                    IdProduto = item.Produto!.Id,
                    Produto = item.Produto!.Nome,
                    ValorTotal = item.ValorTotal.GetValueOrDefault(),
                    Quantidade = item.Quantidade.GetValueOrDefault(),
                    ValorUnitario = item.ValorUnitario.GetValueOrDefault()
                };
                _vendaItens.Add(vendaItem);
            }
            CarregaGridItensVenda();

        }



        private void CarregaGridItensVenda()
        {
            var source = new BindingSource();
            source.DataSource = _vendaItens.ToArray();
            dataGridViewVendas.DataSource = source;
            dataGridViewVendas.Columns["Id"]!.Visible = false;
            dataGridViewVendas.Columns["IdProduto"]!.HeaderText = @"Id.Produto";
            dataGridViewVendas.Columns["ValorUnitario"]!.DefaultCellStyle.Format = "C2";
            dataGridViewVendas.Columns["ValorUnitario"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewVendas.Columns["ValorTotal"]!.DefaultCellStyle.Format = "C2";
            dataGridViewVendas.Columns["ValorTotal"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewVendas.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var vendaItem = new VendaItemModel();
                if (int.TryParse(cboProduto.SelectedValue.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    vendaItem.IdProduto = produto.Id;
                    vendaItem.Produto = produto.Nome;
                }

                if (float.TryParse(txtValorUnidade.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var vlUnitario))
                {
                    vendaItem.ValorUnitario = vlUnitario;
                }
                if (int.TryParse(txtQuantidade.Text, out var qtd))
                {
                    vendaItem.Quantidade = qtd;
                }

                vendaItem.ValorTotal = vendaItem.Quantidade * vendaItem.ValorUnitario;

                _vendaItens.Add(vendaItem);
                CalculaTotalVenda();
                CarregaGridItensVenda();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

        private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorUnidade.Text, out double value))
                txtValorUnidade.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtValorUnidade.Text = string.Empty;

            CalculaTotalItem();
        }

        private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(txtValorUnidade.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(txtQuantidade.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                float valorTotal = quantidade * vlUnitario;
                txtValorTotal.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalculaTotalVenda()
        {
            txtValorTotal.Text = $@"Valor Total: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _vendaItens.Sum(x => x.ValorTotal))}";
            txtQuantidade.Text = $@"Qtd. Produtos: {_vendaItens.Sum(x => x.Quantidade)}";
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var vendaItem = new VendaItemModel();
                if (int.TryParse(cboProduto.SelectedValue.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    vendaItem.IdProduto = produto.Id;
                    vendaItem.Produto = produto.Nome;
                }

                if (float.TryParse(txtValorUnidade.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var vlUnitario))
                {
                    vendaItem.ValorUnitario = vlUnitario;
                }
                if (int.TryParse(txtQuantidade.Text, out var qtd))
                {
                    vendaItem.Quantidade = qtd;
                }

                vendaItem.ValorTotal = vendaItem.Quantidade * vendaItem.ValorUnitario;

                _vendaItens.Add(vendaItem);
                CalculaTotalVenda();
                CarregaGridItensVenda();
            }
        }
    }
}
