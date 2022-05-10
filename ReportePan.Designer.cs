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
            this.dataPan = new System.Windows.Forms.DataGridView();
            this.btnRegresarReportePan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPan
            // 
            this.dataPan.AllowUserToOrderColumns = true;
            this.dataPan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPan.Location = new System.Drawing.Point(153, 121);
            this.dataPan.Name = "dataPan";
            this.dataPan.RowHeadersWidth = 62;
            this.dataPan.RowTemplate.Height = 33;
            this.dataPan.Size = new System.Drawing.Size(584, 281);
            this.dataPan.TabIndex = 0;
            // 
            // btnRegresarReportePan
            // 
            this.btnRegresarReportePan.Location = new System.Drawing.Point(12, 12);
            this.btnRegresarReportePan.Name = "btnRegresarReportePan";
            this.btnRegresarReportePan.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarReportePan.TabIndex = 1;
            this.btnRegresarReportePan.Text = "Regresar";
            this.btnRegresarReportePan.UseVisualStyleBackColor = true;
            this.btnRegresarReportePan.Click += new System.EventHandler(this.btnRegresarReportePan_Click);
            // 
            // ReportePan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarReportePan);
            this.Controls.Add(this.dataPan);
            this.Name = "ReportePan";
            this.Text = "ReportePan";
            this.Load += new System.EventHandler(this.ReportePan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataPan;
        private Button btnRegresarReportePan;
    }
}