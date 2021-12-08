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

namespace App
{
    public partial class formGestionContratos : Form
    {
        public formGestionContratos()
        {
            InitializeComponent();
            txtIdCon.Enabled = false;
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            oc.Open();
            string buscador = "select c.id_contrato, c.fecha_contrato, c.fecha_fin_contrato, m.monto, m.fecha_emision, m.fecha_vencimiento, p.fecha_pago, p.monto_cancelado, p.tipo_pago from pago p join mensualidad m on p.mensualidad_id_mensualidad = m.id_mensualidad join contrato c on m.contrato_id_contrato = c.id_contrato WHERE id_contrato = " + txtIdContrato.Text + "";
            OracleDataAdapter adapt = new OracleDataAdapter(buscador, oc);
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dgvDatos.DataSource = tb;
            OracleCommand cmd = new OracleCommand(buscador, oc);
            OracleDataReader leerRunPro;
            leerRunPro = cmd.ExecuteReader();
            oc.Close();
        }

        private void btnCargarTodo_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("seleccionarContrato", oc);
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
            oc.Open();
            OracleCommand cmd = new OracleCommand("modificacionContrato", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleType.Int32).Value = Convert.ToInt32(txtIdCon.Text);
            cmd.Parameters.Add("FEC_CON", OracleType.DateTime).Value = dtpFecContrato.Value;
            cmd.Parameters.Add("FEC_FIN_CON", OracleType.DateTime).Value = dtpFecFinContrato.Value;
            cmd.Parameters.Add("MONT", OracleType.Int32).Value = Convert.ToInt32(txtMonto.Text);
            cmd.Parameters.Add("FEC_EMISION", OracleType.DateTime).Value = dtpFecEmision.Value;
            cmd.Parameters.Add("FEC_VENCIMIENTO", OracleType.DateTime).Value = dtpFecVencimiento.Value;
            cmd.Parameters.Add("FEC_PAGO", OracleType.DateTime).Value = dtpFecPago.Value;
            cmd.Parameters.Add("M_CANCELADO", OracleType.Int32).Value = Convert.ToInt32(txtMontoCancelado.Text);
            cmd.Parameters.Add("TIP_PAGO", OracleType.VarChar).Value = txtTipPago.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Contrato Modificado con Exito!!!", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            oc.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oc.Open();
            OracleCommand cmd = new OracleCommand("eliminarContrato", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleType.Int32).Value = Convert.ToInt32(txtIdContrato.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Contrato Eliminado con Exito!!!", "ALERTA!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            oc.Close();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCon.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                dtpFecContrato.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                dtpFecFinContrato.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtMonto.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                dtpFecEmision.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                dtpFecVencimiento.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                dtpFecPago.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
                txtMontoCancelado.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString();
                txtTipPago.Text = dgvDatos.CurrentRow.Cells[8].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
