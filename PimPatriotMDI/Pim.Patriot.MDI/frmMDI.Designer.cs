namespace Pim.Patriot.MDI
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBarJudite = new System.Windows.Forms.ToolStripProgressBar();
            this.tsstEmp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDtHora = new System.Windows.Forms.Timer(this.components);
            this.mstripVertical = new System.Windows.Forms.MenuStrip();
            this.menuItemLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPagHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripHorizontal = new System.Windows.Forms.MenuStrip();
            this.menuItemCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadAce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadClien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadFun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadVec = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsAce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsFun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsVec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFinan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEfetuarPag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemdescontos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.taxasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.mstripVertical.SuspendLayout();
            this.mstripHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBarJudite,
            this.tsstEmp,
            this.tssthora});
            this.statusStrip1.Location = new System.Drawing.Point(158, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBarJudite
            // 
            this.ProgressBarJudite.AutoSize = false;
            this.ProgressBarJudite.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBarJudite.ForeColor = System.Drawing.SystemColors.Control;
            this.ProgressBarJudite.Name = "ProgressBarJudite";
            this.ProgressBarJudite.Size = new System.Drawing.Size(800, 16);
            this.ProgressBarJudite.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tsstEmp
            // 
            this.tsstEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsstEmp.Name = "tsstEmp";
            this.tsstEmp.Size = new System.Drawing.Size(63, 17);
            this.tsstEmp.Text = "CrazySoft |";
            this.tsstEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssthora
            // 
            this.tssthora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssthora.Name = "tssthora";
            this.tssthora.Size = new System.Drawing.Size(46, 17);
            this.tssthora.Text = "papapa";
            this.tssthora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDtHora
            // 
            this.timerDtHora.Enabled = true;
            this.timerDtHora.Interval = 1000;
            this.timerDtHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mstripVertical
            // 
            this.mstripVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(43)))));
            this.mstripVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.mstripVertical.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstripVertical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogo,
            this.menuItemLoca,
            this.menuItemReserva,
            this.menuItemPagHoriz});
            this.mstripVertical.Location = new System.Drawing.Point(0, 0);
            this.mstripVertical.Name = "mstripVertical";
            this.mstripVertical.Size = new System.Drawing.Size(158, 587);
            this.mstripVertical.TabIndex = 1;
            this.mstripVertical.Text = "mstripVertical";
            // 
            // menuItemLogo
            // 
            this.menuItemLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemLogo.Image = global::Pim.Patriot.MDI.Properties.Resources.Logo140x121;
            this.menuItemLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemLogo.Name = "menuItemLogo";
            this.menuItemLogo.Size = new System.Drawing.Size(145, 125);
            this.menuItemLogo.Text = "logo";
            this.menuItemLogo.Click += new System.EventHandler(this.menuItemLogo_Click);
            // 
            // menuItemLoca
            // 
            this.menuItemLoca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemLoca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemLoca.Image = global::Pim.Patriot.MDI.Properties.Resources.carroComRelogioEmCimaComTexto85x85;
            this.menuItemLoca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemLoca.Name = "menuItemLoca";
            this.menuItemLoca.Size = new System.Drawing.Size(145, 89);
            this.menuItemLoca.Text = "Locação";
            // 
            // menuItemReserva
            // 
            this.menuItemReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemReserva.Image = global::Pim.Patriot.MDI.Properties.Resources.calendarioComUmRelogioOrange85x85;
            this.menuItemReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemReserva.Name = "menuItemReserva";
            this.menuItemReserva.Size = new System.Drawing.Size(145, 89);
            this.menuItemReserva.Text = "Reserva";
            // 
            // menuItemPagHoriz
            // 
            this.menuItemPagHoriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemPagHoriz.Image = global::Pim.Patriot.MDI.Properties.Resources.maoMoeda130x85;
            this.menuItemPagHoriz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemPagHoriz.Name = "menuItemPagHoriz";
            this.menuItemPagHoriz.Size = new System.Drawing.Size(145, 89);
            this.menuItemPagHoriz.Text = "Pagamentos";
            // 
            // mstripHorizontal
            // 
            this.mstripHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(43)))));
            this.mstripHorizontal.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstripHorizontal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadCli,
            this.consultaToolStripMenuItem,
            this.menuItemFinan,
            this.relatorioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstripHorizontal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mstripHorizontal.Location = new System.Drawing.Point(158, 0);
            this.mstripHorizontal.MdiWindowListItem = this.menuItemFinan;
            this.mstripHorizontal.Name = "mstripHorizontal";
            this.mstripHorizontal.Size = new System.Drawing.Size(1002, 124);
            this.mstripHorizontal.TabIndex = 3;
            this.mstripHorizontal.Text = "mstripHorizontal";
            // 
            // menuItemCadCli
            // 
            this.menuItemCadCli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadAce,
            this.menuItemCadClien,
            this.menuItemCadFun,
            this.menuItemCadVec});
            this.menuItemCadCli.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemCadCli.Image = global::Pim.Patriot.MDI.Properties.Resources.cadastroOrange80x91semtxtok;
            this.menuItemCadCli.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemCadCli.Name = "menuItemCadCli";
            this.menuItemCadCli.Size = new System.Drawing.Size(109, 120);
            this.menuItemCadCli.Text = "Cadastro";
            this.menuItemCadCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuItemCadAce
            // 
            this.menuItemCadAce.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemCadAce.Name = "menuItemCadAce";
            this.menuItemCadAce.Size = new System.Drawing.Size(203, 30);
            this.menuItemCadAce.Text = "Acessorios";
            this.menuItemCadAce.Click += new System.EventHandler(this.menuItemCadAce_Click);
            // 
            // menuItemCadClien
            // 
            this.menuItemCadClien.Name = "menuItemCadClien";
            this.menuItemCadClien.Size = new System.Drawing.Size(203, 30);
            this.menuItemCadClien.Text = "Cliente";
            // 
            // menuItemCadFun
            // 
            this.menuItemCadFun.Name = "menuItemCadFun";
            this.menuItemCadFun.Size = new System.Drawing.Size(203, 30);
            this.menuItemCadFun.Text = "Funcionario";
            // 
            // menuItemCadVec
            // 
            this.menuItemCadVec.Name = "menuItemCadVec";
            this.menuItemCadVec.Size = new System.Drawing.Size(203, 30);
            this.menuItemCadVec.Text = "Veiculos";
            this.menuItemCadVec.Click += new System.EventHandler(this.menuItemCadVec_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsAce,
            this.menuItemConsCli,
            this.menuItemConsFun,
            this.menuItemConsVec});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Image = global::Pim.Patriot.MDI.Properties.Resources.livrosCons80x91;
            this.consultaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 120);
            this.consultaToolStripMenuItem.Text = "Consultas";
            this.consultaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuItemConsAce
            // 
            this.menuItemConsAce.Name = "menuItemConsAce";
            this.menuItemConsAce.Size = new System.Drawing.Size(203, 30);
            this.menuItemConsAce.Text = "Acessorios";
            // 
            // menuItemConsCli
            // 
            this.menuItemConsCli.Name = "menuItemConsCli";
            this.menuItemConsCli.Size = new System.Drawing.Size(203, 30);
            this.menuItemConsCli.Text = "Cliente";
            // 
            // menuItemConsFun
            // 
            this.menuItemConsFun.Name = "menuItemConsFun";
            this.menuItemConsFun.Size = new System.Drawing.Size(203, 30);
            this.menuItemConsFun.Text = "Funcionario";
            // 
            // menuItemConsVec
            // 
            this.menuItemConsVec.Name = "menuItemConsVec";
            this.menuItemConsVec.Size = new System.Drawing.Size(203, 30);
            this.menuItemConsVec.Text = "Veiculos";
            // 
            // menuItemFinan
            // 
            this.menuItemFinan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEfetuarPag,
            this.menuItemdescontos,
            this.taxasToolStripMenuItem});
            this.menuItemFinan.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemFinan.Image = global::Pim.Patriot.MDI.Properties.Resources.dinheiro80x91semTXT;
            this.menuItemFinan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuItemFinan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemFinan.Name = "menuItemFinan";
            this.menuItemFinan.Size = new System.Drawing.Size(135, 120);
            this.menuItemFinan.Text = "Formas pag";
            this.menuItemFinan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuItemEfetuarPag
            // 
            this.MenuItemEfetuarPag.Name = "MenuItemEfetuarPag";
            this.MenuItemEfetuarPag.Size = new System.Drawing.Size(184, 30);
            this.MenuItemEfetuarPag.Text = "Concluir";
            // 
            // menuItemdescontos
            // 
            this.menuItemdescontos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.cadastroToolStripMenuItem2});
            this.menuItemdescontos.Name = "menuItemdescontos";
            this.menuItemdescontos.Size = new System.Drawing.Size(184, 30);
            this.menuItemdescontos.Text = "Descontos";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // cadastroToolStripMenuItem2
            // 
            this.cadastroToolStripMenuItem2.Name = "cadastroToolStripMenuItem2";
            this.cadastroToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
            this.cadastroToolStripMenuItem2.Text = "Cadastro";
            // 
            // taxasToolStripMenuItem
            // 
            this.taxasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem,
            this.cadastroToolStripMenuItem1});
            this.taxasToolStripMenuItem.Name = "taxasToolStripMenuItem";
            this.taxasToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.taxasToolStripMenuItem.Text = "Taxas";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.calcularToolStripMenuItem.Text = "Consulta";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioToolStripMenuItem.Image = global::Pim.Patriot.MDI.Properties.Resources.papelcomvistos80x91ok;
            this.relatorioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(113, 120);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1,
            this.manualToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Image = global::Pim.Patriot.MDI.Properties.Resources.duvida80x91certo;
            this.sobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(92, 120);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            this.sobreToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(159, 30);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconectarToolStripMenuItem.Image = global::Pim.Patriot.MDI.Properties.Resources.logoutSemTxt80x91;
            this.desconectarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(142, 120);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = global::Pim.Patriot.MDI.Properties.Resources.exit80x91semtxt;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(92, 120);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.MDI.Properties.Resources.backgroundPretoBranco1040x588;
            this.ClientSize = new System.Drawing.Size(1160, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mstripHorizontal);
            this.Controls.Add(this.mstripVertical);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMDI";
            this.Text = "PATRIOT RETEND - Locadora de Veículos desde 1500 ";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mstripVertical.ResumeLayout(false);
            this.mstripVertical.PerformLayout();
            this.mstripHorizontal.ResumeLayout(false);
            this.mstripHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mstripHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadCli;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadClien;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadVec;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadAce;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadFun;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemFinan;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEfetuarPag;
        private System.Windows.Forms.ToolStripMenuItem taxasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemdescontos;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsVec;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsCli;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsFun;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsAce;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogo;
        private System.Windows.Forms.ToolStripStatusLabel tsstEmp;
        private System.Windows.Forms.ToolStripStatusLabel tssthora;
        public System.Windows.Forms.Timer timerDtHora;
        public System.Windows.Forms.ToolStripProgressBar ProgressBarJudite;
        private System.Windows.Forms.MenuStrip mstripVertical;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoca;
        private System.Windows.Forms.ToolStripMenuItem menuItemReserva;
        private System.Windows.Forms.ToolStripMenuItem menuItemPagHoriz;
    }
}

