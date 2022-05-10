namespace ProyectoAdmnBD
{
    partial class AgregarPan
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
            this.txtAgregarCostoPan = new System.Windows.Forms.TextBox();
            this.txtAgregarPan = new System.Windows.Forms.TextBox();
            this.lblAgregarCostoPan = new System.Windows.Forms.Label();
            this.lblAgregarPan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarPan
            // 
            this.btnGuardarPan.Location = new System.Drawing.Point(153, 169);
            this.btnGuardarPan.Name = "btnGuardarPan";
            this.btnGuardarPan.Size = new System.Drawing.Size(112, 34);
            this.btnGuardarPan.TabIndex = 9;
            this.btnGuardarPan.Text = "Guardar";
            this.btnGuardarPan.UseVisualStyleBackColor = true;
            this.btnGuardarPan.Click += new System.EventHandler(this.btnGuardarPan_Click);
            // 
            // txtAgregarCostoPan
            // 
            this.txtAgregarCostoPan.Location = new System.Drawing.Point(131, 108);
            this.txtAgregarCostoPan.Name = "txtAgregarCostoPan";
            this.txtAgregarCostoPan.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarCostoPan.TabIndex = 8;
            this.txtAgregarCostoPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAgregarPan
            // 
            this.txtAgregarPan.Location = new System.Drawing.Point(131, 55);
            this.txtAgregarPan.Name = "txtAgregarPan";
            this.txtAgregarPan.Size = new System.Drawing.Size(150, 31);
            this.txtAgregarPan.TabIndex = 7;
            // 
            // lblAgregarCostoPan
            // 
            this.lblAgregarCostoPan.AutoSize = true;
            this.lblAgregarCostoPan.Location = new System.Drawing.Point(53, 108);
            this.lblAgregarCostoPan.Name = "lblAgregarCostoPan";
            this.lblAgregarCostoPan.Size = new System.Drawing.Size(59, 25);
            this.lblAgregarCostoPan.TabIndex = 6;
            this.lblAgregarCostoPan.Text = "Costo";
            // 
            // lblAgregarPan
            // 
            this.lblAgregarPan.AutoSize = true;
            this.lblAgregarPan.Location = new System.Drawing.Point(53, 55);
            this.lblAgregarPan.Name = "lblAgregarPan";
            this.lblAgregarPan.Size = new System.Drawing.Size(78, 25);
            this.lblAgregarPan.TabIndex = 5;
            this.lblAgregarPan.Text = "Nombre";
            // 
            // AgregarPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.btnGuardarPan);
            this.Controls.Add(this.txtAgregarCostoPan);
            this.Controls.Add(this.txtAgregarPan);
            this.Controls.Add(this.lblAgregarCostoPan);
            this.Controls.Add(this.lblAgregarPan);
            this.Name = "AgregarPan";
            this.Text = "AgregarPan";
            this.Load += new System.EventHandler(this.AgregarPan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarPan;
        private TextBox txtAgregarCostoPan;
        private TextBox txtAgregarPan;
        private Label lblAgregarCostoPan;
        private Label lblAgregarPan;
    }
}