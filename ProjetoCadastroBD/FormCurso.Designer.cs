namespace ProjetoCadastroBD
{
    partial class FormCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            TabControlCadastroCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastroCurso = new TabPage();
            txtIdCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            cbxPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsultaCurso = new TabPage();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditarCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnNovoCurso = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewCurso = new DataGridView();
            imageList1 = new ImageList(components);
            TabControlCadastroCurso.SuspendLayout();
            tabPageCadastroCurso.SuspendLayout();
            tabPageConsultaCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // TabControlCadastroCurso
            // 
            TabControlCadastroCurso.Controls.Add(tabPageCadastroCurso);
            TabControlCadastroCurso.Controls.Add(tabPageConsultaCurso);
            TabControlCadastroCurso.Depth = 0;
            TabControlCadastroCurso.ImageList = imageList1;
            TabControlCadastroCurso.Location = new Point(6, 67);
            TabControlCadastroCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastroCurso.Multiline = true;
            TabControlCadastroCurso.Name = "TabControlCadastroCurso";
            TabControlCadastroCurso.SelectedIndex = 0;
            TabControlCadastroCurso.Size = new Size(788, 377);
            TabControlCadastroCurso.TabIndex = 8;
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(txtIdCurso);
            tabPageCadastroCurso.Controls.Add(btnSalvar);
            tabPageCadastroCurso.Controls.Add(btnCancelar);
            tabPageCadastroCurso.Controls.Add(cbxPeriodo);
            tabPageCadastroCurso.Controls.Add(cbxArea);
            tabPageCadastroCurso.Controls.Add(cbxDuracao);
            tabPageCadastroCurso.Controls.Add(cbxNivel);
            tabPageCadastroCurso.Controls.Add(txtNomeCurso);
            tabPageCadastroCurso.Controls.Add(txtCodCurso);
            tabPageCadastroCurso.ImageKey = "form.png";
            tabPageCadastroCurso.Location = new Point(4, 29);
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.Padding = new Padding(3);
            tabPageCadastroCurso.Size = new Size(780, 344);
            tabPageCadastroCurso.TabIndex = 0;
            tabPageCadastroCurso.Text = "Cadastro";
            tabPageCadastroCurso.UseVisualStyleBackColor = true;
            // 
            // txtIdCurso
            // 
            txtIdCurso.AnimateReadOnly = false;
            txtIdCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtIdCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtIdCurso.BackgroundImageLayout = ImageLayout.None;
            txtIdCurso.CharacterCasing = CharacterCasing.Normal;
            txtIdCurso.Depth = 0;
            txtIdCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdCurso.HideSelection = true;
            txtIdCurso.Hint = "Id do curso";
            txtIdCurso.LeadingIcon = null;
            txtIdCurso.Location = new Point(40, 14);
            txtIdCurso.MaxLength = 32767;
            txtIdCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.PasswordChar = '\0';
            txtIdCurso.PrefixSuffixText = null;
            txtIdCurso.ReadOnly = true;
            txtIdCurso.RightToLeft = RightToLeft.No;
            txtIdCurso.SelectedText = "";
            txtIdCurso.SelectionLength = 0;
            txtIdCurso.SelectionStart = 0;
            txtIdCurso.ShortcutsEnabled = true;
            txtIdCurso.Size = new Size(189, 48);
            txtIdCurso.TabIndex = 8;
            txtIdCurso.TabStop = false;
            txtIdCurso.TextAlign = HorizontalAlignment.Left;
            txtIdCurso.TrailingIcon = null;
            txtIdCurso.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(665, 294);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(551, 294);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxPeriodo
            // 
            cbxPeriodo.AutoResize = false;
            cbxPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cbxPeriodo.Depth = 0;
            cbxPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPeriodo.DropDownHeight = 174;
            cbxPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPeriodo.DropDownWidth = 121;
            cbxPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPeriodo.FormattingEnabled = true;
            cbxPeriodo.Hint = "Período";
            cbxPeriodo.IntegralHeight = false;
            cbxPeriodo.ItemHeight = 43;
            cbxPeriodo.Items.AddRange(new object[] { "Integral", "Matutino", "Noturno", "Vespertino" });
            cbxPeriodo.Location = new Point(403, 214);
            cbxPeriodo.MaxDropDownItems = 4;
            cbxPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPeriodo.Name = "cbxPeriodo";
            cbxPeriodo.Size = new Size(338, 49);
            cbxPeriodo.StartIndex = 0;
            cbxPeriodo.TabIndex = 14;
            // 
            // cbxArea
            // 
            cbxArea.AutoResize = false;
            cbxArea.BackColor = Color.FromArgb(255, 255, 255);
            cbxArea.Depth = 0;
            cbxArea.DrawMode = DrawMode.OwnerDrawVariable;
            cbxArea.DropDownHeight = 174;
            cbxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxArea.DropDownWidth = 121;
            cbxArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxArea.FormattingEnabled = true;
            cbxArea.Hint = "Área";
            cbxArea.IntegralHeight = false;
            cbxArea.ItemHeight = 43;
            cbxArea.Items.AddRange(new object[] { "Administração", "Indústria", "Informática", "Licenciatura" });
            cbxArea.Location = new Point(40, 214);
            cbxArea.MaxDropDownItems = 4;
            cbxArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxArea.Name = "cbxArea";
            cbxArea.Size = new Size(357, 49);
            cbxArea.StartIndex = 0;
            cbxArea.TabIndex = 13;
            // 
            // cbxDuracao
            // 
            cbxDuracao.AutoResize = false;
            cbxDuracao.BackColor = Color.FromArgb(255, 255, 255);
            cbxDuracao.Depth = 0;
            cbxDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDuracao.DropDownHeight = 174;
            cbxDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDuracao.DropDownWidth = 121;
            cbxDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDuracao.FormattingEnabled = true;
            cbxDuracao.Hint = "Duração (em semestres)";
            cbxDuracao.IntegralHeight = false;
            cbxDuracao.ItemHeight = 43;
            cbxDuracao.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxDuracao.Location = new Point(403, 150);
            cbxDuracao.MaxDropDownItems = 4;
            cbxDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDuracao.Name = "cbxDuracao";
            cbxDuracao.Size = new Size(338, 49);
            cbxDuracao.StartIndex = 0;
            cbxDuracao.TabIndex = 12;
            // 
            // cbxNivel
            // 
            cbxNivel.AutoResize = false;
            cbxNivel.BackColor = Color.FromArgb(255, 255, 255);
            cbxNivel.Depth = 0;
            cbxNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cbxNivel.DropDownHeight = 174;
            cbxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNivel.DropDownWidth = 121;
            cbxNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxNivel.FormattingEnabled = true;
            cbxNivel.Hint = "Nível do curso";
            cbxNivel.IntegralHeight = false;
            cbxNivel.ItemHeight = 43;
            cbxNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cbxNivel.Location = new Point(40, 150);
            cbxNivel.MaxDropDownItems = 4;
            cbxNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxNivel.Name = "cbxNivel";
            cbxNivel.Size = new Size(357, 49);
            cbxNivel.StartIndex = 0;
            cbxNivel.TabIndex = 11;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "Nome do curso";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(40, 79);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(701, 48);
            txtNomeCurso.TabIndex = 10;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // txtCodCurso
            // 
            txtCodCurso.AnimateReadOnly = false;
            txtCodCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtCodCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtCodCurso.BackgroundImageLayout = ImageLayout.None;
            txtCodCurso.CharacterCasing = CharacterCasing.Normal;
            txtCodCurso.Depth = 0;
            txtCodCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodCurso.HideSelection = true;
            txtCodCurso.Hint = "Código do curso";
            txtCodCurso.LeadingIcon = null;
            txtCodCurso.Location = new Point(235, 14);
            txtCodCurso.MaxLength = 32767;
            txtCodCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodCurso.Name = "txtCodCurso";
            txtCodCurso.PasswordChar = '\0';
            txtCodCurso.PrefixSuffixText = null;
            txtCodCurso.ReadOnly = false;
            txtCodCurso.RightToLeft = RightToLeft.No;
            txtCodCurso.SelectedText = "";
            txtCodCurso.SelectionLength = 0;
            txtCodCurso.SelectionStart = 0;
            txtCodCurso.ShortcutsEnabled = true;
            txtCodCurso.Size = new Size(506, 48);
            txtCodCurso.TabIndex = 9;
            txtCodCurso.TabStop = false;
            txtCodCurso.TextAlign = HorizontalAlignment.Left;
            txtCodCurso.TrailingIcon = null;
            txtCodCurso.UseSystemPasswordChar = false;
            // 
            // tabPageConsultaCurso
            // 
            tabPageConsultaCurso.Controls.Add(btnExcluir);
            tabPageConsultaCurso.Controls.Add(btnEditarCurso);
            tabPageConsultaCurso.Controls.Add(btnNovoCurso);
            tabPageConsultaCurso.Controls.Add(dataGridViewCurso);
            tabPageConsultaCurso.ImageKey = "search.png";
            tabPageConsultaCurso.Location = new Point(4, 29);
            tabPageConsultaCurso.Name = "tabPageConsultaCurso";
            tabPageConsultaCurso.Padding = new Padding(3);
            tabPageConsultaCurso.Size = new Size(780, 344);
            tabPageConsultaCurso.TabIndex = 1;
            tabPageConsultaCurso.Text = "Consulta";
            tabPageConsultaCurso.UseVisualStyleBackColor = true;
            tabPageConsultaCurso.Enter += tabPageConsultaCurso_Enter;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(673, 299);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCurso.Depth = 0;
            btnEditarCurso.HighEmphasis = true;
            btnEditarCurso.Icon = null;
            btnEditarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditarCurso.Location = new Point(594, 299);
            btnEditarCurso.Margin = new Padding(4, 6, 4, 6);
            btnEditarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.NoAccentTextColor = Color.Empty;
            btnEditarCurso.Size = new Size(71, 36);
            btnEditarCurso.TabIndex = 2;
            btnEditarCurso.Text = "Editar";
            btnEditarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarCurso.UseAccentColor = false;
            btnEditarCurso.UseVisualStyleBackColor = true;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnNovoCurso
            // 
            btnNovoCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovoCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovoCurso.Depth = 0;
            btnNovoCurso.HighEmphasis = true;
            btnNovoCurso.Icon = null;
            btnNovoCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovoCurso.Location = new Point(522, 299);
            btnNovoCurso.Margin = new Padding(4, 6, 4, 6);
            btnNovoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovoCurso.Name = "btnNovoCurso";
            btnNovoCurso.NoAccentTextColor = Color.Empty;
            btnNovoCurso.Size = new Size(64, 36);
            btnNovoCurso.TabIndex = 1;
            btnNovoCurso.Text = "Novo";
            btnNovoCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovoCurso.UseAccentColor = false;
            btnNovoCurso.UseVisualStyleBackColor = true;
            btnNovoCurso.Click += btnNovoCurso_Click;
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Location = new Point(3, 3);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.RowHeadersWidth = 51;
            dataGridViewCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurso.Size = new Size(774, 291);
            dataGridViewCurso.TabIndex = 0;
            dataGridViewCurso.MouseDoubleClick += dataGridViewCurso_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(1, "form.png");
            imageList1.Images.SetKeyName(2, "search.png");
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlCadastroCurso);
            DrawerTabControl = TabControlCadastroCurso;
            Name = "FormCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
            TabControlCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.PerformLayout();
            tabPageConsultaCurso.ResumeLayout(false);
            tabPageConsultaCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastroCurso;
        private TabPage tabPageCadastroCurso;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxArea;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox cbxNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodCurso;
        private TabPage tabPageConsultaCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdCurso;
        private DataGridView dataGridViewCurso;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditarCurso;
        private ReaLTaiizor.Controls.MaterialButton btnNovoCurso;
        private ImageList imageList1;
    }
}