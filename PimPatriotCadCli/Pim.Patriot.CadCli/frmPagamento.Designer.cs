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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.gbxVistoria = new System.Windows.Forms.GroupBox();
            this.gbxPagamento = new System.Windows.Forms.GroupBox();
            this.txtPagamento1 = new System.Windows.Forms.TextBox();
            this.txtPagamento2 = new System.Windows.Forms.TextBox();
            this.txtPagamento3 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxClienteVeiculo.SuspendLayout();
            this.gbxPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClienteVeiculo
            // 
            this.gbxClienteVeiculo.Controls.Add(this.txtReal);
            this.gbxClienteVeiculo.Controls.Add(this.txtPre);
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
            this.gbxClienteVeiculo.Text = "Dados de Cliente/Veiculo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(21, 47);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(21, 106);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(73, 20);
            this.lblVeiculo.TabIndex = 1;
            this.lblVeiculo.Text = "Veiculo:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(97, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(97, 100);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(197, 26);
            this.txtVeiculo.TabIndex = 3;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(392, 52);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(121, 20);
            this.lblPre.TabIndex = 4;
            this.lblPre.Text = "Data Dev Pre:";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(392, 106);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(131, 20);
            this.lblReal.TabIndex = 5;
            this.lblReal.Text = "Data Dev Real:";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(538, 46);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(197, 26);
            this.txtPre.TabIndex = 6;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(538, 100);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(197, 26);
            this.txtReal.TabIndex = 7;
            // 
            // gbxVistoria
            // 
            this.gbxVistoria.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVistoria.Location = new System.Drawing.Point(98, 257);
            this.gbxVistoria.Name = "gbxVistoria";
            this.gbxVistoria.Size = new System.Drawing.Size(478, 313);
            this.gbxVistoria.TabIndex = 8;
            this.gbxVistoria.TabStop = false;
            this.gbxVistoria.Text = "Dados da Vistoria";
            // 
            // gbxPagamento
            // 
            this.gbxPagamento.Controls.Add(this.txtPagamento3);
            this.gbxPagamento.Controls.Add(this.txtPagamento2);
            this.gbxPagamento.Controls.Add(this.txtPagamento1);
            this.gbxPagamento.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPagamento.Location = new System.Drawing.Point(608, 257);
            this.gbxPagamento.Name = "gbxPagamento";
            this.gbxPagamento.Size = new System.Drawing.Size(287, 180);
            this.gbxPagamento.TabIndex = 9;
            this.gbxPagamento.TabStop = false;
            this.gbxPagamento.Text = "Método de Pagamento";
            // 
            // txtPagamento1
            // 
            this.txtPagamento1.Location = new System.Drawing.Point(57, 36);
            this.txtPagamento1.Name = "txtPagamento1";
            this.txtPagamento1.Size = new System.Drawing.Size(197, 26);
            this.txtPagamento1.TabIndex = 8;
            // 
            // txtPagamento2
            // 
            this.txtPagamento2.Location = new System.Drawing.Point(57, 82);
            this.txtPagamento2.Name = "txtPagamento2";
            this.txtPagamento2.Size = new System.Drawing.Size(197, 26);
            this.txtPagamento2.TabIndex = 8;
            // 
            // txtPagamento3
            // 
            this.txtPagamento3.Location = new System.Drawing.Point(57, 124);
            this.txtPagamento3.Name = "txtPagamento3";
            this.txtPagamento3.Size = new System.Drawing.Size(197, 26);
            this.txtPagamento3.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Pim.Patriot.CadCli.Properties.Resources.disquete50x51;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(593, 471);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::Pim.Patriot.CadCli.Properties.Resources.cross49x51;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(788, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 57);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = global::Pim.Patriot.CadCli.Properties.Resources.faxineira40x51;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(692, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadCli.Properties.Resources.backgroundPretoBranco1920x1086;
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
            this.gbxPagamento.ResumeLayout(false);
            this.gbxPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClienteVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox gbxVistoria;
        private System.Windows.Forms.GroupBox gbxPagamento;
        private System.Windows.Forms.TextBox txtPagamento3;
        private System.Windows.Forms.TextBox txtPagamento2;
        private System.Windows.Forms.TextBox txtPagamento1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
    }
}