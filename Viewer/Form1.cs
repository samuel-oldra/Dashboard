namespace Viewer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.DashboardSource = new System.Uri("Dashboard.xml", System.UriKind.Relative);
        }
    }
}