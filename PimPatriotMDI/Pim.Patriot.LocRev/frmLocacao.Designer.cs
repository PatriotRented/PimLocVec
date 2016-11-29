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
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.tabctrlLoc.SuspendLayout();
            this.tabpagLoca.SuspendLayout();
            this.grpValor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grboxLoc.SuspendLayout();
            this.grbLoc2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabpagPesq.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagPesq.Location = new System.Drawing.Point(4, 28);
            this.tabpagPesq.Name = "tabpagPesq";
            this.tabpagPesq.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagPesq.Size = new System.Drawing.Size(911, 536);
            this.tabpagPesq.TabIndex = 1;
            this.tabpagPesq.Text = "Pesquisa locação";
            this.tabpagPesq.UseVisualStyleBackColor = true;
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
    }
}