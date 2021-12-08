
namespace App
{
    partial class formBusquedaEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutEmpresa = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.btnCargarTodo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "R.U.T. Empresa";
            // 
            // txtRutEmpresa
            // 
            this.txtRutEmpresa.Location = new System.Drawing.Point(279, 137);
            this.txtRutEmpresa.Name = "txtRutEmpresa";
            this.txtRutEmpresa.Size = new System.Drawing.Size(255, 22);
            this.txtRutEmpresa.TabIndex = 6;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(43, 219);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1153, 449);
            this.dgvDatos.TabIndex = 8;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusqueda.IconColor = System.Drawing.Color.White;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(598, 112);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(244, 72);
            this.btnBusqueda.TabIndex = 9;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnCargarTodo
            // 
            this.btnCargarTodo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargarTodo.FlatAppearance.BorderSize = 0;
            this.btnCargarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarTodo.ForeColor = System.Drawing.Color.White;
            this.btnCargarTodo.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCargarTodo.IconColor = System.Drawing.Color.White;
            this.btnCargarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarTodo.Location = new System.Drawing.Point(952, 112);
            this.btnCargarTodo.Name = "btnCargarTodo";
            this.btnCargarTodo.Size = new System.Drawing.Size(244, 72);
            this.btnCargarTodo.TabIndex = 10;
            this.btnCargarTodo.Text = "Cargar Todo";
            this.btnCargarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarTodo.UseVisualStyleBackColor = false;
            this.btnCargarTodo.Click += new System.EventHandler(this.btnCargarTodo_Click);
            // 
            // formBusquedaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 702);
            this.Controls.Add(this.btnCargarTodo);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtRutEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBusquedaEmpresa";
            this.Text = "formBusquedaEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutEmpresa;
        private System.Windows.Forms.DataGridView dgvDatos;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private FontAwesome.Sharp.IconButton btnCargarTodo;
    }
}