namespace Pim.Patriot.CadCli
{
    partial class FrmConsultaFun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFun));
            this.gridFuncionario = new System.Windows.Forms.DataGridView();
            this.colFun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConsultaFun = new System.Windows.Forms.TabControl();
            this.tbpGeral = new System.Windows.Forms.TabPage();
            this.txtGeral = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            this.tabConsultaFun.SuspendLayout();
            this.tbpGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.AllowUserToAddRows = false;
            this.gridFuncionario.AllowUserToOrderColumns = true;
            this.gridFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridFuncionario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFun,
            this.colNome,
            this.colCpf,
            this.colCargo,
            this.colDtad,
            this.colEmail,
            this.colTel,
            this.colData});
            this.gridFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::Pim.Patriot.CadCli.Properties.Settings.Default, "Falsiane", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gridFuncionario.Location = new System.Drawing.Point(28, 254);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.ReadOnly = true;
            this.gridFuncionario.Size = new System.Drawing.Size(847, 233);
            this.gridFuncionario.TabIndex = 25;
            // 
            // colFun
            // 
            this.colFun.DataPropertyName = "codFun";
            this.colFun.HeaderText = "Codigo Funcionario";
            this.colFun.Name = "colFun";
            this.colFun.ReadOnly = true;
            this.colFun.Width = 113;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nomeFun";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 60;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "cpf";
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            this.colCpf.Width = 52;
            // 
            // colCargo
            // 
            this.colCargo.DataPropertyName = "cargo";
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.ReadOnly = true;
            this.colCargo.Width = 60;
            // 
            // colDtad
            // 
            this.colDtad.DataPropertyName = "dt_admissao";
            this.colDtad.HeaderText = "Data admissão";
            this.colDtad.Name = "colDtad";
            this.colDtad.ReadOnly = true;
            this.colDtad.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "emailFun";
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
            // tabConsultaFun
            // 
            this.tabConsultaFun.Controls.Add(this.tbpGeral);
            this.tabConsultaFun.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaFun.Location = new System.Drawing.Point(28, 40);
            this.tabConsultaFun.Name = "tabConsultaFun";
            this.tabConsultaFun.SelectedIndex = 0;
            this.tabConsultaFun.Size = new System.Drawing.Size(812, 174);
            this.tabConsultaFun.TabIndex = 24;
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
            this.txtGeral.Text = "Você pode pesquisar pelo Código, Nome, CPF do Funcionario...";
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
            // FrmConsultaFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadCli.Properties.Resources.backgroundPretoBranco1920x1086;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 527);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.tabConsultaFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaFun";
            this.Text = "FrmConsultaFuncs";
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).EndInit();
            this.tabConsultaFun.ResumeLayout(false);
            this.tbpGeral.ResumeLayout(false);
            this.tbpGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFuncionario;
        private System.Windows.Forms.TabControl tabConsultaFun;
        private System.Windows.Forms.TabPage tbpGeral;
        private System.Windows.Forms.TextBox txtGeral;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}