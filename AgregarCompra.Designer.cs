namespace ProyectoAdmnBD
{
    partial class AgregarCompra
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
            this.CbIngrediente = new System.Windows.Forms.ComboBox();
            this.txtCostoCompra = new System.Windows.Forms.TextBox();
            this.CbProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbIngrediente
            // 
            this.CbIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIngrediente.FormattingEnabled = true;
            this.CbIngrediente.Location = new System.Drawing.Point(112, 26);
            this.CbIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.CbIngrediente.Name = "CbIngrediente";
            this.CbIngrediente.Size = new System.Drawing.Size(146, 28);
            this.CbIngrediente.TabIndex = 1;
            // 
            // txtCostoCompra
            // 
            this.txtCostoCompra.Location = new System.Drawing.Point(112, 122);
            this.txtCostoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoCompra.Name = "txtCostoCompra";
            this.txtCostoCompra.Size = new System.Drawing.Size(121, 27);
            this.txtCostoCompra.TabIndex = 2;
            // 
            // CbProveedor
            // 
            this.CbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProveedor.FormattingEnabled = true;
            this.CbProveedor.Location = new System.Drawing.Point(112, 69);
            this.CbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.CbProveedor.Name = "CbProveedor";
            this.CbProveedor.Size = new System.Drawing.Size(146, 28);
            this.CbProveedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostoCompra);
            this.Controls.Add(this.CbIngrediente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCompra";
            this.Text = "AgregarCompra";
            this.Load += new System.EventHandler(this.AgregarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CbIngrediente;
        private TextBox txtCostoCompra;
        private ComboBox CbProveedor;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}