﻿namespace ProyectoAdmnBD
{
    partial class CompraIngredientes
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
            this.dataCompraIngre = new System.Windows.Forms.DataGridView();
            this.btnActualizarIngre = new System.Windows.Forms.Button();
            this.btnEliminarIngre = new System.Windows.Forms.Button();
            this.btnAgregarIngre = new System.Windows.Forms.Button();
            this.btnEditarIngre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompraIngre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarIngre
            // 
            this.btnRegresarIngre.Location = new System.Drawing.Point(79, 64);
            this.btnRegresarIngre.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresarIngre.Name = "btnRegresarIngre";
            this.btnRegresarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarIngre.TabIndex = 31;
            this.btnRegresarIngre.Text = "Regresar";
            this.btnRegresarIngre.UseVisualStyleBackColor = true;
            this.btnRegresarIngre.Click += new System.EventHandler(this.btnRegresarIngre_Click);
            // 
            // dataCompraIngre
            // 
            this.dataCompraIngre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompraIngre.Location = new System.Drawing.Point(50, 135);
            this.dataCompraIngre.Margin = new System.Windows.Forms.Padding(2);
            this.dataCompraIngre.Name = "dataCompraIngre";
            this.dataCompraIngre.ReadOnly = true;
            this.dataCompraIngre.RowHeadersWidth = 62;
            this.dataCompraIngre.RowTemplate.Height = 33;
            this.dataCompraIngre.Size = new System.Drawing.Size(708, 272);
            this.dataCompraIngre.TabIndex = 30;
            // 
            // btnActualizarIngre
            // 
            this.btnActualizarIngre.Location = new System.Drawing.Point(609, 64);
            this.btnActualizarIngre.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarIngre.Name = "btnActualizarIngre";
            this.btnActualizarIngre.Size = new System.Drawing.Size(160, 34);
            this.btnActualizarIngre.TabIndex = 29;
            this.btnActualizarIngre.Text = "Generar Reporte";
            this.btnActualizarIngre.UseVisualStyleBackColor = true;
            this.btnActualizarIngre.Click += new System.EventHandler(this.btnActualizarIngre_Click);
            // 
            // btnEliminarIngre
            // 
            this.btnEliminarIngre.Location = new System.Drawing.Point(468, 64);
            this.btnEliminarIngre.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarIngre.Name = "btnEliminarIngre";
            this.btnEliminarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarIngre.TabIndex = 28;
            this.btnEliminarIngre.Text = "Eliminar";
            this.btnEliminarIngre.UseVisualStyleBackColor = true;
            this.btnEliminarIngre.Click += new System.EventHandler(this.btnEliminarIngre_Click);
            // 
            // btnAgregarIngre
            // 
            this.btnAgregarIngre.Location = new System.Drawing.Point(220, 64);
            this.btnAgregarIngre.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarIngre.Name = "btnAgregarIngre";
            this.btnAgregarIngre.Size = new System.Drawing.Size(88, 34);
            this.btnAgregarIngre.TabIndex = 27;
            this.btnAgregarIngre.Text = "Agregar";
            this.btnAgregarIngre.UseVisualStyleBackColor = true;
            this.btnAgregarIngre.Click += new System.EventHandler(this.btnAgregarIngre_Click);
            // 
            // btnEditarIngre
            // 
            this.btnEditarIngre.Location = new System.Drawing.Point(336, 64);
            this.btnEditarIngre.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarIngre.Name = "btnEditarIngre";
            this.btnEditarIngre.Size = new System.Drawing.Size(112, 34);
            this.btnEditarIngre.TabIndex = 26;
            this.btnEditarIngre.Text = "Editar";
            this.btnEditarIngre.UseVisualStyleBackColor = true;
            this.btnEditarIngre.Click += new System.EventHandler(this.btnEditarIngre_Click);
            // 
            // CompraIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarIngre);
            this.Controls.Add(this.dataCompraIngre);
            this.Controls.Add(this.btnActualizarIngre);
            this.Controls.Add(this.btnEliminarIngre);
            this.Controls.Add(this.btnAgregarIngre);
            this.Controls.Add(this.btnEditarIngre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompraIngredientes";
            this.Text = "CompraIngredientes";
            this.Load += new System.EventHandler(this.CompraIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCompraIngre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegresarIngre;
        private DataGridView dataCompraIngre;
        private Button btnActualizarIngre;
        private Button btnEliminarIngre;
        private Button btnAgregarIngre;
        private Button btnEditarIngre;
    }
}