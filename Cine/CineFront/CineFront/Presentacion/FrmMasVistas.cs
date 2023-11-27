using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class FrmMasVistas : Form
    {
        public FrmMasVistas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void FrmMasVistas_Load(object sender, EventArgs e)
        {
            //Creo el TableAdapter
            Reportes.DSPeliculasMasVistasTableAdapters.TA_PELICULASMASVISTASTableAdapter tableAdapter = new Reportes.DSPeliculasMasVistasTableAdapters.TA_PELICULASMASVISTASTableAdapter();
            //Obtengo el DataTable del TableAdapter
            Reportes.DSPeliculasMasVistas.TA_PELICULASMASVISTASDataTable dataTable = tableAdapter.GetData();
            //Creo origen de datos para el reporte
            ReportDataSource dataSource = new ReportDataSource("DataSet1", (IEnumerable)dataTable);

            //Configuro el DataSource para el reporte
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            //Especifico la ruta del reporte embebido y refresco
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.RptPeliculasMasVistas.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
