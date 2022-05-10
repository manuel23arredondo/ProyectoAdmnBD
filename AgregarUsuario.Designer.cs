namespace ProyectoAdmnBD
{
    partial class AgregarUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAgregarUser = new System.Windows.Forms.TextBox();
            this.txtAgregarPass = new System.Windows.Forms.TextBox();
            this.btnGuardarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(41, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtAgregarUser
            // 
            this.txtAgregarUser.Location = new System.Drawing.Point(119, 39);
            this.txtAgregarUser.Name = "txtAgregarUser";
            this.txtAgregarUser.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarUser.TabIndex = 2;
            // 
            // txtAgregarPass
            // 
            this.txtAgregarPass.Location = new System.Drawing.Point(119, 92);
            this.txtAgregarPass.Name = "txtAgregarPass";
            this.txtAgregarPass.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarPass.TabIndex = 3;
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.Location = new System.Drawing.Point(309, 112);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.Size = new System.Drawing.Size(112, 34);
            this.btnGuardarUser.TabIndex = 4;
            this.btnGuardarUser.Text = "Guardar";
            this.btnGuardarUser.UseVisualStyleBackColor = true;
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 158);
            this.Controls.Add(this.btnGuardarUser);
            this.Controls.Add(this.txtAgregarPass);
            this.Controls.Add(this.txtAgregarUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtAgregarUser;
        private TextBox txtAgregarPass;
        private Button btnGuardarUser;
    }
}