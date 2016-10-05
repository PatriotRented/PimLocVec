namespace Pim.Patriot.CadVecDesk
{
    partial class frmCadVec
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.gbxAtributosCar = new System.Windows.Forms.GroupBox();
            this.gbxAcessorio = new System.Windows.Forms.GroupBox();
            this.cmbAcessorio1 = new System.Windows.Forms.ComboBox();
            this.cmdAcessorio2 = new System.Windows.Forms.ComboBox();
            this.cmbAcessorio3 = new System.Windows.Forms.ComboBox();
            this.chkNtem = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.gbxAtributosCar.SuspendLayout();
            this.gbxAcessorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(23, 37);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(63, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPlaca.Location = new System.Drawing.Point(106, 34);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(176, 26);
            this.txtPlaca.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(23, 84);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 20);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo :";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(106, 81);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(176, 26);
            this.txtModelo.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(23, 133);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(68, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca :";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMarca.Location = new System.Drawing.Point(106, 130);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(176, 26);
            this.txtMarca.TabIndex = 5;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(360, 37);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(47, 20);
            this.lblCor.TabIndex = 6;
            this.lblCor.Text = "Cor :";
            // 
            // cmbCor
            // 
            this.cmbCor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Items.AddRange(new object[] {
            "Azul",
            "Branco",
            "Prata",
            "Preto",
            "Verde",
            "Vermelho"});
            this.cmbCor.Location = new System.Drawing.Point(441, 34);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(176, 26);
            this.cmbCor.TabIndex = 7;
            this.cmbCor.Text = "Escolha uma cor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(338, 84);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(97, 20);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(441, 81);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(207, 26);
            this.cmbCategoria.TabIndex = 9;
            this.cmbCategoria.Text = "Selecione uma categoria";
            // 
            // gbxAtributosCar
            // 
            this.gbxAtributosCar.Controls.Add(this.cmbCategoria);
            this.gbxAtributosCar.Controls.Add(this.lblModelo);
            this.gbxAtributosCar.Controls.Add(this.lblCategoria);
            this.gbxAtributosCar.Controls.Add(this.lblPlaca);
            this.gbxAtributosCar.Controls.Add(this.cmbCor);
            this.gbxAtributosCar.Controls.Add(this.txtPlaca);
            this.gbxAtributosCar.Controls.Add(this.lblCor);
            this.gbxAtributosCar.Controls.Add(this.txtModelo);
            this.gbxAtributosCar.Controls.Add(this.txtMarca);
            this.gbxAtributosCar.Controls.Add(this.lblMarca);
            this.gbxAtributosCar.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAtributosCar.Location = new System.Drawing.Point(41, 31);
            this.gbxAtributosCar.Name = "gbxAtributosCar";
            this.gbxAtributosCar.Size = new System.Drawing.Size(696, 198);
            this.gbxAtributosCar.TabIndex = 10;
            this.gbxAtributosCar.TabStop = false;
            this.gbxAtributosCar.Text = "Veículo";
            // 
            // gbxAcessorio
            // 
            this.gbxAcessorio.Controls.Add(this.chkNtem);
            this.gbxAcessorio.Controls.Add(this.cmbAcessorio3);
            this.gbxAcessorio.Controls.Add(this.cmdAcessorio2);
            this.gbxAcessorio.Controls.Add(this.cmbAcessorio1);
            this.gbxAcessorio.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic);
            this.gbxAcessorio.Location = new System.Drawing.Point(41, 253);
            this.gbxAcessorio.Name = "gbxAcessorio";
            this.gbxAcessorio.Size = new System.Drawing.Size(696, 148);
            this.gbxAcessorio.TabIndex = 11;
            this.gbxAcessorio.TabStop = false;
            this.gbxAcessorio.Text = "Acessórios";
            // 
            // cmbAcessorio1
            // 
            this.cmbAcessorio1.FormattingEnabled = true;
            this.cmbAcessorio1.Items.AddRange(new object[] {
            "DVD",
            "GPS",
            "Caderinha"});
            this.cmbAcessorio1.Location = new System.Drawing.Point(40, 52);
            this.cmbAcessorio1.Name = "cmbAcessorio1";
            this.cmbAcessorio1.Size = new System.Drawing.Size(173, 26);
            this.cmbAcessorio1.TabIndex = 10;
            // 
            // cmdAcessorio2
            // 
            this.cmdAcessorio2.FormattingEnabled = true;
            this.cmdAcessorio2.Items.AddRange(new object[] {
            "DVD",
            "GPS",
            "Caderinha"});
            this.cmdAcessorio2.Location = new System.Drawing.Point(247, 52);
            this.cmdAcessorio2.Name = "cmdAcessorio2";
            this.cmdAcessorio2.Size = new System.Drawing.Size(173, 26);
            this.cmdAcessorio2.TabIndex = 11;
            // 
            // cmbAcessorio3
            // 
            this.cmbAcessorio3.FormattingEnabled = true;
            this.cmbAcessorio3.Items.AddRange(new object[] {
            "DVD",
            "GPS",
            "Caderinha"});
            this.cmbAcessorio3.Location = new System.Drawing.Point(459, 52);
            this.cmbAcessorio3.Name = "cmbAcessorio3";
            this.cmbAcessorio3.Size = new System.Drawing.Size(173, 26);
            this.cmbAcessorio3.TabIndex = 12;
            // 
            // chkNtem
            // 
            this.chkNtem.AutoSize = true;
            this.chkNtem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkNtem.Location = new System.Drawing.Point(242, 107);
            this.chkNtem.Name = "chkNtem";
            this.chkNtem.Size = new System.Drawing.Size(178, 24);
            this.chkNtem.TabIndex = 13;
            this.chkNtem.Text = "Nenhum Acessório";
            this.chkNtem.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(100, 471);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 57);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(294, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 57);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(482, 471);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(154, 57);
            this.btnCancela.TabIndex = 14;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // frmCadVec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxAcessorio);
            this.Controls.Add(this.gbxAtributosCar);
            this.Name = "frmCadVec";
            this.Text = "Cadastro de veiculos";
            this.gbxAtributosCar.ResumeLayout(false);
            this.gbxAtributosCar.PerformLayout();
            this.gbxAcessorio.ResumeLayout(false);
            this.gbxAcessorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox gbxAtributosCar;
        private System.Windows.Forms.GroupBox gbxAcessorio;
        private System.Windows.Forms.CheckBox chkNtem;
        private System.Windows.Forms.ComboBox cmbAcessorio3;
        private System.Windows.Forms.ComboBox cmdAcessorio2;
        private System.Windows.Forms.ComboBox cmbAcessorio1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancela;
    }
}