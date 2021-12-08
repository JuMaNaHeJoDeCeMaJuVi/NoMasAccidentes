
namespace App
{
    partial class formGestionFuncionarios
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
            this.txtRunFun = new System.Windows.Forms.TextBox();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRunFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDvFun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSegNom = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtCorElec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassUsu = new System.Windows.Forms.TextBox();
            this.btnBuscarFun = new FontAwesome.Sharp.IconButton();
            this.btnCargarFun = new FontAwesome.Sharp.IconButton();
            this.btnModificarFun = new FontAwesome.Sharp.IconButton();
            this.btnEliminarFun = new FontAwesome.Sharp.IconButton();
            this.checkbSeleccion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdFun = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdFuncionarioEnable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "R.U.N. Funcionario";
            // 
            // txtRunFun
            // 
            this.txtRunFun.Location = new System.Drawing.Point(258, 91);
            this.txtRunFun.Name = "txtRunFun";
            this.txtRunFun.Size = new System.Drawing.Size(194, 22);
            this.txtRunFun.TabIndex = 2;
            // 
            // dtvDatos
            // 
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(87, 170);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.RowHeadersWidth = 51;
            this.dtvDatos.RowTemplate.Height = 24;
            this.dtvDatos.Size = new System.Drawing.Size(752, 467);
            this.dtvDatos.TabIndex = 4;
            this.dtvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2500, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 85);
            this.button4.TabIndex = 7;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1009, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "R.U.N.";
            // 
            // txtRunFuncionario
            // 
            this.txtRunFuncionario.Location = new System.Drawing.Point(898, 244);
            this.txtRunFuncionario.Name = "txtRunFuncionario";
            this.txtRunFuncionario.Size = new System.Drawing.Size(176, 22);
            this.txtRunFuncionario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // txtDvFun
            // 
            this.txtDvFun.Location = new System.Drawing.Point(1116, 244);
            this.txtDvFun.Name = "txtDvFun";
            this.txtDvFun.Size = new System.Drawing.Size(44, 22);
            this.txtDvFun.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(986, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Primer Nombre";
            // 
            // txtPriNom
            // 
            this.txtPriNom.Location = new System.Drawing.Point(898, 289);
            this.txtPriNom.Name = "txtPriNom";
            this.txtPriNom.Size = new System.Drawing.Size(262, 22);
            this.txtPriNom.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(980, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Segundo Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(986, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(985, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(980, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Correo Electronico";
            // 
            // txtSegNom
            // 
            this.txtSegNom.Location = new System.Drawing.Point(898, 334);
            this.txtSegNom.Name = "txtSegNom";
            this.txtSegNom.Size = new System.Drawing.Size(262, 22);
            this.txtSegNom.TabIndex = 20;
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(898, 388);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(262, 22);
            this.txtApePat.TabIndex = 21;
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(898, 433);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(262, 22);
            this.txtApeMat.TabIndex = 22;
            // 
            // txtCorElec
            // 
            this.txtCorElec.Location = new System.Drawing.Point(898, 478);
            this.txtCorElec.Name = "txtCorElec";
            this.txtCorElec.Size = new System.Drawing.Size(262, 22);
            this.txtCorElec.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1009, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cargo";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Profesional",
            "Administrador"});
            this.cbRol.Location = new System.Drawing.Point(898, 523);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(262, 24);
            this.cbRol.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1002, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Usuario";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(898, 570);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(264, 22);
            this.txtUserName.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(993, 595);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Contraseña";
            // 
            // txtPassUsu
            // 
            this.txtPassUsu.Location = new System.Drawing.Point(898, 615);
            this.txtPassUsu.Name = "txtPassUsu";
            this.txtPassUsu.Size = new System.Drawing.Size(262, 22);
            this.txtPassUsu.TabIndex = 29;
            // 
            // btnBuscarFun
            // 
            this.btnBuscarFun.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarFun.FlatAppearance.BorderSize = 0;
            this.btnBuscarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFun.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFun.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarFun.IconColor = System.Drawing.Color.White;
            this.btnBuscarFun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFun.IconSize = 30;
            this.btnBuscarFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFun.Location = new System.Drawing.Point(486, 91);
            this.btnBuscarFun.Name = "btnBuscarFun";
            this.btnBuscarFun.Size = new System.Drawing.Size(130, 55);
            this.btnBuscarFun.TabIndex = 30;
            this.btnBuscarFun.Text = "Buscar";
            this.btnBuscarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFun.UseVisualStyleBackColor = false;
            this.btnBuscarFun.Click += new System.EventHandler(this.btnBuscarFun_Click);
            // 
            // btnCargarFun
            // 
            this.btnCargarFun.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargarFun.FlatAppearance.BorderSize = 0;
            this.btnCargarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFun.ForeColor = System.Drawing.Color.White;
            this.btnCargarFun.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCargarFun.IconColor = System.Drawing.Color.White;
            this.btnCargarFun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarFun.IconSize = 30;
            this.btnCargarFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarFun.Location = new System.Drawing.Point(669, 91);
            this.btnCargarFun.Name = "btnCargarFun";
            this.btnCargarFun.Size = new System.Drawing.Size(130, 55);
            this.btnCargarFun.TabIndex = 31;
            this.btnCargarFun.Text = "Cargar Todo";
            this.btnCargarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarFun.UseVisualStyleBackColor = false;
            this.btnCargarFun.Click += new System.EventHandler(this.btnCargarFun_Click);
            // 
            // btnModificarFun
            // 
            this.btnModificarFun.BackColor = System.Drawing.Color.Gold;
            this.btnModificarFun.FlatAppearance.BorderSize = 0;
            this.btnModificarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFun.ForeColor = System.Drawing.Color.Black;
            this.btnModificarFun.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnModificarFun.IconColor = System.Drawing.Color.Black;
            this.btnModificarFun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarFun.IconSize = 30;
            this.btnModificarFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFun.Location = new System.Drawing.Point(849, 91);
            this.btnModificarFun.Name = "btnModificarFun";
            this.btnModificarFun.Size = new System.Drawing.Size(130, 55);
            this.btnModificarFun.TabIndex = 32;
            this.btnModificarFun.Text = "Modificar";
            this.btnModificarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarFun.UseVisualStyleBackColor = false;
            this.btnModificarFun.Click += new System.EventHandler(this.btnModificarFun_Click);
            // 
            // btnEliminarFun
            // 
            this.btnEliminarFun.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarFun.FlatAppearance.BorderSize = 0;
            this.btnEliminarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFun.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFun.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarFun.IconColor = System.Drawing.Color.White;
            this.btnEliminarFun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarFun.IconSize = 30;
            this.btnEliminarFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFun.Location = new System.Drawing.Point(1030, 91);
            this.btnEliminarFun.Name = "btnEliminarFun";
            this.btnEliminarFun.Size = new System.Drawing.Size(130, 55);
            this.btnEliminarFun.TabIndex = 33;
            this.btnEliminarFun.Text = "Eliminar";
            this.btnEliminarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFun.UseVisualStyleBackColor = false;
            this.btnEliminarFun.Click += new System.EventHandler(this.btnEliminarFun_Click);
            // 
            // checkbSeleccion
            // 
            this.checkbSeleccion.AutoSize = true;
            this.checkbSeleccion.Location = new System.Drawing.Point(87, 643);
            this.checkbSeleccion.Name = "checkbSeleccion";
            this.checkbSeleccion.Size = new System.Drawing.Size(279, 21);
            this.checkbSeleccion.TabIndex = 34;
            this.checkbSeleccion.Text = "Para uso de eliminación de Funcionario";
            this.checkbSeleccion.UseVisualStyleBackColor = true;
            this.checkbSeleccion.CheckedChanged += new System.EventHandler(this.checkbSeleccion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID Funcionario";
            // 
            // txtIdFun
            // 
            this.txtIdFun.Location = new System.Drawing.Point(258, 124);
            this.txtIdFun.Name = "txtIdFun";
            this.txtIdFun.Size = new System.Drawing.Size(194, 22);
            this.txtIdFun.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(980, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "ID Funcionario";
            // 
            // txtIdFuncionarioEnable
            // 
            this.txtIdFuncionarioEnable.Location = new System.Drawing.Point(898, 190);
            this.txtIdFuncionarioEnable.Name = "txtIdFuncionarioEnable";
            this.txtIdFuncionarioEnable.Size = new System.Drawing.Size(262, 22);
            this.txtIdFuncionarioEnable.TabIndex = 38;
            // 
            // formGestionFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 676);
            this.Controls.Add(this.txtIdFuncionarioEnable);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIdFun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkbSeleccion);
            this.Controls.Add(this.btnEliminarFun);
            this.Controls.Add(this.btnModificarFun);
            this.Controls.Add(this.btnCargarFun);
            this.Controls.Add(this.btnBuscarFun);
            this.Controls.Add(this.txtPassUsu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCorElec);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.txtSegNom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPriNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDvFun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRunFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtvDatos);
            this.Controls.Add(this.txtRunFun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGestionFuncionarios";
            this.Text = "formGestionFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRunFun;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRunFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDvFun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSegNom;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtCorElec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassUsu;
        private FontAwesome.Sharp.IconButton btnBuscarFun;
        private FontAwesome.Sharp.IconButton btnCargarFun;
        private FontAwesome.Sharp.IconButton btnModificarFun;
        private FontAwesome.Sharp.IconButton btnEliminarFun;
        private System.Windows.Forms.CheckBox checkbSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdFun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdFuncionarioEnable;
    }
}