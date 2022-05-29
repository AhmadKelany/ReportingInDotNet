namespace ReportingInDotNet.WinformsDotNet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportingInDotNet.WinformsDotNet6.ReportDefinitions.HelloWorldReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}