namespace ProyectoAdmnBD
{
    partial class AgregarIngrediente
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
            this.btnGuardarPan = new System.Windows.Forms.Button();
            this.txtAgregarIngred = new System.Windows.Forms.TextBox();
            this.lblAgregarPan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarPan
            // 
            this.btnGuardarPan.Location = new System.Drawing.Point(130, 94);
            this.btnGuardarPan.Name = "btnGuardarPan";
            this.btnGuardarPan.Size = new System.Drawing.Size(112, 34);
            this.btnGuardarPan.TabIndex = 14;
            this.btnGuardarPan.Text = "Guardar";
            this.btnGuardarPan.UseVisualStyleBackColor = true;
            this.btnGuardarPan.Click += new System.EventHandler(this.btnGuardarPan_Click);
            // 
            // txtAgregarIngred
            // 
            this.txtAgregarIngred.Location = new System.Drawing.Point(130, 33);
            this.txtAgregarIngred.Name = "txtAgregarIngred";
            this.txtAgregarIngred.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarIngred.TabIndex = 12;
            // 
            // lblAgregarPan
            // 
            this.lblAgregarPan.AutoSize = true;
            this.lblAgregarPan.Location = new System.Drawing.Point(52, 33);
            this.lblAgregarPan.Name = "lblAgregarPan";
            this.lblAgregarPan.Size = new System.Drawing.Size(78, 25);
            this.lblAgregarPan.TabIndex = 10;
            this.lblAgregarPan.Text = "Nombre";
            // 
            // AgregarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 151);
            this.Controls.Add(this.btnGuardarPan);
            this.Controls.Add(this.txtAgregarIngred);
            this.Controls.Add(this.lblAgregarPan);
            this.Name = "AgregarIngrediente";
            this.Text = "AgregarIngrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarPan;
        private TextBox txtAgregarIngred;
        private Label lblAgregarPan;
    }
}