namespace Pim.Patriot.LocRev
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.tabctrlLoc = new System.Windows.Forms.TabControl();
            this.tabpagLoca = new System.Windows.Forms.TabPage();
            this.grpValor = new System.Windows.Forms.GroupBox();
            this.rbtnCtrl = new System.Windows.Forms.RadioButton();
            this.rbtnLivre = new System.Windows.Forms.RadioButton();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorDia = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.lblRetirada = new System.Windows.Forms.Label();
            this.calendarRetorno = new System.Windows.Forms.MonthCalendar();
            this.calendarRetirada = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFun = new System.Windows.Forms.ComboBox();
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
            this.txtCodRes = new System.Windows.Forms.TextBox();
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
            this.ret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrlLoc.SuspendLayout();
            this.tabpagLoca.SuspendLayout();
            this.grpValor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.tabctrlLoc.Location = new System.Drawing.Point(12, 12);
            this.tabctrlLoc.Name = "tabctrlLoc";
            this.tabctrlLoc.SelectedIndex = 0;
            this.tabctrlLoc.Size = new System.Drawing.Size(919, 568);
            this.tabctrlLoc.TabIndex = 1;
            // 
            // tabpagLoca
            // 
            this.tabpagLoca.Controls.Add(this.grpValor);
            this.tabpagLoca.Controls.Add(this.btnCancel);
            this.tabpagLoca.Controls.Add(this.btnCon);
            this.tabpagLoca.Controls.Add(this.groupBox4);
            this.tabpagLoca.Controls.Add(this.groupBox3);
            this.tabpagLoca.Controls.Add(this.groupBox1);
            this.tabpagLoca.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagLoca.Location = new System.Drawing.Point(4, 28);
            this.tabpagLoca.Name = "tabpagLoca";
            this.tabpagLoca.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagLoca.Size = new System.Drawing.Size(911, 536);
            this.tabpagLoca.TabIndex = 0;
            this.tabpagLoca.Text = "Reserva";
            this.tabpagLoca.UseVisualStyleBackColor = true;
            // 
            // grpValor
            // 
            this.grpValor.Controls.Add(this.rbtnCtrl);
            this.grpValor.Controls.Add(this.rbtnLivre);
            this.grpValor.Controls.Add(this.txtValorTotal);
            this.grpValor.Controls.Add(this.txtValorDia);
            this.grpValor.Location = new System.Drawing.Point(609, 209);
            this.grpValor.Name = "grpValor";
            this.grpValor.Size = new System.Drawing.Size(250, 110);
            this.grpValor.TabIndex = 5;
            this.grpValor.TabStop = false;
            this.grpValor.Text = "Valor Estimado";
            // 
            // rbtnCtrl
            // 
            this.rbtnCtrl.AutoSize = true;
            this.rbtnCtrl.Location = new System.Drawing.Point(120, 80);
            this.rbtnCtrl.Name = "rbtnCtrl";
            this.rbtnCtrl.Size = new System.Drawing.Size(126, 20);
            this.rbtnCtrl.TabIndex = 3;
            this.rbtnCtrl.TabStop = true;
            this.rbtnCtrl.Text = "Km Control";
            this.rbtnCtrl.UseVisualStyleBackColor = true;
            this.rbtnCtrl.CheckedChanged += new System.EventHandler(this.rbtnCtrl_CheckedChanged);
            // 
            // rbtnLivre
            // 
            this.rbtnLivre.AutoSize = true;
            this.rbtnLivre.Location = new System.Drawing.Point(5, 80);
            this.rbtnLivre.Name = "rbtnLivre";
            this.rbtnLivre.Size = new System.Drawing.Size(106, 20);
            this.rbtnLivre.TabIndex = 2;
            this.rbtnLivre.TabStop = true;
            this.rbtnLivre.Text = "Km livre";
            this.rbtnLivre.UseVisualStyleBackColor = true;
            this.rbtnLivre.CheckedChanged += new System.EventHandler(this.rbtnLivre_CheckedChanged);
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
            this.btnCancel.Location = new System.Drawing.Point(753, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 87);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.White;
            this.btnCon.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.Image = global::Pim.Patriot.LocRev.Properties.Resources.carroComRelogioEmCima50x50;
            this.btnCon.Location = new System.Drawing.Point(602, 345);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(120, 87);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "Reservar";
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
            this.groupBox4.Location = new System.Drawing.Point(17, 209);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.txtCat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPlaca);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(463, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 146);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Veículo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(425, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(444, 114);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(234, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Km controlado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Km livre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipos de Locação";
            // 
            // txtCat
            // 
            this.txtCat.Enabled = false;
            this.txtCat.Location = new System.Drawing.Point(149, 85);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(219, 23);
            this.txtCat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoria:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(149, 46);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(219, 23);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Placa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFun);
            this.groupBox1.Controls.Add(this.lblAten);
            this.groupBox1.Controls.Add(this.txtCli);
            this.groupBox1.Controls.Add(this.lblCli);
            this.groupBox1.Controls.Add(this.txtCpf_Cnpj);
            this.groupBox1.Controls.Add(this.lblCPF_CNPJ);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 146);
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
            this.tabpagPesq.Text = "Pesquisa Reserva";
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
            this.ret,
            this.dev,
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
            this.grpPesquisa.Controls.Add(this.txtCodRes);
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
            // txtCodRes
            // 
            this.txtCodRes.Location = new System.Drawing.Point(188, 64);
            this.txtCodRes.Name = "txtCodRes";
            this.txtCodRes.Size = new System.Drawing.Size(123, 23);
            this.txtCodRes.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód. da Reserva:";
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
            // 
            // calendarDE
            // 
            this.calendarDE.Location = new System.Drawing.Point(28, 28);
            this.calendarDE.Name = "calendarDE";
            this.calendarDE.ShowToday = false;
            this.calendarDE.TabIndex = 4;
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
            // ret
            // 
            this.ret.DataPropertyName = "ret";
            this.ret.HeaderText = "Retirada";
            this.ret.Name = "ret";
            // 
            // dev
            // 
            this.dev.DataPropertyName = "dev";
            this.dev.HeaderText = "Devolução";
            this.dev.Name = "dev";
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
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.LocRev.Properties.Resources.backgroundPretoBranco1040x588;
            this.ClientSize = new System.Drawing.Size(957, 601);
            this.Controls.Add(this.tabctrlLoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.tabctrlLoc.ResumeLayout(false);
            this.tabpagLoca.ResumeLayout(false);
            this.grpValor.ResumeLayout(false);
            this.grpValor.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpValor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorDia;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label lblRetirada;
        private System.Windows.Forms.MonthCalendar calendarRetorno;
        private System.Windows.Forms.MonthCalendar calendarRetirada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFun;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.TextBox txtCpf_Cnpj;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.TabPage tabpagPesq;
        private System.Windows.Forms.DataGridView grvLoc;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVec;
        private System.Windows.Forms.TextBox txtCodRes;
        private System.Windows.Forms.TextBox txtCodCLi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPcli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarATE;
        private System.Windows.Forms.MonthCalendar calendarDE;
        private System.Windows.Forms.RadioButton rbtnCtrl;
        private System.Windows.Forms.RadioButton rbtnLivre;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ret;
        private System.Windows.Forms.DataGridViewTextBoxColumn dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}