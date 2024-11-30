namespace IFSPStore.app.Base
{
    partial class CadastroProduto
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtUnidadeVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCompra = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboGrupo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 64);
            tabControlCadastro.Margin = new Padding(3);
            tabControlCadastro.Size = new Size(832, 436);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtQuantidade);
            tabPageCadastro.Controls.Add(cboGrupo);
            tabPageCadastro.Controls.Add(txtDataCompra);
            tabPageCadastro.Controls.Add(txtUnidadeVenda);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Margin = new Padding(3);
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(824, 401);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtUnidadeVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCompra, 0);
            tabPageCadastro.Controls.SetChildIndex(cboGrupo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQuantidade, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3);
            tabPageConsulta.Padding = new Padding(3);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(590, 350);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(683, 350);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(22, 40);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(582, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(610, 40);
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
            txtId.Size = new Size(157, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            txtPreco.AllowPromptAsInput = true;
            txtPreco.AnimateReadOnly = false;
            txtPreco.AsciiOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.BeepOnError = false;
            txtPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HidePromptOnLeave = false;
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.InsertKeyMode = InsertKeyMode.Default;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(22, 107);
            txtPreco.Mask = "999.99";
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.PromptChar = '_';
            txtPreco.ReadOnly = false;
            txtPreco.RejectInputOnFirstFailure = false;
            txtPreco.ResetOnPrompt = true;
            txtPreco.ResetOnSpace = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(363, 48);
            txtPreco.SkipLiterals = true;
            txtPreco.TabIndex = 5;
            txtPreco.TabStop = false;
            txtPreco.Text = "   .";
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.ValidatingType = null;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.AnimateReadOnly = false;
            txtUnidadeVenda.AutoCompleteMode = AutoCompleteMode.None;
            txtUnidadeVenda.AutoCompleteSource = AutoCompleteSource.None;
            txtUnidadeVenda.BackgroundImageLayout = ImageLayout.None;
            txtUnidadeVenda.CharacterCasing = CharacterCasing.Normal;
            txtUnidadeVenda.Depth = 0;
            txtUnidadeVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnidadeVenda.HideSelection = true;
            txtUnidadeVenda.Hint = "Unidade Venda";
            txtUnidadeVenda.LeadingIcon = null;
            txtUnidadeVenda.Location = new Point(22, 183);
            txtUnidadeVenda.MaxLength = 32767;
            txtUnidadeVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PasswordChar = '\0';
            txtUnidadeVenda.PrefixSuffixText = null;
            txtUnidadeVenda.ReadOnly = false;
            txtUnidadeVenda.RightToLeft = RightToLeft.No;
            txtUnidadeVenda.SelectedText = "";
            txtUnidadeVenda.SelectionLength = 0;
            txtUnidadeVenda.SelectionStart = 0;
            txtUnidadeVenda.ShortcutsEnabled = true;
            txtUnidadeVenda.Size = new Size(363, 48);
            txtUnidadeVenda.TabIndex = 6;
            txtUnidadeVenda.TabStop = false;
            txtUnidadeVenda.TextAlign = HorizontalAlignment.Left;
            txtUnidadeVenda.TrailingIcon = null;
            txtUnidadeVenda.UseSystemPasswordChar = false;
            // 
            // txtDataCompra
            // 
            txtDataCompra.AllowPromptAsInput = true;
            txtDataCompra.AnimateReadOnly = false;
            txtDataCompra.AsciiOnly = false;
            txtDataCompra.BackgroundImageLayout = ImageLayout.None;
            txtDataCompra.BeepOnError = false;
            txtDataCompra.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.Depth = 0;
            txtDataCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCompra.HidePromptOnLeave = false;
            txtDataCompra.HideSelection = true;
            txtDataCompra.Hint = "Data Compra";
            txtDataCompra.InsertKeyMode = InsertKeyMode.Default;
            txtDataCompra.LeadingIcon = null;
            txtDataCompra.Location = new Point(405, 183);
            txtDataCompra.Mask = "99/99/9999";
            txtDataCompra.MaxLength = 32767;
            txtDataCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.PasswordChar = '\0';
            txtDataCompra.PrefixSuffixText = null;
            txtDataCompra.PromptChar = '_';
            txtDataCompra.ReadOnly = false;
            txtDataCompra.RejectInputOnFirstFailure = false;
            txtDataCompra.ResetOnPrompt = true;
            txtDataCompra.ResetOnSpace = true;
            txtDataCompra.RightToLeft = RightToLeft.No;
            txtDataCompra.SelectedText = "";
            txtDataCompra.SelectionLength = 0;
            txtDataCompra.SelectionStart = 0;
            txtDataCompra.ShortcutsEnabled = true;
            txtDataCompra.Size = new Size(362, 48);
            txtDataCompra.SkipLiterals = true;
            txtDataCompra.TabIndex = 7;
            txtDataCompra.TabStop = false;
            txtDataCompra.Text = "  /  /";
            txtDataCompra.TextAlign = HorizontalAlignment.Left;
            txtDataCompra.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.TrailingIcon = null;
            txtDataCompra.UseSystemPasswordChar = false;
            txtDataCompra.ValidatingType = null;
            // 
            // cboGrupo
            // 
            cboGrupo.AutoResize = false;
            cboGrupo.BackColor = Color.FromArgb(255, 255, 255);
            cboGrupo.Depth = 0;
            cboGrupo.DrawMode = DrawMode.OwnerDrawVariable;
            cboGrupo.DropDownHeight = 174;
            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupo.DropDownWidth = 121;
            cboGrupo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboGrupo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Hint = "Grupo";
            cboGrupo.IntegralHeight = false;
            cboGrupo.ItemHeight = 43;
            cboGrupo.Location = new Point(22, 260);
            cboGrupo.MaxDropDownItems = 4;
            cboGrupo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(745, 49);
            cboGrupo.StartIndex = 0;
            cboGrupo.TabIndex = 8;
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
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(405, 107);
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
            txtQuantidade.Size = new Size(362, 48);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 503);
            Margin = new Padding(3);
            Name = "CadastroProduto";
            Padding = new Padding(3, 64, 3, 3);
            Text = "Cadastro de Produtos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCompra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnidadeVenda;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPreco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboGrupo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
    }
}