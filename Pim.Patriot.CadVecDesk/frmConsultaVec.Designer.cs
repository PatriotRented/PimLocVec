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
            this.tabCtrl.Location = new System.Drawing.Point(32, 25);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(843, 174);
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
            this.tbpGeral.Size = new System.Drawing.Size(835, 143);
            this.tbpGeral.TabIndex = 0;
            this.tbpGeral.Text = "Geral";
            // 
            // btnLimparG
            // 
            this.btnLimparG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparG.Location = new System.Drawing.Point(476, 90);
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
            this.btnPesquisarG.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarG.Image")));
            this.btnPesquisarG.Location = new System.Drawing.Point(247, 92);
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
            this.txtGeral.Size = new System.Drawing.Size(556, 25);
            this.txtGeral.TabIndex = 2;
            this.txtGeral.Text = "Você pode pesquisar pelo Código, Modelo, Marca, Categoria e ano do Veículo...";
            this.txtGeral.Click += new System.EventHandler(this.txtGeral_Click);
            // 
            // tbpAvancado
            // 
            this.tbpAvancado.BackColor = System.Drawing.SystemColors.Control;
            this.tbpAvancado.Location = new System.Drawing.Point(4, 27);
            this.tbpAvancado.Name = "tbpAvancado";
            this.tbpAvancado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAvancado.Size = new System.Drawing.Size(835, 143);
            this.tbpAvancado.TabIndex = 1;
            this.tbpAvancado.Text = "Pesquisa Avançada";
            // 
            // grvVec
            // 
            this.grvVec.AllowUserToAddRows = false;
            this.grvVec.AllowUserToOrderColumns = true;
            this.grvVec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grvVec.Location = new System.Drawing.Point(20, 205);
            this.grvVec.Name = "grvVec";
            this.grvVec.Size = new System.Drawing.Size(867, 274);
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
            this.ClientSize = new System.Drawing.Size(907, 505);
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
    }
}