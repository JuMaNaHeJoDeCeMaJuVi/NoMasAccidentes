
namespace App
{
    partial class formGestionContratos
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
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnCargarTodo = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecContrato = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecFinContrato = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecEmision = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFecPago = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoCancelado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipPago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdCon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Contratos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "id Contrato";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Location = new System.Drawing.Point(215, 103);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Size = new System.Drawing.Size(193, 22);
            this.txtIdContrato.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(448, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 52);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnCargarTodo.IconSize = 40;
            this.btnCargarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarTodo.Location = new System.Drawing.Point(626, 88);
            this.btnCargarTodo.Name = "btnCargarTodo";
            this.btnCargarTodo.Size = new System.Drawing.Size(148, 52);
            this.btnCargarTodo.TabIndex = 4;
            this.btnCargarTodo.Text = "Cargar Todo";
            this.btnCargarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarTodo.UseVisualStyleBackColor = false;
            this.btnCargarTodo.Click += new System.EventHandler(this.btnCargarTodo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gold;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 40;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(795, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 52);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 40;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(973, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 52);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(41, 170);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(733, 496);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(849, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrato";
            // 
            // dtpFecContrato
            // 
            this.dtpFecContrato.Location = new System.Drawing.Point(794, 285);
            this.dtpFecContrato.Name = "dtpFecContrato";
            this.dtpFecContrato.Size = new System.Drawing.Size(193, 22);
            this.dtpFecContrato.TabIndex = 9;
            this.dtpFecContrato.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Contrato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Fin Contrato";
            // 
            // dtpFecFinContrato
            // 
            this.dtpFecFinContrato.Location = new System.Drawing.Point(794, 343);
            this.dtpFecFinContrato.Name = "dtpFecFinContrato";
            this.dtpFecFinContrato.Size = new System.Drawing.Size(193, 22);
            this.dtpFecFinContrato.TabIndex = 12;
            this.dtpFecFinContrato.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(840, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mensualidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(792, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(795, 445);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(193, 22);
            this.txtMonto.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(792, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha Emisión";
            // 
            // dtpFecEmision
            // 
            this.dtpFecEmision.Location = new System.Drawing.Point(795, 507);
            this.dtpFecEmision.Name = "dtpFecEmision";
            this.dtpFecEmision.Size = new System.Drawing.Size(193, 22);
            this.dtpFecEmision.TabIndex = 17;
            this.dtpFecEmision.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(792, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha Vencimiento";
            // 
            // dtpFecVencimiento
            // 
            this.dtpFecVencimiento.Location = new System.Drawing.Point(795, 569);
            this.dtpFecVencimiento.Name = "dtpFecVencimiento";
            this.dtpFecVencimiento.Size = new System.Drawing.Size(193, 22);
            this.dtpFecVencimiento.TabIndex = 19;
            this.dtpFecVencimiento.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1090, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Pago";
            // 
            // dtpFecPago
            // 
            this.dtpFecPago.Location = new System.Drawing.Point(1021, 285);
            this.dtpFecPago.Name = "dtpFecPago";
            this.dtpFecPago.Size = new System.Drawing.Size(193, 22);
            this.dtpFecPago.TabIndex = 21;
            this.dtpFecPago.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1018, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha Pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1021, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Monto Cancelado";
            // 
            // txtMontoCancelado
            // 
            this.txtMontoCancelado.Location = new System.Drawing.Point(1021, 345);
            this.txtMontoCancelado.Name = "txtMontoCancelado";
            this.txtMontoCancelado.Size = new System.Drawing.Size(192, 22);
            this.txtMontoCancelado.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1021, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tipo Pago";
            // 
            // txtTipPago
            // 
            this.txtTipPago.Location = new System.Drawing.Point(1021, 407);
            this.txtTipPago.Name = "txtTipPago";
            this.txtTipPago.Size = new System.Drawing.Size(191, 22);
            this.txtTipPago.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(792, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "Id Contrato";
            // 
            // txtIdCon
            // 
            this.txtIdCon.Location = new System.Drawing.Point(794, 232);
            this.txtIdCon.Name = "txtIdCon";
            this.txtIdCon.Size = new System.Drawing.Size(193, 22);
            this.txtIdCon.TabIndex = 28;
            // 
            // formGestionContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 702);
            this.Controls.Add(this.txtIdCon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTipPago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontoCancelado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecVencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFecEmision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecFinContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecContrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGestionContratos";
            this.Text = "formGestionContratos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdContrato;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCargarTodo;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecFinContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecEmision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecVencimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFecPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoCancelado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTipPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdCon;
    }
}