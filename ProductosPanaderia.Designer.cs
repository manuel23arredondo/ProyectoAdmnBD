namespace ProyectoAdmnBD
{
    partial class ProductosPanaderia
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
            this.btnRegresarProducto = new System.Windows.Forms.Button();
            this.dataPanes = new System.Windows.Forms.DataGridView();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPanes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarProducto
            // 
            this.btnRegresarProducto.Location = new System.Drawing.Point(61, 26);
            this.btnRegresarProducto.Name = "btnRegresarProducto";
            this.btnRegresarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarProducto.TabIndex = 19;
            this.btnRegresarProducto.Text = "Regresar";
            this.btnRegresarProducto.UseVisualStyleBackColor = true;
            this.btnRegresarProducto.Click += new System.EventHandler(this.btnRegresarProducto_Click);
            // 
            // dataPanes
            // 
            this.dataPanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPanes.Location = new System.Drawing.Point(99, 80);
            this.dataPanes.Name = "dataPanes";
            this.dataPanes.ReadOnly = true;
            this.dataPanes.RowHeadersWidth = 62;
            this.dataPanes.RowTemplate.Height = 33;
            this.dataPanes.Size = new System.Drawing.Size(562, 273);
            this.dataPanes.TabIndex = 18;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(591, 26);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnActualizarProducto.TabIndex = 17;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(450, 26);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarProducto.TabIndex = 16;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(202, 26);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(88, 34);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(318, 26);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnEditarProducto.TabIndex = 14;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // ProductosPanaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 374);
            this.Controls.Add(this.btnRegresarProducto);
            this.Controls.Add(this.dataPanes);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Name = "ProductosPanaderia";
            this.Text = "ProductosPanaderia";
            this.Load += new System.EventHandler(this.ProductosPanaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegresarProducto;
        private DataGridView dataPanes;
        private Button btnActualizarProducto;
        private Button btnEliminarProducto;
        private Button btnAgregarProducto;
        private Button btnEditarProducto;
    }
}