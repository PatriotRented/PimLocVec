namespace Pim.Patriot.CadCli
{
    partial class frmConsultaCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCli));
            this.tbpGeral = new System.Windows.Forms.TabPage();
            this.txtGeral = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabConsultaCli = new System.Windows.Forms.TabControl();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpGeral.SuspendLayout();
            this.tabConsultaCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpGeral
            // 
            this.tbpGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tbpGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpGeral.Controls.Add(this.txtGeral);
            this.tbpGeral.Controls.Add(this.btnBuscar);
            this.tbpGeral.Controls.Add(this.btnLimpar);
            this.tbpGeral.Controls.Add(this.lblPesquisar);
            this.tbpGeral.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpGeral.Location = new System.Drawing.Point(4, 27);
            this.tbpGeral.Name = "tbpGeral";
            this.tbpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeral.Size = new System.Drawing.Size(804, 143);
            this.tbpGeral.TabIndex = 0;
            this.tbpGeral.Text = "Geral";
            // 
            // txtGeral
            // 
            this.txtGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeral.Location = new System.Drawing.Point(150, 28);
            this.txtGeral.Name = "txtGeral";
            this.txtGeral.Size = new System.Drawing.Size(620, 25);
            this.txtGeral.TabIndex = 5;
            this.txtGeral.Text = "Você pode pesquisar pelo Código, Nome, RG, CPF/CNPJ e CNH do Cliente...";
            this.txtGeral.Click += new System.EventHandler(this.txtGeral_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::Pim.Patriot.CadCli.Properties.Resources.lupa20x21;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(257, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 35);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = global::Pim.Patriot.CadCli.Properties.Resources.faxineira17x21;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(426, 69);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 35);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPesquisar.Location = new System.Drawing.Point(28, 33);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 4;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabConsultaCli
            // 
            this.tabConsultaCli.Controls.Add(this.tbpGeral);
            this.tabConsultaCli.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaCli.Location = new System.Drawing.Point(49, 26);
            this.tabConsultaCli.Name = "tabConsultaCli";
            this.tabConsultaCli.SelectedIndex = 0;
            this.tabConsultaCli.Size = new System.Drawing.Size(812, 174);
            this.tabConsultaCli.TabIndex = 22;
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToAddRows = false;
            this.gridCliente.AllowUserToOrderColumns = true;
            this.gridCliente.AutoGenerateColumns = global::Pim.Patriot.CadCli.Properties.Settings.Default.Falsiane;
            this.gridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colNome,
            this.colRg,
            this.colCpfCnpj,
            this.colCnh,
            this.colEmail,
            this.colTel,
            this.colData});
            this.gridCliente.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::Pim.Patriot.CadCli.Properties.Settings.Default, "Falsiane", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gridCliente.Location = new System.Drawing.Point(49, 240);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.Size = new System.Drawing.Size(847, 233);
            this.gridCliente.TabIndex = 23;
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "codCli";
            this.colCod.HeaderText = "Codigo Cliente";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 92;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nomecli";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 60;
            // 
            // colRg
            // 
            this.colRg.DataPropertyName = "rg";
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            this.colRg.Width = 48;
            // 
            // colCpfCnpj
            // 
            this.colCpfCnpj.DataPropertyName = "cnpj_cpf";
            this.colCpfCnpj.HeaderText = "CPF/CNPJ";
            this.colCpfCnpj.Name = "colCpfCnpj";
            this.colCpfCnpj.ReadOnly = true;
            this.colCpfCnpj.Width = 84;
            // 
            // colCnh
            // 
            this.colCnh.DataPropertyName = "cnh";
            this.colCnh.HeaderText = "CNH";
            this.colCnh.Name = "colCnh";
            this.colCnh.ReadOnly = true;
            this.colCnh.Width = 55;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "emailCli";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 57;
            // 
            // colTel
            // 
            this.colTel.DataPropertyName = "tel";
            this.colTel.HeaderText = "Telefone";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            this.colTel.Width = 74;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "dt_nasc";
            this.colData.HeaderText = "Data Nascimento";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 105;
            // 
            // frmConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadCli.Properties.Resources.backgroundPretoBranco1920x1086;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.tabConsultaCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.tbpGeral.ResumeLayout(false);
            this.tbpGeral.PerformLayout();
            this.tabConsultaCli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.TabPage tbpGeral;
        private System.Windows.Forms.TextBox txtGeral;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabControl tabConsultaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}