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
            this.btnRegresarIngre.Location = new System.Drawing.Point(7, 11);
            this.btnRegresarIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresarIngre.Name = "btnRegresarIngre";
            this.btnRegresarIngre.Size = new System.Drawing.Size(90, 27);
            this.btnRegresarIngre.TabIndex = 25;
            this.btnRegresarIngre.Text = "Regresar";
            this.btnRegresarIngre.UseVisualStyleBackColor = true;
            this.btnRegresarIngre.Click += new System.EventHandler(this.btnRegresarIngre_Click);
            // 
            // dataIngre
            // 
            this.dataIngre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIngre.Location = new System.Drawing.Point(84, 71);
            this.dataIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataIngre.Name = "dataIngre";
            this.dataIngre.ReadOnly = true;
            this.dataIngre.RowHeadersWidth = 62;
            this.dataIngre.RowTemplate.Height = 33;
            this.dataIngre.Size = new System.Drawing.Size(324, 237);
            this.dataIngre.TabIndex = 24;
            // 
            // btnActualizarIngre
            // 
            this.btnActualizarIngre.Location = new System.Drawing.Point(431, 11);
            this.btnActualizarIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarIngre.Name = "btnActualizarIngre";
            this.btnActualizarIngre.Size = new System.Drawing.Size(90, 27);
            this.btnActualizarIngre.TabIndex = 23;
            this.btnActualizarIngre.Text = "Actualizar";
            this.btnActualizarIngre.UseVisualStyleBackColor = true;
            this.btnActualizarIngre.Click += new System.EventHandler(this.btnActualizarIngre_Click);
            // 
            // btnEliminarIngre
            // 
            this.btnEliminarIngre.Location = new System.Drawing.Point(318, 11);
            this.btnEliminarIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarIngre.Name = "btnEliminarIngre";
            this.btnEliminarIngre.Size = new System.Drawing.Size(90, 27);
            this.btnEliminarIngre.TabIndex = 22;
            this.btnEliminarIngre.Text = "Eliminar";
            this.btnEliminarIngre.UseVisualStyleBackColor = true;
            this.btnEliminarIngre.Click += new System.EventHandler(this.btnEliminarIngre_Click);
            // 
            // btnAgregarIngre
            // 
            this.btnAgregarIngre.Location = new System.Drawing.Point(120, 11);
            this.btnAgregarIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarIngre.Name = "btnAgregarIngre";
            this.btnAgregarIngre.Size = new System.Drawing.Size(70, 27);
            this.btnAgregarIngre.TabIndex = 21;
            this.btnAgregarIngre.Text = "Agregar";
            this.btnAgregarIngre.UseVisualStyleBackColor = true;
            this.btnAgregarIngre.Click += new System.EventHandler(this.btnAgregarIngre_Click);
            // 
            // btnEditarIngre
            // 
            this.btnEditarIngre.Location = new System.Drawing.Point(213, 11);
            this.btnEditarIngre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarIngre.Name = "btnEditarIngre";
            this.btnEditarIngre.Size = new System.Drawing.Size(90, 27);
            this.btnEditarIngre.TabIndex = 20;
            this.btnEditarIngre.Text = "Editar";
            this.btnEditarIngre.UseVisualStyleBackColor = true;
            this.btnEditarIngre.Click += new System.EventHandler(this.btnEditarIngre_Click);
            // 
            // Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 347);
            this.Controls.Add(this.btnRegresarIngre);
            this.Controls.Add(this.dataIngre);
            this.Controls.Add(this.btnActualizarIngre);
            this.Controls.Add(this.btnEliminarIngre);
            this.Controls.Add(this.btnAgregarIngre);
            this.Controls.Add(this.btnEditarIngre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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