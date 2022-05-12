namespace ProyectoAdmnBD
{
    partial class Ingredientes
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
            this.btnRegresarIngre = new System.Windows.Forms.Button();
            this.dataIngre = new System.Windows.Forms.DataGridView();
            this.btnActualizarIngre = new System.Windows.Forms.Button();
            this.btnEliminarIngre = new System.Windows.Forms.Button();
            this.btnAgregarIngre = new System.Windows.Forms.Button();
            this.btnEditarIngre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarIngre
            // 
            this.btnRegresarIngre.Location = new System.Drawing.Point(79, 64);
            this.btnRegresarIngre.Name = "btnRegresarIngre";
            this.btnRegresarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarIngre.TabIndex = 25;
            this.btnRegresarIngre.Text = "Regresar";
            this.btnRegresarIngre.UseVisualStyleBackColor = true;
            this.btnRegresarIngre.Click += new System.EventHandler(this.btnRegresarIngre_Click);
            // 
            // dataIngre
            // 
            this.dataIngre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIngre.Location = new System.Drawing.Point(119, 114);
            this.dataIngre.Name = "dataIngre";
            this.dataIngre.ReadOnly = true;
            this.dataIngre.RowHeadersWidth = 62;
            this.dataIngre.RowTemplate.Height = 33;
            this.dataIngre.Size = new System.Drawing.Size(562, 273);
            this.dataIngre.TabIndex = 24;
            // 
            // btnActualizarIngre
            // 
            this.btnActualizarIngre.Location = new System.Drawing.Point(609, 64);
            this.btnActualizarIngre.Name = "btnActualizarIngre";
            this.btnActualizarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnActualizarIngre.TabIndex = 23;
            this.btnActualizarIngre.Text = "Actualizar";
            this.btnActualizarIngre.UseVisualStyleBackColor = true;
            this.btnActualizarIngre.Click += new System.EventHandler(this.btnActualizarIngre_Click);
            // 
            // btnEliminarIngre
            // 
            this.btnEliminarIngre.Location = new System.Drawing.Point(468, 64);
            this.btnEliminarIngre.Name = "btnEliminarIngre";
            this.btnEliminarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarIngre.TabIndex = 22;
            this.btnEliminarIngre.Text = "Eliminar";
            this.btnEliminarIngre.UseVisualStyleBackColor = true;
            this.btnEliminarIngre.Click += new System.EventHandler(this.btnEliminarIngre_Click);
            // 
            // btnAgregarIngre
            // 
            this.btnAgregarIngre.Location = new System.Drawing.Point(220, 64);
            this.btnAgregarIngre.Name = "btnAgregarIngre";
            this.btnAgregarIngre.Size = new System.Drawing.Size(88, 34);
            this.btnAgregarIngre.TabIndex = 21;
            this.btnAgregarIngre.Text = "Agregar";
            this.btnAgregarIngre.UseVisualStyleBackColor = true;
            this.btnAgregarIngre.Click += new System.EventHandler(this.btnAgregarIngre_Click);
            // 
            // btnEditarIngre
            // 
            this.btnEditarIngre.Location = new System.Drawing.Point(336, 64);
            this.btnEditarIngre.Name = "btnEditarIngre";
            this.btnEditarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnEditarIngre.TabIndex = 20;
            this.btnEditarIngre.Text = "Editar";
            this.btnEditarIngre.UseVisualStyleBackColor = true;
            this.btnEditarIngre.Click += new System.EventHandler(this.btnEditarIngre_Click);
            // 
            // Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarIngre);
            this.Controls.Add(this.dataIngre);
            this.Controls.Add(this.btnActualizarIngre);
            this.Controls.Add(this.btnEliminarIngre);
            this.Controls.Add(this.btnAgregarIngre);
            this.Controls.Add(this.btnEditarIngre);
            this.Name = "Ingredientes";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.Ingredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataIngre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegresarIngre;
        private DataGridView dataIngre;
        private Button btnActualizarIngre;
        private Button btnEliminarIngre;
        private Button btnAgregarIngre;
        private Button btnEditarIngre;
    }
}