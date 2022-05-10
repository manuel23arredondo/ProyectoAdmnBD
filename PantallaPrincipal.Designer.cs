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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProductoPanaderia = new System.Windows.Forms.Button();
            this.btnReportePan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "Buscar Empleado";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(912, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(140, 37);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(205, 31);
            this.txtEmpleado.TabIndex = 3;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(675, 29);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(218, 39);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProductoPanaderia
            // 
            this.btnProductoPanaderia.Location = new System.Drawing.Point(682, 106);
            this.btnProductoPanaderia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductoPanaderia.Name = "btnProductoPanaderia";
            this.btnProductoPanaderia.Size = new System.Drawing.Size(211, 39);
            this.btnProductoPanaderia.TabIndex = 6;
            this.btnProductoPanaderia.Text = "Productos Panaderia";
            this.btnProductoPanaderia.Click += new System.EventHandler(this.btnProductoPanaderia_Click);
            // 
            // btnReportePan
            // 
            this.btnReportePan.Location = new System.Drawing.Point(417, 106);
            this.btnReportePan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportePan.Name = "btnReportePan";
            this.btnReportePan.Size = new System.Drawing.Size(173, 39);
            this.btnReportePan.TabIndex = 7;
            this.btnReportePan.Text = "Reporte Panaderia";
            this.btnReportePan.Click += new System.EventHandler(this.btnReportePan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 321);
            this.Controls.Add(this.btnReportePan);
            this.Controls.Add(this.btnProductoPanaderia);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtEmpleado;
        private Button btnUsuarios;
        private Button btnProductoPanaderia;
        private Button btnReportePan;
    }
}