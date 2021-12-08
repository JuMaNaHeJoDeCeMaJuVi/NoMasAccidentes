using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using App.Model.Request;

namespace App
{
    public partial class formAgregarFuncionario : Form
    {
        public formAgregarFuncionario()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        private void validarCamposVacios()
        {
            if (txtRunFun.Text == "" || txtDvFun.Text == "" || txtPriNomFun.Text == "" || txtSegNomFun.Text == "" || txtNomUsu.Text == "" || txtApeMatFun.Text == "" || txtApePatFun.Text == "" || txtCorEleFun.Text == "" || txtPassUsu.Text == "")
            {
                MessageBox.Show("Faltan espacios por llenar", "Hubo un Problema!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Boolean verificadorEmail(string email)
        {
            return Regex.IsMatch(email, @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$");
        }

        private void validarCorreo()
        {
            if (verificadorEmail(txtCorEleFun.Text))
            {

            }
            else
            {
                MessageBox.Show("Correo Electronico Invalido", "Hubo un Problema!!!");
            }
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassUsu.UseSystemPasswordChar = false;
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

        private void btnSeePass_Leave(object sender, EventArgs e)
        {
            if (txtPassUsu.Text == "")
            {
                txtPassUsu.Text = "Contraseña";
                txtPassUsu.ForeColor = Color.DimGray;
                txtPassUsu.UseSystemPasswordChar = false;
            }
        }
        

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassUsu.UseSystemPasswordChar = true;
        }

        private void txtPriNomFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegNomFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApePatFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApeMatFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRunFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (txtRunFun.TextLength > 7)
            {
                MessageBox.Show("Excedió el Maximo de Caracteres para el Rut");
            }
        }

        private void txtDvFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDvFun.TextLength > 0)
            {
                MessageBox.Show("Excedió el Maximo de Caracteres para el Digito Verificador");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*try
            {
                oc.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = oc;
                cmd.CommandText = "insercionfuncionario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("R_NB", OracleType.VarChar).Value = txtRunFun.Text;
                cmd.Parameters.Add("R_DV", OracleType.Char).Value = txtDvFun.Text;
                cmd.Parameters.Add("P_N", OracleType.VarChar).Value = txtPriNomFun.Text;
                cmd.Parameters.Add("S_N", OracleType.VarChar).Value = txtSegNomFun.Text;
                cmd.Parameters.Add("A_P", OracleType.VarChar).Value = txtApePatFun.Text;
                cmd.Parameters.Add("A_M", OracleType.VarChar).Value = txtApeMatFun.Text;
                cmd.Parameters.Add("CORREO", OracleType.VarChar).Value = txtCorEleFun.Text;
                cmd.Parameters.Add("USER", OracleType.VarChar).Value = txtNomUsu.Text;
                cmd.Parameters.Add("PASSWORD", OracleType.VarChar).Value = txtPassUsu.Text;
                cmd.Parameters.Add("ROL", OracleType.Int32).Value = cbRol.SelectedIndex + 1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Creado con Exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            validarCamposVacios();
            validarCorreo();
            oc.Close();*/

            string url = "http://localhost:4000/api/funcionario";

            funcionarioRequest oFun = new funcionarioRequest();

            try
            {
                oc.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = oc;
                cmd.CommandText = "SP_AGREGAR_FUNCIONARIO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_RUN_FUNCIONARIO", OracleType.VarChar).Value = oFun.runFuncionario = txtRunFun.Text;
                cmd.Parameters.Add("P_DV_FUNCIONARIO", OracleType.VarChar).Value = oFun.dvFuncionario = txtDvFun.Text;
                cmd.Parameters.Add("P_PRIMER_NOMBRE", OracleType.VarChar).Value = oFun.primerNombre = txtPriNomFun.Text;
                cmd.Parameters.Add("P_SEGUNDO_NOMBRE", OracleType.VarChar).Value = oFun.segundoNombre = txtSegNomFun.Text;
                cmd.Parameters.Add("P_APELLIDO_PATERNO", OracleType.VarChar).Value = oFun.apellidoPaterno = txtApePatFun.Text;
                cmd.Parameters.Add("P_APELLIDO_MATERNO", OracleType.VarChar).Value = oFun.apellidoMaterno = txtApeMatFun.Text;
                cmd.Parameters.Add("P_CORREO_ELECTRONICO", OracleType.VarChar).Value = oFun.correoElectronico = txtCorEleFun.Text;
                cmd.Parameters.Add("P_CARGO_ID", OracleType.Int32).Value = oFun.cargo = cbRol.SelectedIndex + 1;
                cmd.Parameters.Add("P_USERNAME", OracleType.VarChar).Value = oFun.nombreUsuario = txtNomUsu.Text;
                cmd.Parameters.Add("P_PASSWORD", OracleType.VarChar).Value = oFun.password = txtPassUsu.Text;
                cmd.ExecuteNonQuery();
                string resultado = Send<funcionarioRequest>(url, oFun, "POST");
                MessageBox.Show("Funcionario Creado con Exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            oc.Close();
        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                WebRequest request = WebRequest.Create(url);

                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
