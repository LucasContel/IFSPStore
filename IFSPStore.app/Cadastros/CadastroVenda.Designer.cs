namespace IFSPStore.app.Base
{
    partial class CadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDataVenda = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1 = new GroupBox();
            labelTotal = new ReaLTaiizor.Controls.MaterialLabel();
            labelProdutos = new ReaLTaiizor.Controls.MaterialLabel();
            labelValorTotal = new ReaLTaiizor.Controls.MaterialLabel();
            labelQtdProdutos = new ReaLTaiizor.Controls.MaterialLabel();
            dataGridViewVendas = new DataGridView();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            txtValorTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValorUnidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(824, 472);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(txtDataVenda);
            tabPageCadastro.Size = new Size(816, 437);
            tabPageCadastro.Controls.SetChildIndex(txtDataVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(590, 394);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(683, 394);
            // 
            // txtDataVenda
            // 
            txtDataVenda.AllowPromptAsInput = true;
            txtDataVenda.AnimateReadOnly = false;
            txtDataVenda.AsciiOnly = false;
            txtDataVenda.BackgroundImageLayout = ImageLayout.None;
            txtDataVenda.BeepOnError = false;
            txtDataVenda.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.Depth = 0;
            txtDataVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataVenda.HidePromptOnLeave = false;
            txtDataVenda.HideSelection = true;
            txtDataVenda.Hint = "Data Venda";
            txtDataVenda.InsertKeyMode = InsertKeyMode.Default;
            txtDataVenda.LeadingIcon = null;
            txtDataVenda.Location = new Point(24, 34);
            txtDataVenda.Mask = "";
            txtDataVenda.MaxLength = 32767;
            txtDataVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.PasswordChar = '\0';
            txtDataVenda.PrefixSuffixText = null;
            txtDataVenda.PromptChar = '_';
            txtDataVenda.ReadOnly = false;
            txtDataVenda.RejectInputOnFirstFailure = false;
            txtDataVenda.ResetOnPrompt = true;
            txtDataVenda.ResetOnSpace = true;
            txtDataVenda.RightToLeft = RightToLeft.No;
            txtDataVenda.SelectedText = "";
            txtDataVenda.SelectionLength = 0;
            txtDataVenda.SelectionStart = 0;
            txtDataVenda.ShortcutsEnabled = true;
            txtDataVenda.Size = new Size(312, 48);
            txtDataVenda.SkipLiterals = true;
            txtDataVenda.TabIndex = 2;
            txtDataVenda.TabStop = false;
            txtDataVenda.TextAlign = HorizontalAlignment.Left;
            txtDataVenda.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataVenda.TrailingIcon = null;
            txtDataVenda.UseSystemPasswordChar = false;
            txtDataVenda.ValidatingType = null;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário/Vendedor";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(352, 33);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(284, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(659, 34);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(108, 48);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTotal);
            groupBox1.Controls.Add(labelProdutos);
            groupBox1.Controls.Add(labelValorTotal);
            groupBox1.Controls.Add(labelQtdProdutos);
            groupBox1.Controls.Add(dataGridViewVendas);
            groupBox1.Controls.Add(materialButton1);
            groupBox1.Controls.Add(txtValorTotal);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtValorUnidade);
            groupBox1.Controls.Add(cboProduto);
            groupBox1.Location = new Point(24, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 225);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos da Venda";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Depth = 0;
            labelTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTotal.Location = new Point(594, 199);
            labelTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(10, 19);
            labelTotal.TabIndex = 17;
            labelTotal.Text = "0";
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Depth = 0;
            labelProdutos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelProdutos.Location = new Point(114, 199);
            labelProdutos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(10, 19);
            labelProdutos.TabIndex = 16;
            labelProdutos.Text = "0";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Depth = 0;
            labelValorTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelValorTotal.Location = new Point(505, 199);
            labelValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(83, 19);
            labelValorTotal.TabIndex = 15;
            labelValorTotal.Text = "Valor Total:";
            // 
            // labelQtdProdutos
            // 
            labelQtdProdutos.AutoSize = true;
            labelQtdProdutos.Depth = 0;
            labelQtdProdutos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelQtdProdutos.Location = new Point(6, 199);
            labelQtdProdutos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelQtdProdutos.Name = "labelQtdProdutos";
            labelQtdProdutos.Size = new Size(102, 19);
            labelQtdProdutos.TabIndex = 14;
            labelQtdProdutos.Text = "Qtd. Produtos:";
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(3, 77);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.Size = new Size(733, 119);
            dataGridViewVendas.TabIndex = 13;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(661, 25);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(75, 36);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "+";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            txtValorTotal.AnimateReadOnly = false;
            txtValorTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTotal.BackgroundImageLayout = ImageLayout.None;
            txtValorTotal.CharacterCasing = CharacterCasing.Normal;
            txtValorTotal.Depth = 0;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotal.HideSelection = true;
            txtValorTotal.Hint = "Vl.Total";
            txtValorTotal.LeadingIcon = null;
            txtValorTotal.Location = new Point(538, 22);
            txtValorTotal.MaxLength = 32767;
            txtValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.PasswordChar = '\0';
            txtValorTotal.PrefixSuffixText = null;
            txtValorTotal.ReadOnly = false;
            txtValorTotal.RightToLeft = RightToLeft.No;
            txtValorTotal.SelectedText = "";
            txtValorTotal.SelectionLength = 0;
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.ShortcutsEnabled = true;
            txtValorTotal.Size = new Size(116, 48);
            txtValorTotal.TabIndex = 11;
            txtValorTotal.TabStop = false;
            txtValorTotal.TextAlign = HorizontalAlignment.Left;
            txtValorTotal.TrailingIcon = null;
            txtValorTotal.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Qtd";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(425, 22);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(97, 48);
            txtQuantidade.TabIndex = 10;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtValorUnidade
            // 
            txtValorUnidade.AnimateReadOnly = false;
            txtValorUnidade.AutoCompleteMode = AutoCompleteMode.None;
            txtValorUnidade.AutoCompleteSource = AutoCompleteSource.None;
            txtValorUnidade.BackgroundImageLayout = ImageLayout.None;
            txtValorUnidade.CharacterCasing = CharacterCasing.Normal;
            txtValorUnidade.Depth = 0;
            txtValorUnidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorUnidade.HideSelection = true;
            txtValorUnidade.Hint = "Vl.Unit.";
            txtValorUnidade.LeadingIcon = null;
            txtValorUnidade.Location = new Point(307, 23);
            txtValorUnidade.MaxLength = 32767;
            txtValorUnidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorUnidade.Name = "txtValorUnidade";
            txtValorUnidade.PasswordChar = '\0';
            txtValorUnidade.PrefixSuffixText = null;
            txtValorUnidade.ReadOnly = false;
            txtValorUnidade.RightToLeft = RightToLeft.No;
            txtValorUnidade.SelectedText = "";
            txtValorUnidade.SelectionLength = 0;
            txtValorUnidade.SelectionStart = 0;
            txtValorUnidade.ShortcutsEnabled = true;
            txtValorUnidade.Size = new Size(103, 48);
            txtValorUnidade.TabIndex = 9;
            txtValorUnidade.TabStop = false;
            txtValorUnidade.TextAlign = HorizontalAlignment.Left;
            txtValorUnidade.TrailingIcon = null;
            txtValorUnidade.UseSystemPasswordChar = false;
            // 
            // cboProduto
            // 
            cboProduto.AutoResize = false;
            cboProduto.BackColor = Color.FromArgb(255, 255, 255);
            cboProduto.Depth = 0;
            cboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduto.DropDownHeight = 174;
            cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduto.DropDownWidth = 121;
            cboProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduto.FormattingEnabled = true;
            cboProduto.Hint = "Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(6, 22);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(284, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 4;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(24, 88);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(743, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 8;
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 522);
            Name = "CadastroVenda";
            Text = "Cadastro de Vendas";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataVenda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private GroupBox groupBox1;
        private DataGridView dataGridViewVendas;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorUnidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduto;
        private ReaLTaiizor.Controls.MaterialLabel labelValorTotal;
        private ReaLTaiizor.Controls.MaterialLabel labelQtdProdutos;
        private ReaLTaiizor.Controls.MaterialLabel labelProdutos;
        private ReaLTaiizor.Controls.MaterialLabel labelTotal;
    }
}