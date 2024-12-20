﻿
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Base
{
    public partial class CadastroProduto : CadastroBase
    {

        private readonly IBaseService<Produto> _produtoService;
        private readonly IBaseService<Grupo> _grupoService;

        private List<ProdutoModel>? produtos;

        public CadastroProduto(IBaseService<Produto> produtoService, IBaseService<Grupo> grupoService)
        {
            _produtoService = produtoService;
            _grupoService = grupoService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboGrupo.ValueMember = "Id";
            cboGrupo.DisplayMember = "Nome";
            cboGrupo.DataSource = _grupoService.Get<Grupo>().ToList();
        }

        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = txtNome.Text;
            if (float.TryParse(txtPreco.Text.Replace(",", "."), out var preco))
            {
                produto.Preco = preco;
            }
            else
            {
                MessageBox.Show("Erro", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DateTime.TryParse(txtDataCompra.Text, out var dataCompra))
            {
                produto.DataCompra = dataCompra;
            }
            produto.UnidadeVenda = txtUnidadeVenda.Text;

            produto.Quantidade = int.Parse(txtQuantidade.Text);

            if (int.TryParse(cboGrupo.SelectedValue.ToString(), out var idGrupo))
            {
                var grupo = _grupoService.GetById<Grupo>(idGrupo);
                produto.Grupo = grupo;
                //_produtoService.AttachObject(grupo);
            }
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

        protected override void CarregaGrid()
        {
            produtos = _produtoService.Get<ProdutoModel>(new[] { "Grupo" }).ToList();
            dataGridViewConsulta.DataSource = produtos;
            dataGridViewConsulta.Columns["IdGrupo"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtUnidadeVenda.Text = linha?.Cells["UnidadeVenda"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            cboGrupo.SelectedValue = linha?.Cells["IdGrupo"].Value;
            txtDataCompra.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

        }

    }
}
