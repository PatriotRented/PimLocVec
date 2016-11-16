namespace Pim.Patriot.CadVecDesk
{
    partial class frmConsultaVec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVec));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tbpGeral = new System.Windows.Forms.TabPage();
            this.btnLimparG = new System.Windows.Forms.Button();
            this.btnPesquisarG = new System.Windows.Forms.Button();
            this.lblGeral = new System.Windows.Forms.Label();
            this.txtGeral = new System.Windows.Forms.TextBox();
            this.tbpAvancado = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesAvan = new System.Windows.Forms.Button();
            this.grbAno = new System.Windows.Forms.GroupBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtAte = new System.Windows.Forms.TextBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.grvVec = new System.Windows.Forms.DataGridView();
            this.colCodVec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoVec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodAce1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAce1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoAce1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodAce2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAce2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoAce2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodAce3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAce3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoAce3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusVec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrl.SuspendLayout();
            this.tbpGeral.SuspendLayout();
            this.tbpAvancado.SuspendLayout();
            this.grbAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvVec)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tbpGeral);
            this.tabCtrl.Controls.Add(this.tbpAvancado);
            this.tabCtrl.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic);
            this.tabCtrl.HotTrack = true;
            this.tabCtrl.Location = new System.Drawing.Point(32, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1049, 175);
            this.tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrl.TabIndex = 3;
            // 
            // tbpGeral
            // 
            this.tbpGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpGeral.Controls.Add(this.btnLimparG);
            this.tbpGeral.Controls.Add(this.btnPesquisarG);
            this.tbpGeral.Controls.Add(this.lblGeral);
            this.tbpGeral.Controls.Add(this.txtGeral);
            this.tbpGeral.Location = new System.Drawing.Point(4, 27);
            this.tbpGeral.Name = "tbpGeral";
            this.tbpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpGeral.Size = new System.Drawing.Size(1041, 144);
            this.tbpGeral.TabIndex = 0;
            this.tbpGeral.Text = "Geral";
            // 
            // btnLimparG
            // 
            this.btnLimparG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparG.Location = new System.Drawing.Point(580, 81);
            this.btnLimparG.Name = "btnLimparG";
            this.btnLimparG.Size = new System.Drawing.Size(128, 30);
            this.btnLimparG.TabIndex = 5;
            this.btnLimparG.Text = "Limpar";
            this.btnLimparG.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarG
            // 
            this.btnPesquisarG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisarG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisarG.Image = global::Pim.Patriot.CadVecDesk.Properties.Resources.lupa20x21;
            this.btnPesquisarG.Location = new System.Drawing.Point(351, 81);
            this.btnPesquisarG.Name = "btnPesquisarG";
            this.btnPesquisarG.Size = new System.Drawing.Size(128, 30);
            this.btnPesquisarG.TabIndex = 4;
            this.btnPesquisarG.Text = "Pesquisar";
            this.btnPesquisarG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarG.UseVisualStyleBackColor = false;
            this.btnPesquisarG.Click += new System.EventHandler(this.btnPesquisarG_Click);
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGeral.Location = new System.Drawing.Point(82, 38);
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(93, 20);
            this.lblGeral.TabIndex = 3;
            this.lblGeral.Text = "Pesquisar:";
            // 
            // txtGeral
            // 
            this.txtGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeral.Location = new System.Drawing.Point(181, 36);
            this.txtGeral.Name = "txtGeral";
            this.txtGeral.Size = new System.Drawing.Size(678, 25);
            this.txtGeral.TabIndex = 2;
            this.txtGeral.Text = "Você pode pesquisar pelo Código, Modelo, Marca, Categoria e ano do Veículo...";
            this.txtGeral.Click += new System.EventHandler(this.txtGeral_Click);
            // 
            // tbpAvancado
            // 
            this.tbpAvancado.BackColor = System.Drawing.SystemColors.Control;
            this.tbpAvancado.Controls.Add(this.btnLimpar);
            this.tbpAvancado.Controls.Add(this.btnPesAvan);
            this.tbpAvancado.Controls.Add(this.grbAno);
            this.tbpAvancado.Controls.Add(this.cmbCat);
            this.tbpAvancado.Controls.Add(this.cmbStatus);
            this.tbpAvancado.Controls.Add(this.lblStat);
            this.tbpAvancado.Controls.Add(this.lblCat);
            this.tbpAvancado.Controls.Add(this.txtMarca);
            this.tbpAvancado.Controls.Add(this.lblMarca);
            this.tbpAvancado.Controls.Add(this.txtModelo);
            this.tbpAvancado.Controls.Add(this.lblMod);
            this.tbpAvancado.Location = new System.Drawing.Point(4, 27);
            this.tbpAvancado.Name = "tbpAvancado";
            this.tbpAvancado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAvancado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpAvancado.Size = new System.Drawing.Size(1041, 144);
            this.tbpAvancado.TabIndex = 1;
            this.tbpAvancado.Text = "Pesquisa Avançada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.Image = global::Pim.Patriot.CadVecDesk.Properties.Resources.faxineira17x21;
            this.btnLimpar.Location = new System.Drawing.Point(560, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 30);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesAvan
            // 
            this.btnPesAvan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesAvan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesAvan.Image = global::Pim.Patriot.CadVecDesk.Properties.Resources.lupa20x21;
            this.btnPesAvan.Location = new System.Drawing.Point(349, 108);
            this.btnPesAvan.Name = "btnPesAvan";
            this.btnPesAvan.Size = new System.Drawing.Size(128, 30);
            this.btnPesAvan.TabIndex = 12;
            this.btnPesAvan.Text = "Pesquisar";
            this.btnPesAvan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesAvan.UseVisualStyleBackColor = false;
            this.btnPesAvan.Click += new System.EventHandler(this.btnPesAvan_Click);
            // 
            // grbAno
            // 
            this.grbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAno.Controls.Add(this.lblAte);
            this.grbAno.Controls.Add(this.lblDe);
            this.grbAno.Controls.Add(this.txtDe);
            this.grbAno.Controls.Add(this.txtAte);
            this.grbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grbAno.Location = new System.Drawing.Point(812, 6);
            this.grbAno.Name = "grbAno";
            this.grbAno.Size = new System.Drawing.Size(184, 92);
            this.grbAno.TabIndex = 19;
            this.grbAno.TabStop = false;
            this.grbAno.Text = "Ano";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAte.Location = new System.Drawing.Point(49, 60);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(42, 20);
            this.lblAte.TabIndex = 20;
            this.lblAte.Text = "Até:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDe.Location = new System.Drawing.Point(49, 22);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(37, 20);
            this.lblDe.TabIndex = 13;
            this.lblDe.Text = "De:";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(97, 20);
            this.txtDe.MaxLength = 4;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(72, 26);
            this.txtDe.TabIndex = 10;
            this.txtDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(97, 57);
            this.txtAte.MaxLength = 4;
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(72, 26);
            this.txtAte.TabIndex = 11;
            this.txtAte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAte_KeyPress);
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(488, 28);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(236, 26);
            this.cmbCat.TabIndex = 8;
            this.cmbCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCat_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "D  | Disponível",
            "I   | Indisponível",
            "M | Manutenção",
            "R  | Reservado"});
            this.cmbStatus.Location = new System.Drawing.Point(488, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(236, 26);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStat.Location = new System.Drawing.Point(390, 68);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(62, 20);
            this.lblStat.TabIndex = 11;
            this.lblStat.Text = "Status";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCat.Location = new System.Drawing.Point(390, 31);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(92, 20);
            this.lblCat.TabIndex = 9;
            this.lblCat.Text = "Categoria:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(125, 64);
            this.txtMarca.MaxLength = 20;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(215, 25);
            this.txtMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(44, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(125, 27);
            this.txtModelo.MaxLength = 30;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(215, 25);
            this.txtModelo.TabIndex = 5;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMod.Location = new System.Drawing.Point(44, 29);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(72, 20);
            this.lblMod.TabIndex = 4;
            this.lblMod.Text = "Modelo:";
            // 
            // grvVec
            // 
            this.grvVec.AllowUserToAddRows = false;
            this.grvVec.AllowUserToOrderColumns = true;
            this.grvVec.AutoGenerateColumns = global::Pim.Patriot.CadVecDesk.Properties.Settings.Default.grvVecAutoGenerateColumns;
            this.grvVec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvVec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvVec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grvVec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvVec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodVec,
            this.colPlaca,
            this.colModelo,
            this.colMarca,
            this.colAnoVec,
            this.colCor,
            this.colCodCat,
            this.colNomeCat,
            this.precoCat,
            this.colCodAce1,
            this.colNomeAce1,
            this.colPrecoAce1,
            this.colCodAce2,
            this.colNomeAce2,
            this.colPrecoAce2,
            this.colCodAce3,
            this.colNomeAce3,
            this.colPrecoAce3,
            this.colPrecoCat,
            this.colStatusVec});
            this.grvVec.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::Pim.Patriot.CadVecDesk.Properties.Settings.Default, "grvVecAutoGenerateColumns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grvVec.Location = new System.Drawing.Point(20, 207);
            this.grvVec.Name = "grvVec";
            this.grvVec.Size = new System.Drawing.Size(1073, 354);
            this.grvVec.TabIndex = 2;
            // 
            // colCodVec
            // 
            this.colCodVec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCodVec.DataPropertyName = "codVec";
            this.colCodVec.HeaderText = "Código";
            this.colCodVec.Name = "colCodVec";
            this.colCodVec.Width = 65;
            // 
            // colPlaca
            // 
            this.colPlaca.DataPropertyName = "placa";
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.Width = 59;
            // 
            // colModelo
            // 
            this.colModelo.DataPropertyName = "modelo";
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Width = 67;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "marca";
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 62;
            // 
            // colAnoVec
            // 
            this.colAnoVec.DataPropertyName = "ano";
            this.colAnoVec.HeaderText = "Ano";
            this.colAnoVec.Name = "colAnoVec";
            this.colAnoVec.Width = 51;
            // 
            // colCor
            // 
            this.colCor.DataPropertyName = "cor";
            this.colCor.HeaderText = "Cor";
            this.colCor.Name = "colCor";
            this.colCor.Width = 48;
            // 
            // colCodCat
            // 
            this.colCodCat.DataPropertyName = "codCat";
            this.colCodCat.HeaderText = "codCat";
            this.colCodCat.Name = "colCodCat";
            this.colCodCat.Visible = false;
            this.colCodCat.Width = 66;
            // 
            // colNomeCat
            // 
            this.colNomeCat.DataPropertyName = "categoria";
            this.colNomeCat.HeaderText = "Categoria";
            this.colNomeCat.Name = "colNomeCat";
            this.colNomeCat.Width = 77;
            // 
            // precoCat
            // 
            this.precoCat.DataPropertyName = "precoCat";
            this.precoCat.HeaderText = "precoCat";
            this.precoCat.Name = "precoCat";
            this.precoCat.Visible = false;
            this.precoCat.Width = 75;
            // 
            // colCodAce1
            // 
            this.colCodAce1.DataPropertyName = "codAce1";
            this.colCodAce1.HeaderText = "codAce1";
            this.colCodAce1.Name = "colCodAce1";
            this.colCodAce1.Visible = false;
            this.colCodAce1.Width = 75;
            // 
            // colNomeAce1
            // 
            this.colNomeAce1.DataPropertyName = "nomeAce1";
            this.colNomeAce1.HeaderText = "1º Acessório";
            this.colNomeAce1.Name = "colNomeAce1";
            this.colNomeAce1.Width = 91;
            // 
            // colPrecoAce1
            // 
            this.colPrecoAce1.DataPropertyName = "precoAce1";
            this.colPrecoAce1.HeaderText = "Preço Ace1";
            this.colPrecoAce1.Name = "colPrecoAce1";
            this.colPrecoAce1.Visible = false;
            this.colPrecoAce1.Width = 88;
            // 
            // colCodAce2
            // 
            this.colCodAce2.DataPropertyName = "codAce2";
            this.colCodAce2.HeaderText = "codAce2";
            this.colCodAce2.Name = "colCodAce2";
            this.colCodAce2.Visible = false;
            this.colCodAce2.Width = 75;
            // 
            // colNomeAce2
            // 
            this.colNomeAce2.DataPropertyName = "nomeAce2";
            this.colNomeAce2.HeaderText = "2º Acessório";
            this.colNomeAce2.Name = "colNomeAce2";
            this.colNomeAce2.Width = 91;
            // 
            // colPrecoAce2
            // 
            this.colPrecoAce2.DataPropertyName = "precoAce2";
            this.colPrecoAce2.HeaderText = "Preço Ace2";
            this.colPrecoAce2.Name = "colPrecoAce2";
            this.colPrecoAce2.Visible = false;
            this.colPrecoAce2.Width = 88;
            // 
            // colCodAce3
            // 
            this.colCodAce3.DataPropertyName = "codAce3";
            this.colCodAce3.HeaderText = "codAce3";
            this.colCodAce3.Name = "colCodAce3";
            this.colCodAce3.Visible = false;
            this.colCodAce3.Width = 75;
            // 
            // colNomeAce3
            // 
            this.colNomeAce3.DataPropertyName = "nomeAce3";
            this.colNomeAce3.HeaderText = "3ºAcessório";
            this.colNomeAce3.Name = "colNomeAce3";
            this.colNomeAce3.Width = 88;
            // 
            // colPrecoAce3
            // 
            this.colPrecoAce3.DataPropertyName = "precoAce3";
            this.colPrecoAce3.HeaderText = "Preço Ace3";
            this.colPrecoAce3.Name = "colPrecoAce3";
            this.colPrecoAce3.Visible = false;
            this.colPrecoAce3.Width = 88;
            // 
            // colPrecoCat
            // 
            this.colPrecoCat.DataPropertyName = "precoBase";
            this.colPrecoCat.HeaderText = "Preço Base";
            this.colPrecoCat.Name = "colPrecoCat";
            this.colPrecoCat.Width = 87;
            // 
            // colStatusVec
            // 
            this.colStatusVec.DataPropertyName = "status";
            this.colStatusVec.HeaderText = "Status";
            this.colStatusVec.Name = "colStatusVec";
            this.colStatusVec.Width = 62;
            // 
            // frmConsultaVec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadVecDesk.Properties.Resources.backgroundPretoBranco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 587);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.grvVec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "01 - Consulta de Veículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabCtrl.ResumeLayout(false);
            this.tbpGeral.ResumeLayout(false);
            this.tbpGeral.PerformLayout();
            this.tbpAvancado.ResumeLayout(false);
            this.tbpAvancado.PerformLayout();
            this.grbAno.ResumeLayout(false);
            this.grbAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvVec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tbpGeral;
        private System.Windows.Forms.Label lblGeral;
        private System.Windows.Forms.TextBox txtGeral;
        private System.Windows.Forms.TabPage tbpAvancado;
        private System.Windows.Forms.DataGridView grvVec;
        private System.Windows.Forms.Button btnPesquisarG;
        private System.Windows.Forms.Button btnLimparG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodVec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoVec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAce1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAce1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoAce1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAce2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAce2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoAce2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAce3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAce3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoAce3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusVec;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.TextBox txtAte;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesAvan;
        private System.Windows.Forms.GroupBox grbAno;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
    }
}