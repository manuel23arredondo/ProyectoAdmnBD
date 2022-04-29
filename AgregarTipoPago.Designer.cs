namespace ProyectoAdmnBD
{
    partial class AgregarTipoPago
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
            this.btnAgregarTipoPago = new System.Windows.Forms.Button();
            this.txtAgregarTipoPago = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblAgregarTipoPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarTipoPago
            // 
            this.btnAgregarTipoPago.Location = new System.Drawing.Point(349, 105);
            this.btnAgregarTipoPago.Name = "btnAgregarTipoPago";
            this.btnAgregarTipoPago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoPago.TabIndex = 0;
            this.btnAgregarTipoPago.Text = "Agregar";
            this.btnAgregarTipoPago.UseVisualStyleBackColor = true;
            this.btnAgregarTipoPago.Click += new System.EventHandler(this.btnAgregarTipoPago_Click);
            // 
            // txtAgregarTipoPago
            // 
            this.txtAgregarTipoPago.Location = new System.Drawing.Point(121, 105);
            this.txtAgregarTipoPago.Name = "txtAgregarTipoPago";
            this.txtAgregarTipoPago.Size = new System.Drawing.Size(148, 23);
            this.txtAgregarTipoPago.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblAgregarTipoPago
            // 
            this.lblAgregarTipoPago.AutoSize = true;
            this.lblAgregarTipoPago.Location = new System.Drawing.Point(188, 41);
            this.lblAgregarTipoPago.Name = "lblAgregarTipoPago";
            this.lblAgregarTipoPago.Size = new System.Drawing.Size(119, 15);
            this.lblAgregarTipoPago.TabIndex = 3;
            this.lblAgregarTipoPago.Text = "Agregar tipo de pago";
            // 
            // AgregarTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 212);
            this.Controls.Add(this.lblAgregarTipoPago);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtAgregarTipoPago);
            this.Controls.Add(this.btnAgregarTipoPago);
            this.Name = "AgregarTipoPago";
            this.Text = "AgregarTipoPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarTipoPago;
        private TextBox txtAgregarTipoPago;
        private Button btnRegresar;
        private Label lblAgregarTipoPago;
    }
}