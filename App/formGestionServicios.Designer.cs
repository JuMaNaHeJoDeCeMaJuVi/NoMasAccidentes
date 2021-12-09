
namespace App
{
    partial class formGestionServicios
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
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivoServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescServicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivoAsesoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadVisita = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGravedad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComentarioAccidente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpCapacitacion = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAsistentes = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMotivoCapacitacion = new System.Windows.Forms.TextBox();
            this.txtIdAsesoria = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIdCapacitacion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIdAccidente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIdServicioEnable = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Servicio";
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(220, 106);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(171, 22);
            this.txtIdServicio.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(27, 165);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(707, 485);
            this.dgvDatos.TabIndex = 7;
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
            this.btnBuscar.Location = new System.Drawing.Point(438, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 58);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCargar.IconColor = System.Drawing.Color.White;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 40;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(634, 88);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 58);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar Todo";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gold;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 40;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(833, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 58);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(1029, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 58);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(830, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Servicio";
            // 
            // txtMotivoServicio
            // 
            this.txtMotivoServicio.Location = new System.Drawing.Point(761, 264);
            this.txtMotivoServicio.Name = "txtMotivoServicio";
            this.txtMotivoServicio.Size = new System.Drawing.Size(193, 22);
            this.txtMotivoServicio.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motivo Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Monto Servicio";
            // 
            // txtMontoServicio
            // 
            this.txtMontoServicio.Location = new System.Drawing.Point(762, 312);
            this.txtMontoServicio.Name = "txtMontoServicio";
            this.txtMontoServicio.Size = new System.Drawing.Size(192, 22);
            this.txtMontoServicio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desc Servicio";
            // 
            // txtDescServicio
            // 
            this.txtDescServicio.Location = new System.Drawing.Point(761, 366);
            this.txtDescServicio.Name = "txtDescServicio";
            this.txtDescServicio.Size = new System.Drawing.Size(192, 22);
            this.txtDescServicio.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(820, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Asesoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Motivo";
            // 
            // txtMotivoAsesoria
            // 
            this.txtMotivoAsesoria.Location = new System.Drawing.Point(763, 483);
            this.txtMotivoAsesoria.Name = "txtMotivoAsesoria";
            this.txtMotivoAsesoria.Size = new System.Drawing.Size(191, 22);
            this.txtMotivoAsesoria.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(762, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cantidad Visitas";
            // 
            // txtCantidadVisita
            // 
            this.txtCantidadVisita.Location = new System.Drawing.Point(763, 536);
            this.txtCantidadVisita.Name = "txtCantidadVisita";
            this.txtCantidadVisita.Size = new System.Drawing.Size(192, 22);
            this.txtCantidadVisita.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(762, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(762, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(765, 628);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(191, 22);
            this.txtComentario.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1075, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Accidente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1019, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Gravedad";
            // 
            // txtGravedad
            // 
            this.txtGravedad.Location = new System.Drawing.Point(1022, 264);
            this.txtGravedad.Name = "txtGravedad";
            this.txtGravedad.Size = new System.Drawing.Size(194, 22);
            this.txtGravedad.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1019, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Causa";
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(1022, 312);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(194, 22);
            this.txtCausa.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1020, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Comentarios";
            // 
            // txtComentarioAccidente
            // 
            this.txtComentarioAccidente.Location = new System.Drawing.Point(1023, 368);
            this.txtComentarioAccidente.Name = "txtComentarioAccidente";
            this.txtComentarioAccidente.Size = new System.Drawing.Size(193, 22);
            this.txtComentarioAccidente.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1073, 408);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Capacitación";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1020, 480);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "Fecha Capacitación";
            // 
            // dtpCapacitacion
            // 
            this.dtpCapacitacion.Location = new System.Drawing.Point(1023, 504);
            this.dtpCapacitacion.Name = "dtpCapacitacion";
            this.dtpCapacitacion.Size = new System.Drawing.Size(194, 22);
            this.dtpCapacitacion.TabIndex = 37;
            this.dtpCapacitacion.Value = new System.DateTime(2021, 12, 6, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1020, 541);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "Asistentes";
            // 
            // txtAsistentes
            // 
            this.txtAsistentes.Location = new System.Drawing.Point(1023, 565);
            this.txtAsistentes.Name = "txtAsistentes";
            this.txtAsistentes.Size = new System.Drawing.Size(194, 22);
            this.txtAsistentes.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1020, 603);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "Motivo Capacitación";
            // 
            // txtMotivoCapacitacion
            // 
            this.txtMotivoCapacitacion.Location = new System.Drawing.Point(1023, 627);
            this.txtMotivoCapacitacion.Name = "txtMotivoCapacitacion";
            this.txtMotivoCapacitacion.Size = new System.Drawing.Size(193, 22);
            this.txtMotivoCapacitacion.TabIndex = 41;
            // 
            // txtIdAsesoria
            // 
            this.txtIdAsesoria.Location = new System.Drawing.Point(763, 438);
            this.txtIdAsesoria.Name = "txtIdAsesoria";
            this.txtIdAsesoria.Size = new System.Drawing.Size(191, 22);
            this.txtIdAsesoria.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(762, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 21);
            this.label20.TabIndex = 43;
            this.label20.Text = "Id Asesoria";
            // 
            // txtIdCapacitacion
            // 
            this.txtIdCapacitacion.Location = new System.Drawing.Point(1023, 455);
            this.txtIdCapacitacion.Name = "txtIdCapacitacion";
            this.txtIdCapacitacion.Size = new System.Drawing.Size(193, 22);
            this.txtIdCapacitacion.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1020, 435);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 17);
            this.label21.TabIndex = 45;
            this.label21.Text = "Id Capacitacion";
            // 
            // txtIdAccidente
            // 
            this.txtIdAccidente.Location = new System.Drawing.Point(1022, 213);
            this.txtIdAccidente.Name = "txtIdAccidente";
            this.txtIdAccidente.Size = new System.Drawing.Size(193, 22);
            this.txtIdAccidente.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1020, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 17);
            this.label22.TabIndex = 47;
            this.label22.Text = "Id Accidente";
            // 
            // txtIdServicioEnable
            // 
            this.txtIdServicioEnable.Location = new System.Drawing.Point(761, 213);
            this.txtIdServicioEnable.Name = "txtIdServicioEnable";
            this.txtIdServicioEnable.Size = new System.Drawing.Size(192, 22);
            this.txtIdServicioEnable.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(758, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 21);
            this.label23.TabIndex = 49;
            this.label23.Text = "Id Servicio";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(763, 584);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 21);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "Accidente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(867, 584);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 21);
            this.checkBox2.TabIndex = 51;
            this.checkBox2.Text = "Fiscalización";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // formGestionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 682);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtIdServicioEnable);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtIdAccidente);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtIdCapacitacion);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtIdAsesoria);
            this.Controls.Add(this.txtMotivoCapacitacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAsistentes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpCapacitacion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtComentarioAccidente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtGravedad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidadVisita);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMotivoAsesoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotivoServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGestionServicios";
            this.Text = "formGestionServicios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.DataGridView dgvDatos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCargar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotivoAsesoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadVisita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGravedad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComentarioAccidente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpCapacitacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAsistentes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMotivoCapacitacion;
        private System.Windows.Forms.TextBox txtIdAsesoria;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIdCapacitacion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIdAccidente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIdServicioEnable;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}