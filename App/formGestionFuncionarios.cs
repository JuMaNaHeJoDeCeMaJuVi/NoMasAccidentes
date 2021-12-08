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
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using App.Model.Request;

namespace App
{
    public partial class formGestionFuncionarios : Form
    {
        public formGestionFuncionarios()
        {
            InitializeComponent();
            txtIdFun.Enabled = false;
            txtIdFuncionarioEnable.Enabled = false;
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        public void habDesTxt()
        {
            if(checkbSeleccion.Checked == true)
            {
                txtRunFun.Clear();
                txtIdFun.Enabled = true;
                txtRunFun.Enabled = false;
            }
            else
            {
                txtIdFun.Clear();
                txtIdFun.Enabled = false;
                txtRunFun.Enabled = true;
            }
        }

        private void btnBuscarFun_Click(object sender, EventArgs e)
        {
            oc.Open();
            string buscador = "SELECT f.id_funcionario, f.run_funcionario, f.dv_funcionario, f.primer_nombre, f.segundo_nombre, f.apellido_paterno, f.apellido_materno, f.correo_electronico, c.nombre_cargo, usu.user_name, usu.password from usuario_prof usu join funcionario f On usu.funcionario_id_funcionario = f.id_funcionario join cargo c on f.cargo_id_cargo = c.id_cargo WHERE RUN_FUNCIONARIO = " + txtRunFun.Text + "";
            OracleDataAdapter adapt = new OracleDataAdapter(buscador, oc);
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dtvDatos.DataSource = tb;
            OracleCommand cmd = new OracleCommand(buscador, oc);
            OracleDataReader leerRunPro;
            leerRunPro = cmd.ExecuteReader();
            oc.Close();
        }

        private void btnCargarFun_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("seleccionarfuncionario", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dtvDatos.DataSource = tb;
            oc.Close();
        }

        private void btnModificarFun_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("modificacionfuncionario", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleType.Int32).Value = Convert.ToInt32(txtIdFuncionarioEnable.Text);
            cmd.Parameters.Add("R_NB", OracleType.VarChar).Value = txtRunFuncionario.Text;
            cmd.Parameters.Add("R_DV", OracleType.Char).Value = txtDvFun.Text;
            cmd.Parameters.Add("P_N", OracleType.VarChar).Value = txtPriNom.Text;
            cmd.Parameters.Add("S_N", OracleType.VarChar).Value = txtSegNom.Text;
            cmd.Parameters.Add("A_P", OracleType.VarChar).Value = txtApePat.Text;
            cmd.Parameters.Add("A_M", OracleType.VarChar).Value = txtApeMat.Text;
            cmd.Parameters.Add("CORREO", OracleType.VarChar).Value = txtCorElec.Text;
            cmd.Parameters.Add("ROL", OracleType.Int32).Value = Convert.ToInt32(cbRol.SelectedIndex + 1);
            cmd.Parameters.Add("USER", OracleType.VarChar).Value = txtUserName.Text;
            cmd.Parameters.Add("PASSWORD", OracleType.VarChar).Value = txtPassUsu.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Funcionario Modificado con Exito!!!", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            oc.Close();
        }

        private void btnEliminarFun_Click(object sender, EventArgs e)
        {

            string url = "http://localhost:4000/api/funcionario";

            funcionarioRequest oFun = new funcionarioRequest();

            try
            {
                oc.Open();
                OracleCommand cmd = new OracleCommand("SP_ELIMINAR_FUNCIONARIO", oc);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("ID", OracleType.Int32).Value = oFun.idFuncionario = Convert.ToInt32(txtIdFun.Text);
                cmd.ExecuteNonQuery();
                string resultado = Delete<funcionarioRequest>(url, oFun, "DELETE");
                MessageBox.Show("Funcionario Creado con Exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            oc.Close();
        }

        private void checkbSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            habDesTxt();
        }

        private void dtvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdFuncionarioEnable.Text = dtvDatos.CurrentRow.Cells[0].Value.ToString();
                txtRunFuncionario.Text = dtvDatos.CurrentRow.Cells[1].Value.ToString();
                txtDvFun.Text = dtvDatos.CurrentRow.Cells[2].Value.ToString();
                txtPriNom.Text = dtvDatos.CurrentRow.Cells[3].Value.ToString();
                txtSegNom.Text = dtvDatos.CurrentRow.Cells[4].Value.ToString();
                txtApePat.Text = dtvDatos.CurrentRow.Cells[5].Value.ToString();
                txtApeMat.Text = dtvDatos.CurrentRow.Cells[6].Value.ToString();
                txtCorElec.Text = dtvDatos.CurrentRow.Cells[7].Value.ToString();
                cbRol.Text = dtvDatos.CurrentRow.Cells[8].Value.ToString();
                txtUserName.Text = dtvDatos.CurrentRow.Cells[9].Value.ToString();
                txtPassUsu.Text = dtvDatos.CurrentRow.Cells[10].Value.ToString();
            }
            catch
            {

            }
        }

        public string Delete<T>(string url, T objectRequest, string method = "DELETE")
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
