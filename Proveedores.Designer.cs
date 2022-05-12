namespace ProyectoAdmnBD
{
    partial class Proveedores
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
            this.btnRegresarProvee = new System.Windows.Forms.Button();
            this.dataProvee = new System.Windows.Forms.DataGridView();
            this.btnActualizarProvee = new System.Windows.Forms.Button();
            this.btnEliminarProvee = new System.Windows.Forms.Button();
            this.btnAgregarProvee = new System.Windows.Forms.Button();
            this.btnEditarProvee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProvee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarProvee
            // 
            this.btnRegresarProvee.Location = new System.Drawing.Point(75, 20);
            this.btnRegresarProvee.Name = "btnRegresarProvee";
            this.btnRegresarProvee.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarProvee.TabIndex = 19;
            this.btnRegresarProvee.Text = "Regresar";
            this.btnRegresarProvee.UseVisualStyleBackColor = true;
            this.btnRegresarProvee.Click += new System.EventHandler(this.btnRegresarProvee_Click);
            // 
            // dataProvee
            // 
            this.dataProvee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProvee.Location = new System.Drawing.Point(115, 70);
            this.dataProvee.Name = "dataProvee";
            this.dataProvee.ReadOnly = true;
            this.dataProvee.RowHeadersWidth = 62;
            this.dataProvee.RowTemplate.Height = 33;
            this.dataProvee.Size = new System.Drawing.Size(562, 273);
            this.dataProvee.TabIndex = 18;
            // 
            // btnActualizarProvee
            // 
            this.btnActualizarProvee.Location = new System.Drawing.Point(605, 20);
            this.btnActualizarProvee.Name = "btnActualizarProvee";
            this.btnActualizarProvee.Size = new System.Drawing.Size(112, 34);
            this.btnActualizarProvee.TabIndex = 17;
            this.btnActualizarProvee.Text = "Actualizar";
            this.btnActualizarProvee.UseVisualStyleBackColor = true;
            this.btnActualizarProvee.Click += new System.EventHandler(this.btnActualizarProvee_Click);
            // 
            // btnEliminarProvee
            // 
            this.btnEliminarProvee.Location = new System.Drawing.Point(464, 20);
            this.btnEliminarProvee.Name = "btnEliminarProvee";
            this.btnEliminarProvee.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarProvee.TabIndex = 16;
            this.btnEliminarProvee.Text = "Eliminar";
            this.btnEliminarProvee.UseVisualStyleBackColor = true;
            this.btnEliminarProvee.Click += new System.EventHandler(this.btnEliminarProvee_Click);
            // 
            // btnAgregarProvee
            // 
            this.btnAgregarProvee.Location = new System.Drawing.Point(216, 20);
            this.btnAgregarProvee.Name = "btnAgregarProvee";
            this.btnAgregarProvee.Size = new System.Drawing.Size(88, 34);
            this.btnAgregarProvee.TabIndex = 15;
            this.btnAgregarProvee.Text = "Agregar";
            this.btnAgregarProvee.UseVisualStyleBackColor = true;
            this.btnAgregarProvee.Click += new System.EventHandler(this.btnAgregarProvee_Click);
            // 
            // btnEditarProvee
            // 
            this.btnEditarProvee.Location = new System.Drawing.Point(332, 20);
            this.btnEditarProvee.Name = "btnEditarProvee";
            this.btnEditarProvee.Size = new System.Drawing.Size(112, 34);
            this.btnEditarProvee.TabIndex = 14;
            this.btnEditarProvee.Text = "Editar";
            this.btnEditarProvee.UseVisualStyleBackColor = true;
            this.btnEditarProvee.Click += new System.EventHandler(this.btnEditarProvee_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarProvee);
            this.Controls.Add(this.dataProvee);
            this.Controls.Add(this.btnActualizarProvee);
            this.Controls.Add(this.btnEliminarProvee);
            this.Controls.Add(this.btnAgregarProvee);
            this.Controls.Add(this.btnEditarProvee);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProvee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegresarProvee;
        private DataGridView dataProvee;
        private Button btnActualizarProvee;
        private Button btnEliminarProvee;
        private Button btnAgregarProvee;
        private Button btnEditarProvee;
    }
}