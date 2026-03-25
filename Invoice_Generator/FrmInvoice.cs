using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Invoice_Generator
{
    public partial class FrmInvoice : Form
    {
        public int _InvoiceId;

        public FrmInvoice(int InvoiceId)
        {
            InitializeComponent();

            _InvoiceId = InvoiceId;
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Create instances of your DataSets and TableAdapters
                // These names should match the namespaces in your project
                InvoicesDataSet ds = new InvoicesDataSet();
                InvoicesDataSetTableAdapters.InvoicesTableAdapter adpInvoices = new InvoicesDataSetTableAdapters.InvoicesTableAdapter();
                InvoicesDataSetTableAdapters.InvoiceItemsTableAdapter adpItems = new InvoicesDataSetTableAdapters.InvoiceItemsTableAdapter();
                InvoicesDataSetTableAdapters.ShopTableAdapter shopData = new InvoicesDataSetTableAdapters.ShopTableAdapter();

                // 2. Fill the DataTables using the parameter passed to the form
                // This executes your "SELECT ... WHERE InvoiceId = @InvId" query
                adpInvoices.Fill(ds.Invoices, _InvoiceId);
                adpItems.Fill(ds.InvoiceItems, _InvoiceId);
                shopData.Fill(ds.Shop, 1);

                // 3. Clear existing report data sources
                reportViewer1.LocalReport.DataSources.Clear();

                // 4. Add the new data sources. 
                // Note: The "Name" property must EXACTLY match the name 
                // shown in the "Report Data" pane in your first screenshot.
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoicesDataSet", (DataTable)ds.Invoices));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceItemsDataSet", (DataTable)ds.InvoiceItems));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ShopDataSet", (DataTable)ds.Shop));

                // 5. Refresh the report to show data
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
