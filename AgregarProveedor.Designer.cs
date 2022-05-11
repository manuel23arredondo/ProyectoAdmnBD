namespace ProyectoAdmnBD
{
    partial class AgregarProveedor
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
            this.btnGuardarUser = new System.Windows.Forms.Button();
            this.txtCelProvee = new System.Windows.Forms.TextBox();
            this.txtAgregarProvee = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNumProvee = new System.Windows.Forms.TextBox();
            this.txtCalleProvee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColoniaProvee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.Location = new System.Drawing.Point(238, 256);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.Size = new System.Drawing.Size(112, 34);
            this.btnGuardarUser.TabIndex = 9;
            this.btnGuardarUser.Text = "Guardar";
            this.btnGuardarUser.UseVisualStyleBackColor = true;
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // txtCelProvee
            // 
            this.txtCelProvee.Location = new System.Drawing.Point(124, 92);
            this.txtCelProvee.Name = "txtCelProvee";
            this.txtCelProvee.Size = new System.Drawing.Size(150, 31);
            this.txtCelProvee.TabIndex = 8;
            // 
            // txtAgregarProvee
            // 
            this.txtAgregarProvee.Location = new System.Drawing.Point(124, 39);
            this.txtAgregarProvee.Name = "txtAgregarProvee";
            this.txtAgregarProvee.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarProvee.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(53, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 25);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Celular";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(46, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 25);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre";
            // 
            // txtNumProvee
            // 
            this.txtNumProvee.Location = new System.Drawing.Point(379, 149);
            this.txtNumProvee.Name = "txtNumProvee";
            this.txtNumProvee.Size = new System.Drawing.Size(150, 31);
            this.txtNumProvee.TabIndex = 13;
            // 
            // txtCalleProvee
            // 
            this.txtCalleProvee.Location = new System.Drawing.Point(124, 146);
            this.txtCalleProvee.Name = "txtCalleProvee";
            this.txtCalleProvee.Size = new System.Drawing.Size(150, 31);
            this.txtCalleProvee.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calle";
            // 
            // txtColoniaProvee
            // 
            this.txtColoniaProvee.Location = new System.Drawing.Point(637, 152);
            this.txtColoniaProvee.Name = "txtColoniaProvee";
            this.txtColoniaProvee.Size = new System.Drawing.Size(150, 31);
            this.txtColoniaProvee.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Colonia";
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 321);
            this.Controls.Add(this.txtColoniaProvee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumProvee);
            this.Controls.Add(this.txtCalleProvee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarUser);
            this.Controls.Add(this.txtCelProvee);
            this.Controls.Add(this.txtAgregarProvee);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarUser;
        private TextBox txtCelProvee;
        private TextBox txtAgregarProvee;
        private Label lblPassword;
        private Label lblUsuario;
        private TextBox txtNumProvee;
        private TextBox txtCalleProvee;
        private Label label1;
        private Label label2;
        private TextBox txtColoniaProvee;
        private Label label3;
    }
}