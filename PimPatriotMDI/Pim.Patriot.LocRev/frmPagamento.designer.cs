namespace Pim.Patriot.CadCli
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.gbxClienteVeiculo = new System.Windows.Forms.GroupBox();
            this.txtCodLoc = new System.Windows.Forms.TextBox();
            this.lblCodLoc = new System.Windows.Forms.Label();
            this.mdtxtPre = new System.Windows.Forms.MaskedTextBox();
            this.mdtxtDevReal = new System.Windows.Forms.MaskedTextBox();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbxVistoria = new System.Windows.Forms.GroupBox();
            this.browse = new System.Windows.Forms.WebBrowser();
            this.gbxPagamento = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPagNum = new System.Windows.Forms.TextBox();
            this.txtPagBan = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxClienteVeiculo.SuspendLayout();
            this.gbxVistoria.SuspendLayout();
            this.gbxPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClienteVeiculo
            // 
            this.gbxClienteVeiculo.Controls.Add(this.txtCodLoc);
            this.gbxClienteVeiculo.Controls.Add(this.lblCodLoc);
            this.gbxClienteVeiculo.Controls.Add(this.mdtxtPre);
            this.gbxClienteVeiculo.Controls.Add(this.mdtxtDevReal);
            this.gbxClienteVeiculo.Controls.Add(this.lblReal);
            this.gbxClienteVeiculo.Controls.Add(this.lblPre);
            this.gbxClienteVeiculo.Controls.Add(this.txtVeiculo);
            this.gbxClienteVeiculo.Controls.Add(this.txtCliente);
            this.gbxClienteVeiculo.Controls.Add(this.lblVeiculo);
            this.gbxClienteVeiculo.Controls.Add(this.lblCliente);
            this.gbxClienteVeiculo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClienteVeiculo.Location = new System.Drawing.Point(98, 28);
            this.gbxClienteVeiculo.Name = "gbxClienteVeiculo";
            this.gbxClienteVeiculo.Size = new System.Drawing.Size(797, 178);
            this.gbxClienteVeiculo.TabIndex = 0;
            this.gbxClienteVeiculo.TabStop = false;
            this.gbxClienteVeiculo.Text = "Dados da locação ";
            // 
            // txtCodLoc
            // 
            this.txtCodLoc.Location = new System.Drawing.Point(36, 111);
            this.txtCodLoc.Name = "txtCodLoc";
            this.txtCodLoc.Size = new System.Drawing.Size(100, 26);
            this.txtCodLoc.TabIndex = 19;
            this.txtCodLoc.TextChanged += new System.EventHandler(this.txtCodLoc_TextChanged);
            this.txtCodLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodLoc_KeyPress);
            // 
            // lblCodLoc
            // 
            this.lblCodLoc.AutoSize = true;
            this.lblCodLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodLoc.Location = new System.Drawing.Point(48, 41);
            this.lblCodLoc.Name = "lblCodLoc";
            this.lblCodLoc.Size = new System.Drawing.Size(77, 60);
            this.lblCodLoc.TabIndex = 18;
            this.lblCodLoc.Text = "Código \r\nda \r\nLocação";
            this.lblCodLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mdtxtPre
            // 
            this.mdtxtPre.Enabled = false;
            this.mdtxtPre.Location = new System.Drawing.Point(643, 48);
            this.mdtxtPre.Mask = "00/00/0000";
            this.mdtxtPre.Name = "mdtxtPre";
            this.mdtxtPre.Size = new System.Drawing.Size(100, 26);
            this.mdtxtPre.TabIndex = 17;
            this.mdtxtPre.ValidatingType = typeof(System.DateTime);
            // 
            // mdtxtDevReal
            // 
            this.mdtxtDevReal.Location = new System.Drawing.Point(643, 106);
            this.mdtxtDevReal.Mask = "00/00/0000";
            this.mdtxtDevReal.Name = "mdtxtDevReal";
            this.mdtxtDevReal.Size = new System.Drawing.Size(100, 26);
            this.mdtxtDevReal.TabIndex = 16;
            this.mdtxtDevReal.ValidatingType = typeof(System.DateTime);
            this.mdtxtDevReal.TextChanged += new System.EventHandler(this.mdtxtDevReal_TextChanged);
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(497, 109);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(131, 20);
            this.lblReal.TabIndex = 5;
            this.lblReal.Text = "Data Dev Real:";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(497, 48);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(121, 20);
            this.lblPre.TabIndex = 4;
            this.lblPre.Text = "Data Dev Pre:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Enabled = false;
            this.txtVeiculo.Location = new System.Drawing.Point(278, 106);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(197, 26);
            this.txtVeiculo.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(278, 48);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(202, 109);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(73, 20);
            this.lblVeiculo.TabIndex = 1;
            this.lblVeiculo.Text = "Veiculo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(202, 48);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // gbxVistoria
            // 
            this.gbxVistoria.Controls.Add(this.browse);
            this.gbxVistoria.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVistoria.Location = new System.Drawing.Point(98, 257);
            this.gbxVistoria.Name = "gbxVistoria";
            this.gbxVistoria.Size = new System.Drawing.Size(478, 313);
            this.gbxVistoria.TabIndex = 8;
            this.gbxVistoria.TabStop = false;
            this.gbxVistoria.Text = "Termo de Devolução";
            // 
            // browse
            // 
            this.browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browse.Location = new System.Drawing.Point(3, 22);
            this.browse.MinimumSize = new System.Drawing.Size(20, 20);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(472, 288);
            this.browse.TabIndex = 0;
            this.browse.Url = new System.Uri("http://localhost:49902/Devolucao.aspx", System.UriKind.Absolute);
            // 
            // gbxPagamento
            // 
            this.gbxPagamento.Controls.Add(this.txtValorTotal);
            this.gbxPagamento.Controls.Add(this.txtPagNum);
            this.gbxPagamento.Controls.Add(this.txtPagBan);
            this.gbxPagamento.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPagamento.Location = new System.Drawing.Point(608, 257);
            this.gbxPagamento.Name = "gbxPagamento";
            this.gbxPagamento.Size = new System.Drawing.Size(287, 180);
            this.gbxPagamento.TabIndex = 9;
            this.gbxPagamento.TabStop = false;
            this.gbxPagamento.Text = "Método de Pagamento";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(57, 124);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(197, 26);
            this.txtValorTotal.TabIndex = 8;
            this.txtValorTotal.Text = "Valor Total";
            // 
            // txtPagNum
            // 
            this.txtPagNum.Location = new System.Drawing.Point(57, 82);
            this.txtPagNum.Name = "txtPagNum";
            this.txtPagNum.Size = new System.Drawing.Size(197, 26);
            this.txtPagNum.TabIndex = 8;
            this.txtPagNum.Text = "Número";
            this.txtPagNum.Click += new System.EventHandler(this.txtPagNum_Click);
            this.txtPagNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagNum_KeyPress);
            // 
            // txtPagBan
            // 
            this.txtPagBan.Location = new System.Drawing.Point(57, 36);
            this.txtPagBan.Name = "txtPagBan";
            this.txtPagBan.Size = new System.Drawing.Size(197, 26);
            this.txtPagBan.TabIndex = 8;
            this.txtPagBan.Text = "Bandeira";
            this.txtPagBan.Click += new System.EventHandler(this.txtPagBan_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = global::Pim.Patriot.LocRev.Properties.Resources.faxineira40x51;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(692, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::Pim.Patriot.LocRev.Properties.Resources.cross49x51;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(788, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 57);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Pim.Patriot.LocRev.Properties.Resources.disquete50x51;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(593, 471);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.LocRev.Properties.Resources.backgroundPretoBranco1040x588;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 624);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxPagamento);
            this.Controls.Add(this.gbxVistoria);
            this.Controls.Add(this.gbxClienteVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.gbxClienteVeiculo.ResumeLayout(false);
            this.gbxClienteVeiculo.PerformLayout();
            this.gbxVistoria.ResumeLayout(false);
            this.gbxPagamento.ResumeLayout(false);
            this.gbxPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClienteVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox gbxVistoria;
        private System.Windows.Forms.GroupBox gbxPagamento;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPagNum;
        private System.Windows.Forms.TextBox txtPagBan;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.WebBrowser browse;
        private System.Windows.Forms.TextBox txtCodLoc;
        private System.Windows.Forms.Label lblCodLoc;
        private System.Windows.Forms.MaskedTextBox mdtxtPre;
        private System.Windows.Forms.MaskedTextBox mdtxtDevReal;
    }
}