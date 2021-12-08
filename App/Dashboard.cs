using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace App
{
    public partial class Dashboard : Form
    {
        public Dashboard(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿¿Seguro desea Cerrar su Sesión??", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }

        public void screenOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void openFormDashboard(Form formHij)
        {
            if (this.panelDash.Controls.Count > 0)
                this.panelDash.Controls.RemoveAt(0);
            Form fh = formHij as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDash.Controls.Add(fh);
            this.panelDash.Tag = fh;
            fh.Show();
        }

        private void btnAgregarFuncionario_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formAgregarFuncionario());
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formAgregarCliente());
        }

        private void btnGesFun_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formGestionFuncionarios());
        }

        private void btnGesCon_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formGestionContratos());
        }

        private void btnGesServ_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formGestionServicios());
        }

        private void btnGesVist_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formGestionVisitas());
        }

        private void btnGestReport_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formGestionReportes());
        }

        private void btnBusqEmp_Click(object sender, EventArgs e)
        {
            openFormDashboard(new formBusquedaEmpresa());
        }

        private void horFec_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("HH:mm:ss");
            lblhora.Text = DateTime.Now.ToLongDateString();
        }
    }
}
