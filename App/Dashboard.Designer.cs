
namespace App
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.btnBusqEmp = new FontAwesome.Sharp.IconButton();
            this.btnGestReport = new FontAwesome.Sharp.IconButton();
            this.btnGesVist = new FontAwesome.Sharp.IconButton();
            this.btnGesServ = new FontAwesome.Sharp.IconButton();
            this.btnGesCon = new FontAwesome.Sharp.IconButton();
            this.btnGesFun = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.btnAgregarFuncionario = new FontAwesome.Sharp.IconButton();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnSignOut = new FontAwesome.Sharp.IconButton();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUserIcon = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDash = new System.Windows.Forms.Panel();
            this.horFec = new System.Windows.Forms.Timer(this.components);
            this.panelVertical.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVertical.Controls.Add(this.btnBusqEmp);
            this.panelVertical.Controls.Add(this.btnGestReport);
            this.panelVertical.Controls.Add(this.btnGesVist);
            this.panelVertical.Controls.Add(this.btnGesServ);
            this.panelVertical.Controls.Add(this.btnGesCon);
            this.panelVertical.Controls.Add(this.btnGesFun);
            this.panelVertical.Controls.Add(this.btnAgregarCliente);
            this.panelVertical.Controls.Add(this.btnAgregarFuncionario);
            this.panelVertical.Location = new System.Drawing.Point(0, -1);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(319, 968);
            this.panelVertical.TabIndex = 0;
            this.panelVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVertical_MouseDown);
            // 
            // btnBusqEmp
            // 
            this.btnBusqEmp.FlatAppearance.BorderSize = 0;
            this.btnBusqEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqEmp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqEmp.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusqEmp.IconColor = System.Drawing.Color.Black;
            this.btnBusqEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqEmp.IconSize = 60;
            this.btnBusqEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqEmp.Location = new System.Drawing.Point(11, 853);
            this.btnBusqEmp.Name = "btnBusqEmp";
            this.btnBusqEmp.Size = new System.Drawing.Size(290, 59);
            this.btnBusqEmp.TabIndex = 7;
            this.btnBusqEmp.Text = "Búsqueda Empresa";
            this.btnBusqEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusqEmp.UseVisualStyleBackColor = true;
            this.btnBusqEmp.Click += new System.EventHandler(this.btnBusqEmp_Click);
            // 
            // btnGestReport
            // 
            this.btnGestReport.FlatAppearance.BorderSize = 0;
            this.btnGestReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestReport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestReport.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnGestReport.IconColor = System.Drawing.Color.Black;
            this.btnGestReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestReport.IconSize = 65;
            this.btnGestReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestReport.Location = new System.Drawing.Point(11, 756);
            this.btnGestReport.Name = "btnGestReport";
            this.btnGestReport.Size = new System.Drawing.Size(290, 59);
            this.btnGestReport.TabIndex = 6;
            this.btnGestReport.Text = "Gestión Reportes";
            this.btnGestReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestReport.UseVisualStyleBackColor = true;
            this.btnGestReport.Click += new System.EventHandler(this.btnGestReport_Click);
            // 
            // btnGesVist
            // 
            this.btnGesVist.FlatAppearance.BorderSize = 0;
            this.btnGesVist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesVist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesVist.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnGesVist.IconColor = System.Drawing.Color.Black;
            this.btnGesVist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGesVist.IconSize = 65;
            this.btnGesVist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGesVist.Location = new System.Drawing.Point(11, 656);
            this.btnGesVist.Name = "btnGesVist";
            this.btnGesVist.Size = new System.Drawing.Size(290, 59);
            this.btnGesVist.TabIndex = 5;
            this.btnGesVist.Text = "Gestión Visitas";
            this.btnGesVist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGesVist.UseVisualStyleBackColor = true;
            this.btnGesVist.Click += new System.EventHandler(this.btnGesVist_Click);
            // 
            // btnGesServ
            // 
            this.btnGesServ.FlatAppearance.BorderSize = 0;
            this.btnGesServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesServ.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesServ.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnGesServ.IconColor = System.Drawing.Color.Black;
            this.btnGesServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGesServ.IconSize = 60;
            this.btnGesServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGesServ.Location = new System.Drawing.Point(11, 557);
            this.btnGesServ.Name = "btnGesServ";
            this.btnGesServ.Size = new System.Drawing.Size(290, 59);
            this.btnGesServ.TabIndex = 4;
            this.btnGesServ.Text = "Gestión Servicios";
            this.btnGesServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGesServ.UseVisualStyleBackColor = true;
            this.btnGesServ.Click += new System.EventHandler(this.btnGesServ_Click);
            // 
            // btnGesCon
            // 
            this.btnGesCon.FlatAppearance.BorderSize = 0;
            this.btnGesCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesCon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesCon.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.btnGesCon.IconColor = System.Drawing.Color.Black;
            this.btnGesCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGesCon.IconSize = 65;
            this.btnGesCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGesCon.Location = new System.Drawing.Point(11, 459);
            this.btnGesCon.Name = "btnGesCon";
            this.btnGesCon.Size = new System.Drawing.Size(290, 59);
            this.btnGesCon.TabIndex = 3;
            this.btnGesCon.Text = "Gestión Contratos";
            this.btnGesCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGesCon.UseVisualStyleBackColor = true;
            this.btnGesCon.Click += new System.EventHandler(this.btnGesCon_Click);
            // 
            // btnGesFun
            // 
            this.btnGesFun.FlatAppearance.BorderSize = 0;
            this.btnGesFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesFun.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesFun.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnGesFun.IconColor = System.Drawing.Color.Black;
            this.btnGesFun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGesFun.IconSize = 65;
            this.btnGesFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGesFun.Location = new System.Drawing.Point(11, 360);
            this.btnGesFun.Name = "btnGesFun";
            this.btnGesFun.Size = new System.Drawing.Size(290, 59);
            this.btnGesFun.TabIndex = 2;
            this.btnGesFun.Text = "Gestión Funcionarios";
            this.btnGesFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGesFun.UseVisualStyleBackColor = true;
            this.btnGesFun.Click += new System.EventHandler(this.btnGesFun_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.IconSize = 65;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(11, 267);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(290, 59);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarFuncionario
            // 
            this.btnAgregarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAgregarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFuncionario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFuncionario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarFuncionario.IconColor = System.Drawing.Color.Black;
            this.btnAgregarFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarFuncionario.IconSize = 65;
            this.btnAgregarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFuncionario.Location = new System.Drawing.Point(11, 171);
            this.btnAgregarFuncionario.Name = "btnAgregarFuncionario";
            this.btnAgregarFuncionario.Size = new System.Drawing.Size(290, 59);
            this.btnAgregarFuncionario.TabIndex = 0;
            this.btnAgregarFuncionario.Text = "Agregar Funcionario";
            this.btnAgregarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFuncionario.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionario.Click += new System.EventHandler(this.btnAgregarFuncionario_Click);
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.lblhora);
            this.panelHorizontal.Controls.Add(this.lblfecha);
            this.panelHorizontal.Controls.Add(this.btnSignOut);
            this.panelHorizontal.Controls.Add(this.lblmensaje);
            this.panelHorizontal.Controls.Add(this.label2);
            this.panelHorizontal.Controls.Add(this.btnUserIcon);
            this.panelHorizontal.Controls.Add(this.label1);
            this.panelHorizontal.Location = new System.Drawing.Point(0, -1);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1604, 155);
            this.panelHorizontal.TabIndex = 1;
            this.panelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseDown);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(682, 53);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 17);
            this.lblhora.TabIndex = 6;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(783, 90);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 17);
            this.lblfecha.TabIndex = 5;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Brown;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.btnSignOut.IconColor = System.Drawing.Color.White;
            this.btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignOut.IconSize = 30;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(1373, 62);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(166, 36);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Cerrar Sesión";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(336, 53);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 17);
            this.lblmensaje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido Usuario:";
            // 
            // btnUserIcon
            // 
            this.btnUserIcon.FlatAppearance.BorderSize = 0;
            this.btnUserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUserIcon.IconColor = System.Drawing.Color.Black;
            this.btnUserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserIcon.IconSize = 100;
            this.btnUserIcon.Location = new System.Drawing.Point(44, 32);
            this.btnUserIcon.Name = "btnUserIcon";
            this.btnUserIcon.Size = new System.Drawing.Size(116, 96);
            this.btnUserIcon.TabIndex = 1;
            this.btnUserIcon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // panelDash
            // 
            this.panelDash.Location = new System.Drawing.Point(340, 171);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(1251, 782);
            this.panelDash.TabIndex = 2;
            // 
            // horFec
            // 
            this.horFec.Enabled = true;
            this.horFec.Tick += new System.EventHandler(this.horFec_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 965);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.panelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.panelVertical.ResumeLayout(false);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel panelHorizontal;
        private FontAwesome.Sharp.IconButton btnUserIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBusqEmp;
        private FontAwesome.Sharp.IconButton btnGestReport;
        private FontAwesome.Sharp.IconButton btnGesVist;
        private FontAwesome.Sharp.IconButton btnGesServ;
        private FontAwesome.Sharp.IconButton btnGesCon;
        private FontAwesome.Sharp.IconButton btnGesFun;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private FontAwesome.Sharp.IconButton btnAgregarFuncionario;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private System.Windows.Forms.Panel panelDash;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horFec;
    }
}