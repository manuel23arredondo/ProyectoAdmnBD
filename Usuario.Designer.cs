namespace ProyectoAdmnBD
{
    partial class Usuario
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
            this.txtUserUsuario = new System.Windows.Forms.TextBox();
            this.txtContraUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.ComboBox();
            this.lblPuestoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(42, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUserUsuario
            // 
            this.txtUserUsuario.Location = new System.Drawing.Point(12, 99);
            this.txtUserUsuario.Name = "txtUserUsuario";
            this.txtUserUsuario.Size = new System.Drawing.Size(150, 31);
            this.txtUserUsuario.TabIndex = 1;
            // 
            // txtContraUsuario
            // 
            this.txtContraUsuario.Location = new System.Drawing.Point(178, 99);
            this.txtContraUsuario.Name = "txtContraUsuario";
            this.txtContraUsuario.Size = new System.Drawing.Size(150, 31);
            this.txtContraUsuario.TabIndex = 3;
            // 
            // lblContra
            // 
            this.lblContra.Location = new System.Drawing.Point(0, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(100, 23);
            this.lblContra.TabIndex = 6;
            // 
            // boxUsuario
            // 
            this.boxUsuario.FormattingEnabled = true;
            this.boxUsuario.Location = new System.Drawing.Point(351, 97);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(182, 33);
            this.boxUsuario.TabIndex = 4;
            // 
            // lblPuestoUsuario
            // 
            this.lblPuestoUsuario.AutoSize = true;
            this.lblPuestoUsuario.Location = new System.Drawing.Point(381, 51);
            this.lblPuestoUsuario.Name = "lblPuestoUsuario";
            this.lblPuestoUsuario.Size = new System.Drawing.Size(66, 25);
            this.lblPuestoUsuario.TabIndex = 5;
            this.lblPuestoUsuario.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuestoUsuario);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.txtContraUsuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtUserUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUserUsuario;
        private TextBox txtContraUsuario;
        private Label lblContra;
        private ComboBox boxUsuario;
        private Label lblPuestoUsuario;
        private Label label1;
    }
}