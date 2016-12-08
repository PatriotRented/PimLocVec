namespace Pim.Patriot.MDI
{
    partial class frmCadLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLogin));
            this.grpDadosLog = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.grpbTipoLog = new System.Windows.Forms.GroupBox();
            this.rbtTecn = new System.Windows.Forms.RadioButton();
            this.rbtnCaixa = new System.Windows.Forms.RadioButton();
            this.rbtnAdm = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpDadosLog.SuspendLayout();
            this.grpbTipoLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosLog
            // 
            this.grpDadosLog.Controls.Add(this.txtSenha);
            this.grpDadosLog.Controls.Add(this.txtLogin);
            this.grpDadosLog.Controls.Add(this.lblSenha);
            this.grpDadosLog.Controls.Add(this.lblLogin);
            this.grpDadosLog.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosLog.Location = new System.Drawing.Point(29, 27);
            this.grpDadosLog.Name = "grpDadosLog";
            this.grpDadosLog.Size = new System.Drawing.Size(492, 162);
            this.grpDadosLog.TabIndex = 0;
            this.grpDadosLog.TabStop = false;
            this.grpDadosLog.Text = "Dados do Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(151, 92);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(151, 46);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(264, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(54, 95);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 22);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(54, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 22);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // grpbTipoLog
            // 
            this.grpbTipoLog.Controls.Add(this.rbtTecn);
            this.grpbTipoLog.Controls.Add(this.rbtnCaixa);
            this.grpbTipoLog.Controls.Add(this.rbtnAdm);
            this.grpbTipoLog.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTipoLog.Location = new System.Drawing.Point(29, 195);
            this.grpbTipoLog.Name = "grpbTipoLog";
            this.grpbTipoLog.Size = new System.Drawing.Size(492, 98);
            this.grpbTipoLog.TabIndex = 1;
            this.grpbTipoLog.TabStop = false;
            this.grpbTipoLog.Text = "Tipos de login";
            // 
            // rbtTecn
            // 
            this.rbtTecn.AutoSize = true;
            this.rbtTecn.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTecn.Location = new System.Drawing.Point(357, 48);
            this.rbtTecn.Name = "rbtTecn";
            this.rbtTecn.Size = new System.Drawing.Size(99, 26);
            this.rbtTecn.TabIndex = 2;
            this.rbtTecn.TabStop = true;
            this.rbtTecn.Text = "Suporte";
            this.rbtTecn.UseVisualStyleBackColor = true;
            this.rbtTecn.CheckedChanged += new System.EventHandler(this.rbtTecn_CheckedChanged);
            // 
            // rbtnCaixa
            // 
            this.rbtnCaixa.AutoSize = true;
            this.rbtnCaixa.Location = new System.Drawing.Point(197, 48);
            this.rbtnCaixa.Name = "rbtnCaixa";
            this.rbtnCaixa.Size = new System.Drawing.Size(120, 26);
            this.rbtnCaixa.TabIndex = 1;
            this.rbtnCaixa.TabStop = true;
            this.rbtnCaixa.Text = "Atendente";
            this.rbtnCaixa.UseVisualStyleBackColor = true;
            this.rbtnCaixa.CheckedChanged += new System.EventHandler(this.rbtnCaixa_CheckedChanged);
            // 
            // rbtnAdm
            // 
            this.rbtnAdm.AutoSize = true;
            this.rbtnAdm.Location = new System.Drawing.Point(41, 48);
            this.rbtnAdm.Name = "rbtnAdm";
            this.rbtnAdm.Size = new System.Drawing.Size(97, 26);
            this.rbtnAdm.TabIndex = 0;
            this.rbtnAdm.TabStop = true;
            this.rbtnAdm.Text = "Gerente";
            this.rbtnAdm.UseVisualStyleBackColor = true;
            this.rbtnAdm.CheckedChanged += new System.EventHandler(this.rbtnAdm_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = global::Pim.Patriot.MDI.Properties.Resources.faxineira40x51;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(201, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::Pim.Patriot.MDI.Properties.Resources.cross49x51;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(365, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 57);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Pim.Patriot.MDI.Properties.Resources.disquete50x51;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(29, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(553, 396);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpbTipoLog);
            this.Controls.Add(this.grpDadosLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadLogin";
            this.Text = "Cadastro de logins";
            this.grpDadosLog.ResumeLayout(false);
            this.grpDadosLog.PerformLayout();
            this.grpbTipoLog.ResumeLayout(false);
            this.grpbTipoLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosLog;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpbTipoLog;
        private System.Windows.Forms.RadioButton rbtTecn;
        private System.Windows.Forms.RadioButton rbtnCaixa;
        private System.Windows.Forms.RadioButton rbtnAdm;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}