namespace Pim.Patriot.CadCli
{
    partial class CadastroCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCli));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.mdtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.mdtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.gbxAtributosCli = new System.Windows.Forms.GroupBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.mdtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.mdtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.mdtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.mdtxtDtnsc = new System.Windows.Forms.MaskedTextBox();
            this.lblDatans = new System.Windows.Forms.Label();
            this.mdtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.mdtxtCnh = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCnh = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxAtributosCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(137, 42);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(242, 25);
            this.txtNomeCli.TabIndex = 2;
            // 
            // mdtxtRG
            // 
            this.mdtxtRG.Location = new System.Drawing.Point(137, 81);
            this.mdtxtRG.Mask = "00.000.000-0";
            this.mdtxtRG.Name = "mdtxtRG";
            this.mdtxtRG.Size = new System.Drawing.Size(118, 25);
            this.mdtxtRG.TabIndex = 5;
            // 
            // mdtxtCpf
            // 
            this.mdtxtCpf.Location = new System.Drawing.Point(137, 135);
            this.mdtxtCpf.Mask = "000.000.000-00";
            this.mdtxtCpf.Name = "mdtxtCpf";
            this.mdtxtCpf.Size = new System.Drawing.Size(127, 25);
            this.mdtxtCpf.TabIndex = 7;
            // 
            // gbxAtributosCli
            // 
            this.gbxAtributosCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAtributosCli.AutoSize = true;
            this.gbxAtributosCli.Controls.Add(this.txtUf);
            this.gbxAtributosCli.Controls.Add(this.mdtxtTelefone);
            this.gbxAtributosCli.Controls.Add(this.lblTelefone);
            this.gbxAtributosCli.Controls.Add(this.txtCidade);
            this.gbxAtributosCli.Controls.Add(this.lblCidade);
            this.gbxAtributosCli.Controls.Add(this.mdtxtCep);
            this.gbxAtributosCli.Controls.Add(this.lblCep);
            this.gbxAtributosCli.Controls.Add(this.lblUf);
            this.gbxAtributosCli.Controls.Add(this.txtComplemento);
            this.gbxAtributosCli.Controls.Add(this.lblComplemento);
            this.gbxAtributosCli.Controls.Add(this.mdtxtNumero);
            this.gbxAtributosCli.Controls.Add(this.lblNumero);
            this.gbxAtributosCli.Controls.Add(this.txtBairro);
            this.gbxAtributosCli.Controls.Add(this.lblBairro);
            this.gbxAtributosCli.Controls.Add(this.txtRua);
            this.gbxAtributosCli.Controls.Add(this.lblRua);
            this.gbxAtributosCli.Controls.Add(this.lblLinha);
            this.gbxAtributosCli.Controls.Add(this.mdtxtDtnsc);
            this.gbxAtributosCli.Controls.Add(this.lblDatans);
            this.gbxAtributosCli.Controls.Add(this.mdtxtCnpj);
            this.gbxAtributosCli.Controls.Add(this.lblCnpj);
            this.gbxAtributosCli.Controls.Add(this.mdtxtCnh);
            this.gbxAtributosCli.Controls.Add(this.txtEmail);
            this.gbxAtributosCli.Controls.Add(this.lblRG);
            this.gbxAtributosCli.Controls.Add(this.lblCnh);
            this.gbxAtributosCli.Controls.Add(this.lblNome);
            this.gbxAtributosCli.Controls.Add(this.mdtxtCpf);
            this.gbxAtributosCli.Controls.Add(this.lblEmail);
            this.gbxAtributosCli.Controls.Add(this.mdtxtRG);
            this.gbxAtributosCli.Controls.Add(this.lblCpf);
            this.gbxAtributosCli.Controls.Add(this.txtNomeCli);
            this.gbxAtributosCli.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic);
            this.gbxAtributosCli.Location = new System.Drawing.Point(88, 36);
            this.gbxAtributosCli.Name = "gbxAtributosCli";
            this.gbxAtributosCli.Size = new System.Drawing.Size(717, 411);
            this.gbxAtributosCli.TabIndex = 11;
            this.gbxAtributosCli.TabStop = false;
            this.gbxAtributosCli.Text = "Cliente/PF-PJ";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(498, 276);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(66, 25);
            this.txtUf.TabIndex = 33;
            // 
            // mdtxtTelefone
            // 
            this.mdtxtTelefone.Location = new System.Drawing.Point(498, 180);
            this.mdtxtTelefone.Mask = "(99) 0000-0000";
            this.mdtxtTelefone.Name = "mdtxtTelefone";
            this.mdtxtTelefone.Size = new System.Drawing.Size(109, 25);
            this.mdtxtTelefone.TabIndex = 32;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefone.Location = new System.Drawing.Point(391, 179);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 20);
            this.lblTelefone.TabIndex = 31;
            this.lblTelefone.Text = "Telefone :";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(141, 362);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(242, 25);
            this.txtCidade.TabIndex = 30;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCidade.Location = new System.Drawing.Point(55, 362);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 20);
            this.lblCidade.TabIndex = 29;
            this.lblCidade.Text = "Cidade :";
            // 
            // mdtxtCep
            // 
            this.mdtxtCep.Location = new System.Drawing.Point(498, 320);
            this.mdtxtCep.Mask = "00000-000";
            this.mdtxtCep.Name = "mdtxtCep";
            this.mdtxtCep.Size = new System.Drawing.Size(100, 25);
            this.mdtxtCep.TabIndex = 28;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCep.Location = new System.Drawing.Point(429, 321);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(51, 20);
            this.lblCep.TabIndex = 27;
            this.lblCep.Text = "Cep :";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUf.Location = new System.Drawing.Point(437, 277);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(43, 20);
            this.lblUf.TabIndex = 25;
            this.lblUf.Text = "UF :";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtComplemento.Location = new System.Drawing.Point(141, 321);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(193, 25);
            this.txtComplemento.TabIndex = 24;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblComplemento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblComplemento.Location = new System.Drawing.Point(6, 326);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(129, 20);
            this.lblComplemento.TabIndex = 23;
            this.lblComplemento.Text = "Complemento :";
            // 
            // mdtxtNumero
            // 
            this.mdtxtNumero.Location = new System.Drawing.Point(498, 235);
            this.mdtxtNumero.Mask = "0000000";
            this.mdtxtNumero.Name = "mdtxtNumero";
            this.mdtxtNumero.Size = new System.Drawing.Size(66, 25);
            this.mdtxtNumero.TabIndex = 22;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumero.Location = new System.Drawing.Point(399, 235);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 20);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Numero :";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(137, 272);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(242, 25);
            this.txtBairro.TabIndex = 20;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBairro.Location = new System.Drawing.Point(40, 272);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(67, 20);
            this.lblBairro.TabIndex = 19;
            this.lblBairro.Text = "Bairro :";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(137, 235);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(242, 25);
            this.txtRua.TabIndex = 18;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRua.Location = new System.Drawing.Point(55, 235);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(52, 20);
            this.lblRua.TabIndex = 17;
            this.lblRua.Text = "Rua :";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(27, 207);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(673, 18);
            this.lblLinha.TabIndex = 16;
            this.lblLinha.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // mdtxtDtnsc
            // 
            this.mdtxtDtnsc.Location = new System.Drawing.Point(498, 130);
            this.mdtxtDtnsc.Mask = "00/00/0000";
            this.mdtxtDtnsc.Name = "mdtxtDtnsc";
            this.mdtxtDtnsc.Size = new System.Drawing.Size(100, 25);
            this.mdtxtDtnsc.TabIndex = 15;
            this.mdtxtDtnsc.ValidatingType = typeof(System.DateTime);
            // 
            // lblDatans
            // 
            this.lblDatans.AutoSize = true;
            this.lblDatans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDatans.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDatans.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatans.Location = new System.Drawing.Point(323, 130);
            this.lblDatans.Name = "lblDatans";
            this.lblDatans.Size = new System.Drawing.Size(157, 20);
            this.lblDatans.TabIndex = 14;
            this.lblDatans.Text = "Data Nascimento :";
            // 
            // mdtxtCnpj
            // 
            this.mdtxtCnpj.Location = new System.Drawing.Point(498, 81);
            this.mdtxtCnpj.Mask = "00.000.000/0000-00";
            this.mdtxtCnpj.Name = "mdtxtCnpj";
            this.mdtxtCnpj.Size = new System.Drawing.Size(199, 25);
            this.mdtxtCnpj.TabIndex = 13;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCnpj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCnpj.Location = new System.Drawing.Point(417, 86);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(63, 20);
            this.lblCnpj.TabIndex = 12;
            this.lblCnpj.Text = "CNPJ :";
            // 
            // mdtxtCnh
            // 
            this.mdtxtCnh.Location = new System.Drawing.Point(137, 179);
            this.mdtxtCnh.Mask = "00000000000";
            this.mdtxtCnh.Name = "mdtxtCnh";
            this.mdtxtCnh.Size = new System.Drawing.Size(118, 25);
            this.mdtxtCnh.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(498, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 25);
            this.txtEmail.TabIndex = 10;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRG.Location = new System.Drawing.Point(61, 86);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(46, 20);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG :";
            // 
            // lblCnh
            // 
            this.lblCnh.AutoSize = true;
            this.lblCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCnh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCnh.Location = new System.Drawing.Point(51, 180);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(56, 20);
            this.lblCnh.TabIndex = 8;
            this.lblCnh.Text = "CNH :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(42, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(417, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCpf.Location = new System.Drawing.Point(54, 135);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(53, 20);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Pim.Patriot.CadCli.Properties.Resources.disquete50x51;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(156, 471);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnLimpar.Location = new System.Drawing.Point(357, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 16;
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
            this.btnCancelar.Image = global::Pim.Patriot.CadCli.Properties.Resources.cross49x51;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(563, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 57);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadCli.Properties.Resources.backgroundPretoBranco1920x1086;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 549);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxAtributosCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAtributosCli.ResumeLayout(false);
            this.gbxAtributosCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.MaskedTextBox mdtxtRG;
        private System.Windows.Forms.MaskedTextBox mdtxtCpf;
        private System.Windows.Forms.GroupBox gbxAtributosCli;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mdtxtCnh;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mdtxtCnpj;
        private System.Windows.Forms.MaskedTextBox mdtxtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblDatans;
        private System.Windows.Forms.MaskedTextBox mdtxtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox mdtxtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.MaskedTextBox mdtxtDtnsc;
    }
}

