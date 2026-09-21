using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_prototipoumg2k26;

namespace CapaVista_prototipoumg2k26.Reportes
{
    public partial class frmReporteClientes : Form
    {
        private ModeloCliente cliente = new ModeloCliente();
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("ReporteClientes", cliente.GetAll());
            reportViewer1.LocalReport.ReportEmbeddedResource =  "CapaVista_prototipoumg2k26.Reportes.ReportClientes.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
