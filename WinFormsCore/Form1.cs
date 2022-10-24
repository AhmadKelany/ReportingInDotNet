using ReportingInDotNet.Data;

namespace WinFormsCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //var items = await DataAccess.GetItemsAsync(200);
            reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormsCore.ReportDefinitions.TestReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}