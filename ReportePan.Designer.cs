namespace ProyectoAdmnBD
{
    partial class ReportePan
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
            this.btnRegresarReportPan = new System.Windows.Forms.Button();
            this.dataPan = new System.Windows.Forms.DataGridView();
            this.btnMostrarReportePan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarReportPan
            // 
            this.btnRegresarReportPan.Location = new System.Drawing.Point(12, 12);
            this.btnRegresarReportPan.Name = "btnRegresarReportPan";
            this.btnRegresarReportPan.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarReportPan.TabIndex = 0;
            this.btnRegresarReportPan.Text = "Regresar";
            this.btnRegresarReportPan.UseVisualStyleBackColor = true;
            this.btnRegresarReportPan.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataPan
            // 
            this.dataPan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPan.Location = new System.Drawing.Point(36, 64);
            this.dataPan.Name = "dataPan";
            this.dataPan.ReadOnly = true;
            this.dataPan.RowHeadersWidth = 62;
            this.dataPan.RowTemplate.Height = 33;
            this.dataPan.Size = new System.Drawing.Size(616, 287);
            this.dataPan.TabIndex = 1;
            this.dataPan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPan_CellContentClick);
            // 
            // btnMostrarReportePan
            // 
            this.btnMostrarReportePan.Location = new System.Drawing.Point(151, 12);
            this.btnMostrarReportePan.Name = "btnMostrarReportePan";
            this.btnMostrarReportePan.Size = new System.Drawing.Size(160, 34);
            this.btnMostrarReportePan.TabIndex = 2;
            this.btnMostrarReportePan.Text = "Generar Reporte";
            this.btnMostrarReportePan.UseVisualStyleBackColor = true;
            this.btnMostrarReportePan.Click += new System.EventHandler(this.btnMostrarReportePan_Click);
            // 
            // ReportePan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 373);
            this.Controls.Add(this.btnMostrarReportePan);
            this.Controls.Add(this.dataPan);
            this.Controls.Add(this.btnRegresarReportPan);
            this.Name = "ReportePan";
            this.Text = "ReportePan";
            this.Load += new System.EventHandler(this.ReportePan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegresarReportPan;
        private DataGridView dataPan;
        private Button btnMostrarReportePan;
    }
}