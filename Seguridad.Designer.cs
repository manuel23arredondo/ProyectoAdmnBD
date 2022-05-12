namespace ProyectoAdmnBD
{
    partial class Seguridad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarSeguridad = new System.Windows.Forms.Button();
            this.btnEditSeguridad = new System.Windows.Forms.Button();
            this.btnElimSeguridad = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbPantalla = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pantalla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardarSeguridad
            // 
            this.btnGuardarSeguridad.Location = new System.Drawing.Point(34, 170);
            this.btnGuardarSeguridad.Name = "btnGuardarSeguridad";
            this.btnGuardarSeguridad.Size = new System.Drawing.Size(94, 29);
            this.btnGuardarSeguridad.TabIndex = 2;
            this.btnGuardarSeguridad.Text = "Guardar";
            this.btnGuardarSeguridad.UseVisualStyleBackColor = true;
            // 
            // btnEditSeguridad
            // 
            this.btnEditSeguridad.Location = new System.Drawing.Point(157, 170);
            this.btnEditSeguridad.Name = "btnEditSeguridad";
            this.btnEditSeguridad.Size = new System.Drawing.Size(94, 29);
            this.btnEditSeguridad.TabIndex = 3;
            this.btnEditSeguridad.Text = "Editar";
            this.btnEditSeguridad.UseVisualStyleBackColor = true;
            // 
            // btnElimSeguridad
            // 
            this.btnElimSeguridad.Location = new System.Drawing.Point(272, 170);
            this.btnElimSeguridad.Name = "btnElimSeguridad";
            this.btnElimSeguridad.Size = new System.Drawing.Size(94, 29);
            this.btnElimSeguridad.TabIndex = 4;
            this.btnElimSeguridad.Text = "Eliminar";
            this.btnElimSeguridad.UseVisualStyleBackColor = true;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(134, 98);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(151, 28);
            this.cbUsuario.TabIndex = 5;
            // 
            // cbPantalla
            // 
            this.cbPantalla.FormattingEnabled = true;
            this.cbPantalla.Location = new System.Drawing.Point(134, 39);
            this.cbPantalla.Name = "cbPantalla";
            this.cbPantalla.Size = new System.Drawing.Size(151, 28);
            this.cbPantalla.TabIndex = 6;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 236);
            this.Controls.Add(this.cbPantalla);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btnElimSeguridad);
            this.Controls.Add(this.btnEditSeguridad);
            this.Controls.Add(this.btnGuardarSeguridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Seguridad";
            this.Text = "Seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnGuardarSeguridad;
        private Button btnEditSeguridad;
        private Button btnElimSeguridad;
        private ComboBox cbUsuario;
        private ComboBox cbPantalla;
    }
}