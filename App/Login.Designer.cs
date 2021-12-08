
namespace App
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassUsu = new System.Windows.Forms.TextBox();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIcon = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeePass = new FontAwesome.Sharp.IconButton();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.btnSeePass);
            this.panelLogin.Controls.Add(this.btnMinimized);
            this.panelLogin.Controls.Add(this.btnClose);
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.txtPassUsu);
            this.panelLogin.Controls.Add(this.txtNomUsu);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.userIcon);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(1015, 1);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(626, 784);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimized.IconColor = System.Drawing.Color.Black;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 30;
            this.btnMinimized.Location = new System.Drawing.Point(551, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(33, 31);
            this.btnMinimized.TabIndex = 8;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(590, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(270, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassUsu
            // 
            this.txtPassUsu.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassUsu.Location = new System.Drawing.Point(215, 523);
            this.txtPassUsu.Name = "txtPassUsu";
            this.txtPassUsu.Size = new System.Drawing.Size(250, 22);
            this.txtPassUsu.TabIndex = 5;
            this.txtPassUsu.Text = "Contraseña...";
            this.txtPassUsu.Enter += new System.EventHandler(this.txtPassUsu_Enter);
            this.txtPassUsu.Leave += new System.EventHandler(this.txtPassUsu_Leave);
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomUsu.Location = new System.Drawing.Point(215, 414);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(250, 22);
            this.txtNomUsu.TabIndex = 4;
            this.txtNomUsu.Text = "Usuario...";
            this.txtNomUsu.Enter += new System.EventHandler(this.txtNomUsu_Enter);
            this.txtNomUsu.Leave += new System.EventHandler(this.txtNomUsu_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario";
            // 
            // userIcon
            // 
            this.userIcon.FlatAppearance.BorderSize = 0;
            this.userIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.userIcon.IconColor = System.Drawing.Color.Black;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 150;
            this.userIcon.Location = new System.Drawing.Point(160, 158);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(345, 190);
            this.userIcon.TabIndex = 1;
            this.userIcon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesión";
            // 
            // btnSeePass
            // 
            this.btnSeePass.FlatAppearance.BorderSize = 0;
            this.btnSeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnSeePass.IconColor = System.Drawing.Color.Black;
            this.btnSeePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeePass.IconSize = 30;
            this.btnSeePass.Location = new System.Drawing.Point(474, 523);
            this.btnSeePass.Name = "btnSeePass";
            this.btnSeePass.Size = new System.Drawing.Size(31, 22);
            this.btnSeePass.TabIndex = 9;
            this.btnSeePass.UseVisualStyleBackColor = true;
            this.btnSeePass.Enter += new System.EventHandler(this.btnSeePass_Enter);
            this.btnSeePass.Leave += new System.EventHandler(this.btnSeePass_Leave);
            this.btnSeePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1642, 784);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton userIcon;
        private System.Windows.Forms.TextBox txtPassUsu;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnSeePass;
    }
}

