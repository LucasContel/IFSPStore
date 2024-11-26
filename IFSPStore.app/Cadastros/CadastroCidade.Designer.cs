namespace IFSPStore.app.Cadastros
{
    partial class CadastroCidade
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
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 48);
            tabControlCadastro.Margin = new Padding(3, 4, 3, 4);
            tabControlCadastro.Size = new Size(840, 400);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(832, 365);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(cboEstado, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPageConsulta.Size = new Size(786, 349);
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
            txtNome.Location = new Point(167, 75);
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
            txtNome.Size = new Size(415, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cboEstado.Location = new Point(607, 75);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 3;
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
            txtId.Location = new Point(18, 75);
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
            txtId.Size = new Size(125, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 451);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroCidade";
            Padding = new Padding(3, 48, 3, 3);
            Text = "CadastroCidade";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}