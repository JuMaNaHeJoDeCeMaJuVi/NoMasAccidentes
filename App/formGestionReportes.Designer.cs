
namespace App
{
    partial class formGestionReportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCont = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnGenerarPdf = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnCargarTodo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Contrato";
            // 
            // txtIdCont
            // 
            this.txtIdCont.Location = new System.Drawing.Point(231, 122);
            this.txtIdCont.Name = "txtIdCont";
            this.txtIdCont.Size = new System.Drawing.Size(252, 22);
            this.txtIdCont.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(37, 169);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1169, 397);
            this.dgvDatos.TabIndex = 7;
            // 
            // btnGenerarPdf
            // 
            this.btnGenerarPdf.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarPdf.FlatAppearance.BorderSize = 0;
            this.btnGenerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPdf.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGenerarPdf.IconColor = System.Drawing.Color.White;
            this.btnGenerarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarPdf.IconSize = 40;
            this.btnGenerarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPdf.Location = new System.Drawing.Point(37, 585);
            this.btnGenerarPdf.Name = "btnGenerarPdf";
            this.btnGenerarPdf.Size = new System.Drawing.Size(185, 76);
            this.btnGenerarPdf.TabIndex = 9;
            this.btnGenerarPdf.Text = "Exportar PDF";
            this.btnGenerarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPdf.UseVisualStyleBackColor = false;
            this.btnGenerarPdf.Click += new System.EventHandler(this.btnGenerarPdf_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(740, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(171, 59);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargarTodo
            // 
            this.btnCargarTodo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargarTodo.ForeColor = System.Drawing.Color.White;
            this.btnCargarTodo.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCargarTodo.IconColor = System.Drawing.Color.White;
            this.btnCargarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarTodo.IconSize = 35;
            this.btnCargarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarTodo.Location = new System.Drawing.Point(1035, 104);
            this.btnCargarTodo.Name = "btnCargarTodo";
            this.btnCargarTodo.Size = new System.Drawing.Size(171, 59);
            this.btnCargarTodo.TabIndex = 11;
            this.btnCargarTodo.Text = "Cargar Todo";
            this.btnCargarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarTodo.UseVisualStyleBackColor = false;
            this.btnCargarTodo.Click += new System.EventHandler(this.btnCargarTodo_Click);
            // 
            // formGestionReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1249, 686);
            this.Controls.Add(this.btnCargarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerarPdf);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtIdCont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGestionReportes";
            this.Text = "formGestionReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCont;
        private System.Windows.Forms.DataGridView dgvDatos;
        private FontAwesome.Sharp.IconButton btnGenerarPdf;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCargarTodo;
    }
}