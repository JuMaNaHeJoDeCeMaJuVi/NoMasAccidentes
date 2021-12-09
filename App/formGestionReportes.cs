using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.OracleClient;

namespace App
{
    public partial class formGestionReportes : Form
    {
        public formGestionReportes()
        {
            InitializeComponent();
        }

        //Conexion Oracle
        OracleConnection oc = new OracleConnection("DATA SOURCE = xe; PASSWORD = duoc2021; USER ID = NMA;");

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "Reporte.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("incapaz de escribir datos en el disco" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable tb = new PdfPTable(dgvDatos.Columns.Count);
                            tb.DefaultCell.Padding = 2;
                            tb.WidthPercentage = 100;
                            tb.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvDatos.Columns)
                            {
                                PdfPCell pc = new PdfPCell(new Phrase(column.HeaderText));
                                tb.AddCell(pc);
                            }

                            foreach (DataGridViewRow vr in dgvDatos.Rows)
                            {
                                foreach (DataGridViewCell vc in vr.Cells)
                                {
                                    tb.AddCell(vc.Value.ToString());
                                }
                            }

                            using (FileStream filestr = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document doc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                doc.Open();
                                doc.Add(tb);
                                doc.Close();
                                filestr.Close();
                            }
                            MessageBox.Show("Archivo Exportado con Exito", "ATENCIÓN!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al intentar exportar el archivo" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se a encontrado ningun archivo", "ATENCIÓN!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            oc.Open();
            string buscador = "select c.id_contrato, c.fecha_contrato, e.rut_empresa, e.dv_empresa, e.nombre_empresa, e.giro_empresa, s.motivo_servicio, s.monto_servicio, a.gravedad, a.causa FROM accidente a RIGHT JOIN asesoria asa on a.asesoria_id_asesoria = asa.id_asesoria RIGHT JOIN servicio s on asa.servicio_id_servicio = s.id_servicio RIGHT JOIN contrato c on s.contrato_id_contrato = c.id_contrato RIGHT JOIN rep_legal r on c.rep_legal_id_rep_legal = r.id_rep_legal RIGHT JOIN empresa e on r.empresa_id_empresa = e.id_empresa; WHERE c.id_contrato = " + txtIdCont.Text + "";
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
            OracleCommand cmd = new OracleCommand("SP_CARGAR_REPORTE", oc);
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
