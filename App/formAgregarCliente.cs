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
using App.Model.Request;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

namespace App
{
    public partial class formAgregarCliente : Form
    {
        public formAgregarCliente()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        string url = "http://localhost:4000/api/cliente";

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:4000/api/funcionario";

            clienteRequest oRepLegal = new clienteRequest();

            MemoryStream ms = new MemoryStream();
            pbEscritura.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            try
            {
                oc.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = oc;
                cmd.CommandText = "SP_AGREGAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_RUN_REP_LEGAL", OracleType.VarChar).Value = oRepLegal.runRepLegal = txtRunRep.Text;
                cmd.Parameters.Add("P_DV_REP_LEGAL", OracleType.VarChar).Value = oRepLegal.dvRepLegal = txtDvRep.Text;
                cmd.Parameters.Add("P_PRIMER_NOMBRE", OracleType.VarChar).Value = oRepLegal.primerNombre = txtPriNomRep.Text;
                cmd.Parameters.Add("P_SEGUNDO_NOMBRE", OracleType.VarChar).Value = oRepLegal.segundoNombre = txtSegNomRep.Text;
                cmd.Parameters.Add("P_APELLIDO_PATERNO", OracleType.VarChar).Value = oRepLegal.apellidoPaterno = txtApePatRep.Text;
                cmd.Parameters.Add("P_APELLIDO_MATERNO", OracleType.VarChar).Value = oRepLegal.apellidoMaterno = txtApeMatRep.Text;
                cmd.Parameters.Add("P_FEC_NAC", OracleType.DateTime).Value = dtpFecNacRep.Value;
                cmd.Parameters.Add("P_CORREO", OracleType.VarChar).Value = oRepLegal.correoRepLegal = txtCorElecRep.Text;
                cmd.Parameters.Add("P_TELEFONO_CELULAR", OracleType.VarChar).Value = oRepLegal.telefonoCelular = txtTelCelRep.Text;
                cmd.Parameters.Add("P_TELEFONO_FIJO", OracleType.VarChar).Value = oRepLegal.telefonoFijo = txtTelFijRep.Text;
                cmd.Parameters.Add("P_NOMBRE_CALLE", OracleType.VarChar).Value = oRepLegal.nombreCalle = txtNomCalle.Text;
                cmd.Parameters.Add("P_NUMERO_DOMICILIO", OracleType.VarChar).Value = oRepLegal.numeroDomicilio = txtNumDom.Text;
                cmd.Parameters.Add("P_TIPO_DOMICILIO", OracleType.VarChar).Value = oRepLegal.tipoDomicilio = txtTipDom.Text;
                cmd.Parameters.Add("P_NOMBRE_COMUNA", OracleType.VarChar).Value = oRepLegal.nombreComuna = txtComuna.Text;
                cmd.Parameters.Add("P_USER_REP", OracleType.VarChar).Value = oRepLegal.nombreUsuarioRep = txtNomUsuRep.Text;
                cmd.Parameters.Add("P_PASSWORD", OracleType.VarChar).Value = oRepLegal.passwordRep = txtPassUsuRep.Text;
                cmd.Parameters.Add("P_RUT_EMPRESA", OracleType.VarChar).Value = oRepLegal.runEmpresa = txtRutEmp.Text;
                cmd.Parameters.Add("P_DV_EMPRESA", OracleType.VarChar).Value = oRepLegal.dvEmpresa = txtDvEmp.Text;
                cmd.Parameters.Add("P_NOMBRE_EMP", OracleType.VarChar).Value = oRepLegal.nombreEmpresa = txtNomEmp.Text;
                cmd.Parameters.Add("P_GIRO_EMP", OracleType.VarChar).Value = oRepLegal.giroEmpresa = txtGirEmp.Text;
                cmd.Parameters.Add("P_CASA_MATRIZ", OracleType.VarChar).Value = oRepLegal.casaMatriz = txtCasaMat.Text;
                cmd.Parameters.Add("P_CORREO_ELECTRONICO", OracleType.VarChar).Value = oRepLegal.correoElectronicoEmpresa = txtCorEmp.Text;
                cmd.Parameters.AddWithValue("P_ESCRITURA", aByte);
                cmd.Parameters.Add("P_NUM_CASA_MATRIZ", OracleType.VarChar).Value = oRepLegal.numeroCasaMatriz = txtNumCasa.Text;
                cmd.Parameters.Add("P_TELEFONO_EMP", OracleType.VarChar).Value = oRepLegal.telefonoEmpresa = txtTelEmp.Text;
                cmd.Parameters.Add("P_REGION_ID", OracleType.Int32).Value = oRepLegal.regionID = cbRegion.SelectedIndex + 1;
                cmd.ExecuteNonQuery();
                string resultado = Send<clienteRequest>(url, oRepLegal, "POST");
                MessageBox.Show("Cliente Creado con Exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCargarEsc_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();
            select.Filter = "Imagenes|*.jpg; *.png";
            select.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            select.Title = "Seleccionar imagen";

            if (select.ShowDialog() == DialogResult.OK)
            {
                pbEscritura.Image = Image.FromFile(select.FileName);
            }
        }
    }
}
