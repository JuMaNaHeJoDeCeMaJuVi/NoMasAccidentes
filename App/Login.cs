using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void login (string usuario, string contrasena)
        {
            try
            {
                oc.Open();
                OracleCommand cmd = new OracleCommand("select primer_nombre||' '||apellido_paterno, nombre_cargo from usuario_prof up join funcionario f on up.FUNCIONARIO_ID_FUNCIONARIO = f.id_funcionario join cargo c on f.cargo_id_cargo = c.id_cargo WHERE USER_NAME = :usuname AND password = :passname", oc);
                cmd.Parameters.AddWithValue(":usuname", usuario);
                cmd.Parameters.AddWithValue(":passname", contrasena);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new Dashboard(dt.Rows[0][0].ToString()).Show();
                    }
                    MessageBox.Show("Se a Iniciado Sesión con Exito.", "Bienvenido!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ups! A ocurrido un error, Nombre de usuario o Contraseña son incorrectos.", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oc.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Dashboard dash = new Dashboard();
            if (txtNomUsu.Text == "Admin" && txtPassUsu.Text == "duoc2021")
            {
                this.Hide();
                dash.Show();
                MessageBox.Show("Exito!");
            }*/
            login(this.txtNomUsu.Text, this.txtPassUsu.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿¿Seguro desea Salir de la Aplicación??", "Advertencia!!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNomUsu_Enter(object sender, EventArgs e)
        {
            if (txtNomUsu.Text == "Usuario...")
            {
                txtNomUsu.Text = "";
                txtNomUsu.ForeColor = Color.Gray;
            }
        }

        private void txtNomUsu_Leave(object sender, EventArgs e)
        {
            if (txtNomUsu.Text == "")
            {
                txtNomUsu.Text = "Usuario...";
                txtNomUsu.ForeColor = Color.DimGray;
            }
        }

        private void txtPassUsu_Enter(object sender, EventArgs e)
        {
            if (txtPassUsu.Text == "Contraseña...")
            {
                txtPassUsu.Text = "";
                txtPassUsu.ForeColor = Color.Gray;
                txtPassUsu.UseSystemPasswordChar = true;
            }
        }

        private void txtPassUsu_Leave(object sender, EventArgs e)
        {
            if (txtPassUsu.Text == "")
            {
                txtPassUsu.Text = "Contraseña...";
                txtPassUsu.ForeColor = Color.DimGray;
                txtPassUsu.UseSystemPasswordChar = false;
            }
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassUsu.UseSystemPasswordChar = false;
        }

        private void btnSeePass_Leave(object sender, EventArgs e)
        {
            if (txtPassUsu.Text == "")
            {
                txtPassUsu.Text = "Contraseña";
                txtPassUsu.ForeColor = Color.DimGray;
                txtPassUsu.UseSystemPasswordChar = false;
            }
        }

        private void btnSeePass_Enter(object sender, EventArgs e)
        {
            if (txtPassUsu.Text == "Contraseña")
            {
                txtPassUsu.Text = "";
                txtPassUsu.ForeColor = Color.Gray;
                txtPassUsu.UseSystemPasswordChar = true;
            }
        }
    }
}
