namespace Pim.Patriot.CadAce
{
    partial class frmCadAce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAce));
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDados
            // 
            this.gbxDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDados.Controls.Add(this.txtPreco);
            this.gbxDados.Controls.Add(this.lblPreco);
            this.gbxDados.Controls.Add(this.txtNome);
            this.gbxDados.Controls.Add(this.lblNome);
            this.gbxDados.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic);
            this.gbxDados.Location = new System.Drawing.Point(77, 54);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(407, 174);
            this.gbxDados.TabIndex = 0;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Acessório";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtPreco.Location = new System.Drawing.Point(105, 102);
            this.txtPreco.MaxLength = 30;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(225, 26);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreco.Location = new System.Drawing.Point(34, 105);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(65, 20);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço :";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtNome.Location = new System.Drawing.Point(105, 43);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 26);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(34, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome :";
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancela.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancela.Image = global::Pim.Patriot.CadAce.Properties.Resources.cross49x51;
            this.btnCancela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancela.Location = new System.Drawing.Point(392, 289);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(154, 57);
            this.btnCancela.TabIndex = 17;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = global::Pim.Patriot.CadAce.Properties.Resources.faxineira40x51;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(204, 289);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Pim.Patriot.CadAce.Properties.Resources.disquete50x51;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(10, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadAce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim.Patriot.CadAce.Properties.Resources.backgroundPretoBranco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 382);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadAce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Acessórios";
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}