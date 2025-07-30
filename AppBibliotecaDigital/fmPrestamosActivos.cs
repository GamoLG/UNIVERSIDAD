using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Drawing.Printing;

using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace AppBibliotecaDigital
{
    public partial class fmPrestamosActivos : Form
    {
        private SqlConnection OConexionBD;
        private cLogicaBD LogicaBD;
        private DataTable datosOriginales;

        public fmPrestamosActivos(SqlConnection conexionBD)
        {
            InitializeComponent();
            OConexionBD = conexionBD;
            LogicaBD = new cLogicaBD(OConexionBD);

            // Configura los ComboBox para que muestren opciones y no permitan escribir
            cboFiltrarLector.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltrarLibro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void fmPrestamosActivos_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // 1. Cargar préstamos activos
                DataSet dsPrestamos = LogicaBD.ProcedimientoAlmacenado("spu_PrestamosActivosSelect");
                datosOriginales = dsPrestamos.Tables[0].Copy();
                dgvPrestamos.DataSource = datosOriginales;
                ConfigurarColumnas();

                // 2. Cargar lectores para el filtro
                DataSet dsLectores = LogicaBD.ProcedimientoAlmacenado("spu_LectoresSelect");
                cboFiltrarLector.DataSource = dsLectores.Tables[0];
                cboFiltrarLector.DisplayMember = "NombreCompleto"; // Columna que muestra
                cboFiltrarLector.ValueMember = "Cod_Lector";      // Valor real
                cboFiltrarLector.SelectedIndex = -1;               // Sin selección inicial

                // 3. Cargar libros para el filtro
                DataSet dsLibros = LogicaBD.ProcedimientoAlmacenado("spu_LibrosSelect");
                cboFiltrarLibro.DataSource = dsLibros.Tables[0];
                cboFiltrarLibro.DisplayMember = "Titulo";
                cboFiltrarLibro.ValueMember = "Cod_Libro";
                cboFiltrarLibro.SelectedIndex = -1;

                ActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvPrestamos.Columns.Count == 0) return;

            // Personaliza los nombres de las columnas
            dgvPrestamos.Columns["Id_Prestamo"].HeaderText = "ID";
            dgvPrestamos.Columns["Nombre_Lector"].HeaderText = "Lector";
            dgvPrestamos.Columns["Titulo_Libro"].HeaderText = "Libro";
            dgvPrestamos.Columns["Fecha_Prestamo"].HeaderText = "Fecha Préstamo";
            dgvPrestamos.Columns["Dias_Prestamo"].HeaderText = "Días Transcurridos";
            dgvPrestamos.Columns["Estado"].HeaderText = "Estado";

            // Ajusta el ancho de algunas columnas
            dgvPrestamos.Columns["Id_Prestamo"].Width = 50;
            dgvPrestamos.Columns["Dias_Prestamo"].Width = 60;
        }

        private void ActualizarContador()
        {
            sslCantidad.Text = $"Préstamos activos: {dgvPrestamos.Rows.Count}";
        }

        private void AplicarFiltros()
        {
            if (datosOriginales == null) return;

            string filtro = "";

            // Filtro por Lector
            if (cboFiltrarLector.SelectedIndex >= 0)
            {
                filtro += $"[Cod_Lector] = '{cboFiltrarLector.SelectedValue}'";
            }

            // Filtro por Libro
            if (cboFiltrarLibro.SelectedIndex >= 0)
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"[Cod_Libro] = '{cboFiltrarLibro.SelectedValue}'";
            }

            // Aplica el filtro
            DataView vistaFiltrada = new DataView(datosOriginales);
            vistaFiltrada.RowFilter = filtro;
            dgvPrestamos.DataSource = vistaFiltrada.ToTable();

            ActualizarContador();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el PDF", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                FileName = $"PrestamosActivos_{DateTime.Now:yyyyMMddHHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                GenerarPDF(saveDialog.FileName);
            }
        }

        private void GenerarPDF(string filePath)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.Landscape = true; // Configurar orientación horizontal
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                pd.PrinterSettings.PrintToFile = true;
                pd.PrinterSettings.PrintFileName = filePath;

                // Configurar márgenes
                int margin = 40;
                pd.DefaultPageSettings.Margins = new Margins(margin, margin, margin, margin);

                pd.PrintPage += (sender, e) =>
                {
                    // Configuración de fuentes
                    Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
                    Font fontSubtitulo = new Font("Arial", 10);
                    Font fontEncabezado = new Font("Arial", 10, FontStyle.Bold);
                    Font fontDatos = new Font("Arial", 9);
                    Font fontPie = new Font("Arial", 9, FontStyle.Italic);

                    // Variables de posición
                    float yPos = e.MarginBounds.Top;
                    float xPos = e.MarginBounds.Left;

                    // 1. Título del reporte
                    e.Graphics.DrawString("REPORTE DE PRÉSTAMOS ACTIVOS", fontTitulo,
                                        Brushes.Black, xPos, yPos);
                    yPos += 30;

                    // 2. Subtítulo (fecha y hora)
                    e.Graphics.DrawString($"Generado el: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}",
                                        fontSubtitulo, Brushes.Black, xPos, yPos);
                    yPos += 20;

                    // 3. Encabezados de columnas
                    float[] columnWidths = CalcularAnchosColumnas(e.Graphics, fontEncabezado);
                    float headerHeight = fontEncabezado.GetHeight() + 10;

                    // Dibujar fondo de encabezados
                    e.Graphics.FillRectangle(Brushes.LightGray, xPos, yPos,
                                            columnWidths.Sum(), headerHeight);

                    // Dibujar encabezados
                    for (int i = 0; i < dgvPrestamos.Columns.Count; i++)
                    {
                        RectangleF rect = new RectangleF(xPos, yPos, columnWidths[i], headerHeight);
                        e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                        e.Graphics.DrawString(dgvPrestamos.Columns[i].HeaderText,
                                            fontEncabezado, Brushes.Black, rect,
                                            new StringFormat()
                                            {
                                                Alignment = StringAlignment.Center,
                                                LineAlignment = StringAlignment.Center
                                            });
                        xPos += columnWidths[i];
                    }
                    yPos += headerHeight;

                    // 4. Datos de las filas
                    foreach (DataGridViewRow row in dgvPrestamos.Rows)
                    {
                        xPos = e.MarginBounds.Left;
                        float rowHeight = CalcularAlturaFila(e.Graphics, fontDatos, row, columnWidths);

                        // Alternar color de fondo para mejor legibilidad
                        Brush rowBrush = row.Index % 2 == 0 ? Brushes.White : Brushes.WhiteSmoke;
                        e.Graphics.FillRectangle(rowBrush, xPos, yPos, columnWidths.Sum(), rowHeight);

                        // Dibujar celdas
                        for (int i = 0; i < dgvPrestamos.Columns.Count; i++)
                        {
                            RectangleF rect = new RectangleF(xPos, yPos, columnWidths[i], rowHeight);
                            e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);

                            string cellValue = row.Cells[i].Value?.ToString() ?? "";
                            e.Graphics.DrawString(cellValue, fontDatos, Brushes.Black, rect,
                                                new StringFormat()
                                                {
                                                    Alignment = StringAlignment.Center,
                                                    LineAlignment = StringAlignment.Center,
                                                    Trimming = StringTrimming.EllipsisCharacter
                                                });
                            xPos += columnWidths[i];
                        }
                        yPos += rowHeight;

                        // Verificar si necesita nueva página
                        if (yPos > e.MarginBounds.Bottom - 50)
                        {
                            e.HasMorePages = true;
                            return;
                        }
                    }

                    // 5. Pie de página
                    e.Graphics.DrawString($"Total de préstamos: {dgvPrestamos.Rows.Count}", fontPie,
                                        Brushes.Black, e.MarginBounds.Left, yPos + 20);
                };

                pd.Print();
                MessageBox.Show("PDF generado con éxito", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar para calcular anchos de columnas
        private float[] CalcularAnchosColumnas(Graphics g, Font font)
        {
            float totalWidth = 800; // Ancho total disponible en horizontal
            float[] widths = new float[dgvPrestamos.Columns.Count];

            // Asignar anchos proporcionales basados en el contenido
            for (int i = 0; i < dgvPrestamos.Columns.Count; i++)
            {
                float headerWidth = g.MeasureString(dgvPrestamos.Columns[i].HeaderText, font).Width;
                float maxDataWidth = 0;

                foreach (DataGridViewRow row in dgvPrestamos.Rows)
                {
                    float cellWidth = g.MeasureString(row.Cells[i].Value?.ToString() ?? "", font).Width;
                    if (cellWidth > maxDataWidth)
                        maxDataWidth = cellWidth;
                }

                widths[i] = Math.Max(headerWidth, maxDataWidth) + 20; // +20 para padding
            }

            // Ajustar proporcionalmente al ancho total
            float totalCurrent = widths.Sum();
            float factor = totalWidth / totalCurrent;

            for (int i = 0; i < widths.Length; i++)
            {
                widths[i] *= factor;
            }

            return widths;
        }

        // Método auxiliar para calcular altura de fila
        private float CalcularAlturaFila(Graphics g, Font font, DataGridViewRow row, float[] columnWidths)
        {
            float maxHeight = 0;

            for (int i = 0; i < row.Cells.Count; i++)
            {
                string text = row.Cells[i].Value?.ToString() ?? "";
                SizeF size = g.MeasureString(text, font, (int)columnWidths[i]);
                if (size.Height > maxHeight)
                    maxHeight = size.Height;
            }

            return Math.Max(maxHeight, font.GetHeight() + 6); // Altura mínima
        }

        // Eventos de los ComboBox
        private void cboFiltrarLector_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cboFiltrarLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // Botón para limpiar filtros (agrégalo si lo necesitas)
        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cboFiltrarLector.SelectedIndex = -1;
            cboFiltrarLibro.SelectedIndex = -1;
            dgvPrestamos.DataSource = datosOriginales;
            ActualizarContador();
        }
    }
}