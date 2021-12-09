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
using System.IO;
using System.Drawing.Imaging;

namespace App
{
    public partial class formGestionVisitas : Form
    {
        public formGestionVisitas()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            oc.Open();
            string buscador = "SELECT * from visita WHERE id_visita = " + txtIdVisita.Text + "";
            OracleDataAdapter adapt = new OracleDataAdapter(buscador, oc);
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dgvDatos.DataSource = tb;
            OracleCommand cmd = new OracleCommand(buscador, oc);
            OracleDataReader leerRunPro;
            leerRunPro = cmd.ExecuteReader();
            oc.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("SP_CARGAR_VISITA", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dgvDatos.DataSource = tb;
            oc.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbInforme.Image.Save(ms, ImageFormat.Jpeg);
            pbLista.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            oc.Open();
            OracleCommand cmd = new OracleCommand("SP_MODIFICAR_VISITA", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleType.Int32).Value = Convert.ToInt32(txtVisitaId.Text);
            cmd.Parameters.Add("CANT_VISITA", OracleType.VarChar).Value = txtCanVisita.Text;
            cmd.Parameters.Add("MOTIVO", OracleType.Char).Value = txtMotivoVisita.Text;
            cmd.Parameters.Add("COMENTARIO", OracleType.Char).Value = txtComentario.Text;
            cmd.Parameters.AddWithValue("LISTA", aByte).Value = pbLista.Image;
            cmd.Parameters.Add("FEC_VISITA", OracleType.DateTime).Value = dtpFecVis.Value;
            cmd.Parameters.AddWithValue("INFORME", aByte).Value = pbInforme.Image;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Visita Modificado con Exito!!!", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            oc.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("SP_ELIMINAR_VISITA", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleType.Int32).Value = Convert.ToInt32(txtIdVisita.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Visita eliminada con Exito!!!", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            oc.Close();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtVisitaId.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                txtCanVisita.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtMotivoVisita.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtComentario.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                pbLista.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                dtpFecVis.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                pbInforme.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
