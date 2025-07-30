using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionAcademica
{
    public partial class fmMatricula : Form
    {
        cLogicaBD OLogicaBD;
        SqlConnection OConexionBD;
        /* CONSTRUCTOR */
        /* ********************************************************** */
        public fmMatricula(SqlConnection OConexionBD_)
        {
            InitializeComponent();
            
            // -- Agregar una columna de botones
            DataGridViewButtonColumn botonColumna = new DataGridViewButtonColumn();
            botonColumna.Name = "Accion";
            botonColumna.HeaderText = "🔍";
            botonColumna.Text = "🔍";
            botonColumna.UseColumnTextForButtonValue = true; // Usar el texto en todas las celdas
            botonColumna.Width = 32;            

            // Agregar la columna de botones al DataGridView
            dgvAsignaturas.Columns.Add(botonColumna);
            dgvAsignaturas.Columns[3].Width = 40;
            
            // -- Asignar la Lógica de la BD
            OLogicaBD = new cLogicaBD(OConexionBD_);
            OConexionBD = OConexionBD_;
            Inicializar();
        }
        /* MÉTODOS */
        /* ********************************************************* */
        public void Inicializar()
        {
            tbCod_Alumno.Text = "";
            tbPaterno.Text = "";
            tbMaterno.Text = "";
            tbNombres.Text = "";
            tbCod_EP.Text = "";
            tbCod_Alumno.Focus();
            // -- Borrar las filas del dataGridView
            dgvAsignaturas.Rows.Clear();
        }

        /* ********************************************************* */
        public void ProcesarConsultaAlumno()
        {
            fmConsulta OfmConsulta = new fmConsulta(OConexionBD, "Consulta de Alumnos", "spu_AlumnosSelect");
            if (OfmConsulta.ShowDialog() == DialogResult.OK)
            {
                // -- Recuperar valor de Cod_EP
                tbCod_Alumno.Text = OfmConsulta.FilaDatos().Cells["Cod_Alumno"].Value.ToString();
                tbPaterno.Text = OfmConsulta.FilaDatos().Cells["Paterno"].Value.ToString();
                tbMaterno.Text = OfmConsulta.FilaDatos().Cells["Materno"].Value.ToString();
                tbNombres.Text = OfmConsulta.FilaDatos().Cells["Nombres"].Value.ToString();
                tbCod_EP.Text = OfmConsulta.FilaDatos().Cells["Cod_EP"].Value.ToString();
            }
        }

        /* ********************************************************* */
        public void ProcesarConsultaAsignatura(int Fila)
        {
            fmConsulta OfmConsulta = new fmConsulta(OConexionBD, "Consulta de Asignaturas", "spu_AsignaturasSelect");
            if (OfmConsulta.ShowDialog() == DialogResult.OK)
            {
                // -- Recuperar datos de asignatura
                dgvAsignaturas.Rows[Fila].Cells[0].Value = OfmConsulta.FilaDatos().Cells["Cod_Asignatura"].Value.ToString();
                dgvAsignaturas.Rows[Fila].Cells[1].Value = OfmConsulta.FilaDatos().Cells["Nombre_Asignatura"].Value.ToString();
                dgvAsignaturas.Rows[Fila].Cells[2].Value = OfmConsulta.FilaDatos().Cells["Creditos"].Value.ToString();
                // -- Agregar una nueva fila, sólo si no existe
                int NroFilas = dgvAsignaturas.Rows.Count;
                if ((NroFilas == 0) || (!dgvAsignaturas.Rows[NroFilas-1].IsNewRow))
                    // Agregar una fila en blanco si no hay una fila nueva
                    dgvAsignaturas.Rows.Add();
            }
        }

        /* ********************************************************* */
        public void Grabar()
        {
            Exception Error = null;
            // -- Almacenar cada fila del dgvAsignaturas
            int K = 0;
            while(Error == null && K < dgvAsignaturas.Rows.Count)
            {
                if ((!dgvAsignaturas.Rows[K].IsNewRow) || (dgvAsignaturas.Rows[K].Cells["Cod_Asignatura"].Value.ToString() != ""))
                {
                    string Cod_Asignatura = dgvAsignaturas.Rows[K].Cells["Cod_Asignatura"].Value.ToString();
                    OLogicaBD.ProcedimientoAlmacenado("spu_MatriculaInsertUpDate", out Error, tbSemestre.Text, tbCod_Alumno.Text, coCod_Asignatura, null);
                }
                K++;
            }
            if (Error == null)
            {
                MessageBox.Show("Proceso realizado satisfactoriamente...");
                Inicializar();
            }
            else
                MessageBox.Show(Error.Message);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcesarConsultaAlumno();
        }

        private void dgvAsignaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == dgvAsignaturas.Columns["Accion"].Index && e.RowIndex >= 0)
                ProcesarConsultaAsignatura(e.RowIndex);
            {

            }
        }
        /* EVENTOS */
    }
}
