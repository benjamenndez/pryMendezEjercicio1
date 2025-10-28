namespace pryMendezEjercicio1
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            lblBienvenido = new Label();
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(87, 48);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(262, 50);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡ Bienvenido !";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Blue;
            lblLogo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(255, 224, 192);
            lblLogo.Location = new Point(77, 119);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(283, 50);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Sinterplast SRL";
            lblLogo.Click += lblLogo_Click;
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(436, 236);
            Controls.Add(lblLogo);
            Controls.Add(lblBienvenido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida Sinterplast SRL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblLogo;
    }
}