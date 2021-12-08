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
    public partial class formBusquedaEmpresa : Form
    {
        public formBusquedaEmpresa()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            oc.Open();
            string buscador = "select emp.id_empresa, emp.rut_empresa, emp.dv_empresa, emp.nombre_empresa, emp.giro_empresa, emp.casa_matriz, emp.correo_empresa, emp.numero_casa_matriz, emp.telefono_empresa, rl.primer_nombre || ' ' || rl.segundo_nombre, rl.apellido_paterno || ' ' || rl.apellido_materno, rl.telefono_celular, c.fecha_contrato, c.fecha_fin_contrato, m.monto, m.fecha_emision, m.fecha_vencimiento, p.fecha_pago, p.monto_cancelado, p.tipo_pago from pago p join mensualidad m on p.mensualidad_id_mensualidad = m.id_mensualidad join contrato c on m.contrato_id_contrato = c.id_contrato join rep_legal rl on c.rep_legal_id_rep_legal = rl.id_rep_legal join empresa emp on rl.empresa_id_empresa = emp.id_empresa WHERE rut_empresa = " + txtRutEmpresa.Text + "";
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
            OracleCommand cmd = new OracleCommand("seleccionarEmpresa", oc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapt.Fill(tb);
            dgvDatos.DataSource = tb;
            oc.Close();
        }
    }
}
