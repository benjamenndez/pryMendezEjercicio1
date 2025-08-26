namespace pryMendezEjercicio1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            lblModulo = new Label();
            txtContraseña = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ComboBoxModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(239, 158);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F);
            lblContraseña.Location = new Point(239, 200);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(89, 21);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(343, 156);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(137, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 12F);
            lblModulo.Location = new Point(239, 239);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(64, 21);
            lblModulo.TabIndex = 3;
            lblModulo.Text = "Modulo";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(343, 198);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(137, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(536, 156);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(536, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ComboBoxModulo
            // 
            ComboBoxModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxModulo.Enabled = false;
            ComboBoxModulo.FormattingEnabled = true;
            ComboBoxModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            ComboBoxModulo.Location = new Point(343, 237);
            ComboBoxModulo.Name = "ComboBoxModulo";
            ComboBoxModulo.Size = new Size(137, 23);
            ComboBoxModulo.TabIndex = 7;
            ComboBoxModulo.SelectedIndexChanged += ComboBoxModulo_SelectedIndexChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBoxModulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(lblModulo);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private Label lblModulo;
        private TextBox txtContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox ComboBoxModulo;
    }
}
