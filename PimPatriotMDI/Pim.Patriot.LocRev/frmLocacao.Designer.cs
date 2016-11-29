namespace Pim.Patriot.LocRev
{
    partial class frmLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocacao));
            this.tabctrlLoc = new System.Windows.Forms.TabControl();
            this.tabpagLoca = new System.Windows.Forms.TabPage();
            this.grpValor = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorDia = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.lblRetirada = new System.Windows.Forms.Label();
            this.calendarRetorno = new System.Windows.Forms.MonthCalendar();
            this.calendarRetirada = new System.Windows.Forms.MonthCalendar();
            this.grboxLoc = new System.Windows.Forms.GroupBox();
            this.grbLoc2 = new System.Windows.Forms.GroupBox();
            this.rbtnKm_ctrl = new System.Windows.Forms.RadioButton();
            this.rbtnKm_livre = new System.Windows.Forms.RadioButton();
            this.lblTipLoc = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFun = new System.Windows.Forms.ComboBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.richtxtObserv = new System.Windows.Forms.RichTextBox();
            this.lblAten = new System.Windows.Forms.Label();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.lblCli = new System.Windows.Forms.Label();
            this.txtCpf_Cnpj = new System.Windows.Forms.TextBox();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.tabpagPesq = new System.Windows.Forms.TabPage();
            this.grvLoc = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodVec = new System.Windows.Forms.TextBox();
            this.txtCodLoc = new System.Windows.Forms.TextBox();
            this.txtCodCLi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPcli = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendarATE = new System.Windows.Forms.MonthCalendar();
            this.calendarDE = new System.Windows.Forms.MonthCalendar();
            this.codLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrlLoc.SuspendLayout();
            this.tabpagLoca.SuspendLayout();
            this.grpValor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grboxLoc.SuspendLayout();
            this.grbLoc2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpagPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoc)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlLoc
            // 
            this.tabctrlLoc.Controls.Add(this.tabpagLoca);
            this.tabctrlLoc.Controls.Add(this.tabpagPesq);
            this.tabctrlLoc.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlLoc.Location = new System.Drawing.Point(31, 37);
            this.tabctrlLoc.Name = "tabctrlLoc";
            this.tabctrlLoc.SelectedIndex = 0;
            this.tabctrlLoc.Size = new System.Drawing.Size(919, 568);
            this.tabctrlLoc.TabIndex = 0;
            // 
            // tabpagLoca
            // 
            this.tabpagLoca.Controls.Add(this.grpValor);
            this.tabpagLoca.Controls.Add(this.btnCancel);
            this.tabpagLoca.Controls.Add(this.btnCon);
            this.tabpagLoca.Controls.Add(this.groupBox4);
            this.tabpagLoca.Controls.Add(this.grboxLoc);
            this.tabpagLoca.Controls.Add(this.groupBox1);
            this.tabpagLoca.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagLoca.Location = new System.Drawing.Point(4, 28);
            this.tabpagLoca.Name = "tabpagLoca";
            this.tabpagLoca.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagLoca.Size = new System.Drawing.Size(911, 536);
            this.tabpagLoca.TabIndex = 0;
            this.tabpagLoca.Text = "Locação";
            this.tabpagLoca.UseVisualStyleBackColor = true;
            // 
            // grpValor
            // 
            this.grpValor.Controls.Add(this.txtValorTotal);
            this.grpValor.Controls.Add(this.txtValorDia);
            this.grpValor.Location = new System.Drawing.Point(609, 294);
            this.grpValor.Name = "grpValor";
            this.grpValor.Size = new System.Drawing.Size(250, 76);
            this.grpValor.TabIndex = 5;
            this.grpValor.TabStop = false;
            this.grpValor.Text = "Valor Estimado";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(135, 33);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(88, 23);
            this.txtValorTotal.TabIndex = 1;
            this.txtValorTotal.Text = "Total";
            // 
            // txtValorDia
            // 
            this.txtValorDia.Enabled = false;
            this.txtValorDia.Location = new System.Drawing.Point(25, 33);
            this.txtValorDia.Name = "txtValorDia";
            this.txtValorDia.Size = new System.Drawing.Size(88, 23);
            this.txtValorDia.TabIndex = 0;
            this.txtValorDia.Text = "Diária";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::Pim.Patriot.LocRev.Properties.Resources.cross49x51;
            this.btnCancel.Location = new System.Drawing.Point(753, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 87);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.White;
            this.btnCon.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.Image = global::Pim.Patriot.LocRev.Properties.Resources.Carro60x59;
            this.btnCon.Location = new System.Drawing.Point(609, 406);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(120, 87);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "Concluir";
            this.btnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRetorno);
            this.groupBox4.Controls.Add(this.lblRetirada);
            this.groupBox4.Controls.Add(this.calendarRetorno);
            this.groupBox4.Controls.Add(this.calendarRetirada);
            this.groupBox4.Location = new System.Drawing.Point(19, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 223);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Location = new System.Drawing.Point(366, 24);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(78, 16);
            this.lblRetorno.TabIndex = 3;
            this.lblRetorno.Text = "Retorno";
            // 
            // lblRetirada
            // 
            this.lblRetirada.AutoSize = true;
            this.lblRetirada.Location = new System.Drawing.Point(95, 24);
            this.lblRetirada.Name = "lblRetirada";
            this.lblRetirada.Size = new System.Drawing.Size(88, 16);
            this.lblRetirada.TabIndex = 2;
            this.lblRetirada.Text = "Retirada";
            // 
            // calendarRetorno
            // 
            this.calendarRetorno.Location = new System.Drawing.Point(293, 49);
            this.calendarRetorno.Name = "calendarRetorno";
            this.calendarRetorno.TabIndex = 1;
            this.calendarRetorno.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarRetorno_DateSelected);
            // 
            // calendarRetirada
            // 
            this.calendarRetirada.Location = new System.Drawing.Point(24, 49);
            this.calendarRetirada.Name = "calendarRetirada";
            this.calendarRetirada.TabIndex = 0;
            this.calendarRetirada.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarRetirada_DateSelected);
            // 
            // grboxLoc
            // 
            this.grboxLoc.Controls.Add(this.grbLoc2);
            this.grboxLoc.Controls.Add(this.txtCat);
            this.grboxLoc.Controls.Add(this.lblCat);
            this.grboxLoc.Controls.Add(this.txtPlaca);
            this.grboxLoc.Controls.Add(this.lblPlaca);
            this.grboxLoc.Location = new System.Drawing.Point(17, 172);
            this.grboxLoc.Name = "grboxLoc";
            this.grboxLoc.Size = new System.Drawing.Size(862, 114);
            this.grboxLoc.TabIndex = 1;
            this.grboxLoc.TabStop = false;
            this.grboxLoc.Text = "Dados do Veículo";
            // 
            // grbLoc2
            // 
            this.grbLoc2.Controls.Add(this.rbtnKm_ctrl);
            this.grbLoc2.Controls.Add(this.rbtnKm_livre);
            this.grbLoc2.Controls.Add(this.lblTipLoc);
            this.grbLoc2.Location = new System.Drawing.Point(425, 0);
            this.grbLoc2.Name = "grbLoc2";
            this.grbLoc2.Size = new System.Drawing.Size(444, 114);
            this.grbLoc2.TabIndex = 9;
            this.grbLoc2.TabStop = false;
            // 
            // rbtnKm_ctrl
            // 
            this.rbtnKm_ctrl.AutoSize = true;
            this.rbtnKm_ctrl.Location = new System.Drawing.Point(234, 69);
            this.rbtnKm_ctrl.Name = "rbtnKm_ctrl";
            this.rbtnKm_ctrl.Size = new System.Drawing.Size(156, 20);
            this.rbtnKm_ctrl.TabIndex = 2;
            this.rbtnKm_ctrl.TabStop = true;
            this.rbtnKm_ctrl.Text = "Km controlado";
            this.rbtnKm_ctrl.UseVisualStyleBackColor = true;
            this.rbtnKm_ctrl.CheckedChanged += new System.EventHandler(this.rbtnKm_ctrl_CheckedChanged);
            // 
            // rbtnKm_livre
            // 
            this.rbtnKm_livre.AutoSize = true;
            this.rbtnKm_livre.Location = new System.Drawing.Point(66, 69);
            this.rbtnKm_livre.Name = "rbtnKm_livre";
            this.rbtnKm_livre.Size = new System.Drawing.Size(106, 20);
            this.rbtnKm_livre.TabIndex = 1;
            this.rbtnKm_livre.TabStop = true;
            this.rbtnKm_livre.Text = "Km livre";
            this.rbtnKm_livre.UseVisualStyleBackColor = true;
            this.rbtnKm_livre.CheckedChanged += new System.EventHandler(this.rbtnKm_livre_CheckedChanged);
            // 
            // lblTipLoc
            // 
            this.lblTipLoc.AutoSize = true;
            this.lblTipLoc.Location = new System.Drawing.Point(134, 33);
            this.lblTipLoc.Name = "lblTipLoc";
            this.lblTipLoc.Size = new System.Drawing.Size(168, 16);
            this.lblTipLoc.TabIndex = 0;
            this.lblTipLoc.Text = "Tipos de Locação";
            // 
            // txtCat
            // 
            this.txtCat.Enabled = false;
            this.txtCat.Location = new System.Drawing.Point(149, 69);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(219, 23);
            this.txtCat.TabIndex = 8;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(34, 75);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(108, 16);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Categoria:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(149, 30);
            this.txtPlaca.MaxLength = 9;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(219, 23);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(34, 33);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(68, 16);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFun);
            this.groupBox1.Controls.Add(this.lblObs);
            this.groupBox1.Controls.Add(this.richtxtObserv);
            this.groupBox1.Controls.Add(this.lblAten);
            this.groupBox1.Controls.Add(this.txtCli);
            this.groupBox1.Controls.Add(this.lblCli);
            this.groupBox1.Controls.Add(this.txtCpf_Cnpj);
            this.groupBox1.Controls.Add(this.lblCPF_CNPJ);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // cmbFun
            // 
            this.cmbFun.FormattingEnabled = true;
            this.cmbFun.Location = new System.Drawing.Point(152, 103);
            this.cmbFun.Name = "cmbFun";
            this.cmbFun.Size = new System.Drawing.Size(219, 24);
            this.cmbFun.TabIndex = 8;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(426, 73);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(118, 16);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "Observação:";
            // 
            // richtxtObserv
            // 
            this.richtxtObserv.Location = new System.Drawing.Point(550, 38);
            this.richtxtObserv.MaxLength = 200;
            this.richtxtObserv.Name = "richtxtObserv";
            this.richtxtObserv.Size = new System.Drawing.Size(271, 86);
            this.richtxtObserv.TabIndex = 6;
            this.richtxtObserv.Text = "";
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Location = new System.Drawing.Point(37, 107);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(108, 16);
            this.lblAten.TabIndex = 4;
            this.lblAten.Text = "Atentende:";
            // 
            // txtCli
            // 
            this.txtCli.AllowDrop = true;
            this.txtCli.Location = new System.Drawing.Point(152, 70);
            this.txtCli.MaxLength = 50;
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(219, 23);
            this.txtCli.TabIndex = 3;
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Location = new System.Drawing.Point(37, 73);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(88, 16);
            this.lblCli.TabIndex = 2;
            this.lblCli.Text = "Cliente:";
            // 
            // txtCpf_Cnpj
            // 
            this.txtCpf_Cnpj.Location = new System.Drawing.Point(152, 33);
            this.txtCpf_Cnpj.MaxLength = 14;
            this.txtCpf_Cnpj.Name = "txtCpf_Cnpj";
            this.txtCpf_Cnpj.Size = new System.Drawing.Size(219, 23);
            this.txtCpf_Cnpj.TabIndex = 1;
            this.txtCpf_Cnpj.TextChanged += new System.EventHandler(this.txtCpf_Cnpj_TextChanged);
            this.txtCpf_Cnpj.Leave += new System.EventHandler(this.txtCpf_Cnpj_Leave);
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(37, 36);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(98, 16);
            this.lblCPF_CNPJ.TabIndex = 0;
            this.lblCPF_CNPJ.Text = "CPF/CNPJ:";
            // 
            // tabpagPesq
            // 
            this.tabpagPesq.Controls.Add(this.grvLoc);
            this.tabpagPesq.Controls.Add(this.grpPesquisa);
            this.tabpagPesq.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagPesq.Location = new System.Drawing.Point(4, 28);
            this.tabpagPesq.Name = "tabpagPesq";
            this.tabpagPesq.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagPesq.Size = new System.Drawing.Size(911, 536);
            this.tabpagPesq.TabIndex = 1;
            this.tabpagPesq.Text = "Pesquisa locação";
            this.tabpagPesq.UseVisualStyleBackColor = true;
            // 
            // grvLoc
            // 
            this.grvLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLoc,
            this.codCli,
            this.cnpj_cpf,
            this.nomeCli,
            this.codVec,
            this.placa,
            this.modelo,
            this.marca,
            this.categoria,
            this.codFun,
            this.nomeFun,
            this.tipoPlan,
            this.desco,
            this.total,
            this.status});
            this.grvLoc.Location = new System.Drawing.Point(21, 216);
            this.grvLoc.Name = "grvLoc";
            this.grvLoc.Size = new System.Drawing.Size(863, 283);
            this.grvLoc.TabIndex = 1;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnSair);
            this.grpPesquisa.Controls.Add(this.btnLimpar);
            this.grpPesquisa.Controls.Add(this.btnPes);
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.txtCodVec);
            this.grpPesquisa.Controls.Add(this.txtCodLoc);
            this.grpPesquisa.Controls.Add(this.txtCodCLi);
            this.grpPesquisa.Controls.Add(this.label2);
            this.grpPesquisa.Controls.Add(this.lblPcli);
            this.grpPesquisa.Controls.Add(this.groupBox2);
            this.grpPesquisa.Location = new System.Drawing.Point(21, 17);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(863, 198);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.Image = global::Pim.Patriot.LocRev.Properties.Resources.carroComRelogioEmCima30x30;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(240, 141);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 42);
            this.btnSair.TabIndex = 11;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::Pim.Patriot.LocRev.Properties.Resources.faxineira20x26;
            this.btnLimpar.Location = new System.Drawing.Point(137, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 42);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPes
            // 
            this.btnPes.BackColor = System.Drawing.Color.White;
            this.btnPes.Image = global::Pim.Patriot.LocRev.Properties.Resources.lupa30x31;
            this.btnPes.Location = new System.Drawing.Point(31, 141);
            this.btnPes.Name = "btnPes";
            this.btnPes.Size = new System.Drawing.Size(75, 42);
            this.btnPes.TabIndex = 9;
            this.btnPes.UseVisualStyleBackColor = false;
            this.btnPes.Click += new System.EventHandler(this.btnPes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cód. do Veículo:";
            // 
            // txtCodVec
            // 
            this.txtCodVec.Location = new System.Drawing.Point(188, 96);
            this.txtCodVec.Name = "txtCodVec";
            this.txtCodVec.Size = new System.Drawing.Size(123, 23);
            this.txtCodVec.TabIndex = 6;
            // 
            // txtCodLoc
            // 
            this.txtCodLoc.Location = new System.Drawing.Point(188, 61);
            this.txtCodLoc.Name = "txtCodLoc";
            this.txtCodLoc.Size = new System.Drawing.Size(123, 23);
            this.txtCodLoc.TabIndex = 3;
            // 
            // txtCodCLi
            // 
            this.txtCodCLi.Location = new System.Drawing.Point(188, 32);
            this.txtCodCLi.Name = "txtCodCLi";
            this.txtCodCLi.Size = new System.Drawing.Size(123, 23);
            this.txtCodCLi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód. da Locação:";
            // 
            // lblPcli
            // 
            this.lblPcli.AutoSize = true;
            this.lblPcli.Location = new System.Drawing.Point(14, 35);
            this.lblPcli.Name = "lblPcli";
            this.lblPcli.Size = new System.Drawing.Size(138, 16);
            this.lblPcli.TabIndex = 0;
            this.lblPcli.Text = "Cód. Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.calendarATE);
            this.groupBox2.Controls.Add(this.calendarDE);
            this.groupBox2.Location = new System.Drawing.Point(341, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 198);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "De:";
            // 
            // calendarATE
            // 
            this.calendarATE.Location = new System.Drawing.Point(270, 28);
            this.calendarATE.Name = "calendarATE";
            this.calendarATE.ShowToday = false;
            this.calendarATE.TabIndex = 5;
            this.calendarATE.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarATE_DateSelected);
            // 
            // calendarDE
            // 
            this.calendarDE.Location = new System.Drawing.Point(28, 28);
            this.calendarDE.Name = "calendarDE";
            this.calendarDE.ShowToday = false;
            this.calendarDE.TabIndex = 4;
            this.calendarDE.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarDE_DateSelected);
            // 
            // codLoc
            // 
            this.codLoc.DataPropertyName = "codLoc";
            this.codLoc.HeaderText = "Locação";
            this.codLoc.Name = "codLoc";
            // 
            // codCli
            // 
            this.codCli.DataPropertyName = "codCli";
            this.codCli.HeaderText = "Cód. Cliente";
            this.codCli.Name = "codCli";
            // 
            // cnpj_cpf
            // 
            this.cnpj_cpf.DataPropertyName = "cnpj_cpf";
            this.cnpj_cpf.HeaderText = "CPF/CNPJ";
            this.cnpj_cpf.Name = "cnpj_cpf";
            // 
            // nomeCli
            // 
            this.nomeCli.DataPropertyName = "nomeCli";
            this.nomeCli.HeaderText = "Cliente";
            this.nomeCli.Name = "nomeCli";
            // 
            // codVec
            // 
            this.codVec.DataPropertyName = "codVec";
            this.codVec.HeaderText = "Cód. Veículo";
            this.codVec.Name = "codVec";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // codFun
            // 
            this.codFun.DataPropertyName = "codFun";
            this.codFun.HeaderText = "Cód Fun.";
            this.codFun.Name = "codFun";
            // 
            // nomeFun
            // 
            this.nomeFun.DataPropertyName = "nomeFun";
            this.nomeFun.HeaderText = "Funcionário";
            this.nomeFun.Name = "nomeFun";
            // 
            // tipoPlan
            // 
            this.tipoPlan.DataPropertyName = "tipoPlan";
            this.tipoPlan.HeaderText = "Tipo do Plano";
            this.tipoPlan.Name = "tipoPlan";
            // 
            // desco
            // 
            this.desco.DataPropertyName = "desco";
            this.desco.HeaderText = "Desconto";
            this.desco.Name = "desco";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Valor Total";
            this.total.Name = "total";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.LocRev.Properties.Resources.backgroundPretoBranco1040x588;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabctrlLoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação de Veículos";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            this.tabctrlLoc.ResumeLayout(false);
            this.tabpagLoca.ResumeLayout(false);
            this.grpValor.ResumeLayout(false);
            this.grpValor.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grboxLoc.ResumeLayout(false);
            this.grboxLoc.PerformLayout();
            this.grbLoc2.ResumeLayout(false);
            this.grbLoc2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpagPesq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvLoc)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlLoc;
        private System.Windows.Forms.TabPage tabpagLoca;
        private System.Windows.Forms.TabPage tabpagPesq;
        private System.Windows.Forms.GroupBox grboxLoc;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox richtxtObserv;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.TextBox txtCpf_Cnpj;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label lblRetirada;
        private System.Windows.Forms.MonthCalendar calendarRetorno;
        private System.Windows.Forms.MonthCalendar calendarRetirada;
        private System.Windows.Forms.GroupBox grbLoc2;
        private System.Windows.Forms.RadioButton rbtnKm_ctrl;
        private System.Windows.Forms.RadioButton rbtnKm_livre;
        private System.Windows.Forms.Label lblTipLoc;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.GroupBox grpValor;
        private System.Windows.Forms.TextBox txtValorDia;
        private System.Windows.Forms.ComboBox cmbFun;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridView grvLoc;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVec;
        private System.Windows.Forms.TextBox txtCodLoc;
        private System.Windows.Forms.TextBox txtCodCLi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPcli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarATE;
        private System.Windows.Forms.MonthCalendar calendarDE;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVec;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}