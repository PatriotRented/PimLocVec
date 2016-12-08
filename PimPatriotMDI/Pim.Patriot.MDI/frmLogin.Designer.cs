namespace Pim.Patriot.MDI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnCadUsu = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfLogin1 = new Pim.Patriot.MDI.wpfLogin(this);
            this.SuspendLayout();
            // 
            // btnCadUsu
            // 
            this.btnCadUsu.BackgroundImage = global::Pim.Patriot.MDI.Properties.Resources.CadUsu;
            this.btnCadUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadUsu.Location = new System.Drawing.Point(442, 4);
            this.btnCadUsu.Name = "btnCadUsu";
            this.btnCadUsu.Size = new System.Drawing.Size(35, 35);
            this.btnCadUsu.TabIndex = 1;
            this.btnCadUsu.UseVisualStyleBackColor = true;
            this.btnCadUsu.Click += new System.EventHandler(this.btnCadUsu_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(477, 321);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.wpfLogin1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 321);
            this.Controls.Add(this.btnCadUsu);
            this.Controls.Add(this.elementHost1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button btnCadUsu;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private wpfLogin wpfLogin1;
    }
}