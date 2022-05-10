namespace ProyectoAdmnBD
{
    partial class Usuario
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
            this.lblContra = new System.Windows.Forms.Label();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnActualizarUsers = new System.Windows.Forms.Button();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.btnRegresarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContra
            // 
            this.lblContra.Location = new System.Drawing.Point(0, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(100, 23);
            this.lblContra.TabIndex = 6;
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.Location = new System.Drawing.Point(282, 12);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(112, 34);
            this.btnEditarUser.TabIndex = 8;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.UseVisualStyleBackColor = true;
            this.btnEditarUser.Click += new System.EventHandler(this.btnEditarUser_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Location = new System.Drawing.Point(166, 12);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(88, 34);
            this.btnAgregarUser.TabIndex = 9;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = true;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(414, 12);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarUser.TabIndex = 10;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnActualizarUsers
            // 
            this.btnActualizarUsers.Location = new System.Drawing.Point(555, 12);
            this.btnActualizarUsers.Name = "btnActualizarUsers";
            this.btnActualizarUsers.Size = new System.Drawing.Size(112, 34);
            this.btnActualizarUsers.TabIndex = 11;
            this.btnActualizarUsers.Text = "Actualizar";
            this.btnActualizarUsers.UseVisualStyleBackColor = true;
            this.btnActualizarUsers.Click += new System.EventHandler(this.btnActualizarUsers_Click);
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Location = new System.Drawing.Point(65, 62);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.RowHeadersWidth = 62;
            this.dataUsers.RowTemplate.Height = 33;
            this.dataUsers.Size = new System.Drawing.Size(562, 273);
            this.dataUsers.TabIndex = 12;
            // 
            // btnRegresarUser
            // 
            this.btnRegresarUser.Location = new System.Drawing.Point(25, 12);
            this.btnRegresarUser.Name = "btnRegresarUser";
            this.btnRegresarUser.Size = new System.Drawing.Size(112, 34);
            this.btnRegresarUser.TabIndex = 13;
            this.btnRegresarUser.Text = "Regresar";
            this.btnRegresarUser.UseVisualStyleBackColor = true;
            this.btnRegresarUser.Click += new System.EventHandler(this.btnRegresarUser_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 372);
            this.Controls.Add(this.btnRegresarUser);
            this.Controls.Add(this.dataUsers);
            this.Controls.Add(this.btnActualizarUsers);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.lblContra);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblContra;
        private Button btnEditarUser;
        private Button btnAgregarUser;
        private Button btnEliminarUser;
        private Button btnActualizarUsers;
        private DataGridView dataUsers;
        private Button btnRegresarUser;
    }
}