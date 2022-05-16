namespace ProyectoAdmnBD
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProductoPanaderia = new System.Windows.Forms.Button();
            this.btnReportePan = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnCompraIngredientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 222);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(175, 22);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(174, 31);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProductoPanaderia
            // 
            this.btnProductoPanaderia.Location = new System.Drawing.Point(175, 61);
            this.btnProductoPanaderia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductoPanaderia.Name = "btnProductoPanaderia";
            this.btnProductoPanaderia.Size = new System.Drawing.Size(169, 31);
            this.btnProductoPanaderia.TabIndex = 6;
            this.btnProductoPanaderia.Text = "Productos Panaderia";
            this.btnProductoPanaderia.Click += new System.EventHandler(this.btnProductoPanaderia_Click);
            // 
            // btnReportePan
            // 
            this.btnReportePan.Location = new System.Drawing.Point(10, 67);
            this.btnReportePan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReportePan.Name = "btnReportePan";
            this.btnReportePan.Size = new System.Drawing.Size(138, 31);
            this.btnReportePan.TabIndex = 7;
            this.btnReportePan.Text = "Reporte Panes";
            this.btnReportePan.Click += new System.EventHandler(this.btnReportePan_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(10, 106);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(138, 31);
            this.btnProveedor.TabIndex = 8;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.Visible = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(10, 28);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(138, 31);
            this.btnIngredientes.TabIndex = 9;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnCompraIngredientes
            // 
            this.btnCompraIngredientes.Location = new System.Drawing.Point(180, 100);
            this.btnCompraIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompraIngredientes.Name = "btnCompraIngredientes";
            this.btnCompraIngredientes.Size = new System.Drawing.Size(169, 31);
            this.btnCompraIngredientes.TabIndex = 10;
            this.btnCompraIngredientes.Text = "Compra Ingredientes";
            this.btnCompraIngredientes.Click += new System.EventHandler(this.btnCompraIngredientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 266);
            this.Controls.Add(this.btnCompraIngredientes);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnReportePan);
            this.Controls.Add(this.btnProductoPanaderia);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button4;
        private Button btnUsuarios;
        private Button btnProductoPanaderia;
        private Button btnReportePan;
        private Button btnProveedor;
        private Button btnIngredientes;
        private Button btnCompraIngredientes;
    }
}