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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.Empleados = new System.Windows.Forms.DataGridView();
            this.btnTipoPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Buscar Empleado";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(879, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(246, 39);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(165, 27);
            this.txtEmpleado.TabIndex = 3;
            // 
            // Empleados
            // 
            this.Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Empleados.Location = new System.Drawing.Point(166, 119);
            this.Empleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empleados.Name = "Empleados";
            this.Empleados.RowHeadersWidth = 51;
            this.Empleados.RowTemplate.Height = 25;
            this.Empleados.Size = new System.Drawing.Size(621, 257);
            this.Empleados.TabIndex = 2;
            // 
            // btnTipoPago
            // 
            this.btnTipoPago.Location = new System.Drawing.Point(642, 39);
            this.btnTipoPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTipoPago.Name = "btnTipoPago";
            this.btnTipoPago.Size = new System.Drawing.Size(174, 31);
            this.btnTipoPago.TabIndex = 5;
            this.btnTipoPago.Text = "Tipo de Pago";
            this.btnTipoPago.Click += new System.EventHandler(this.btnTipoPago_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 508);
            this.Controls.Add(this.btnTipoPago);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Empleados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtEmpleado;
        private DataGridView Empleados;
        private Button btnTipoPago;
    }
}