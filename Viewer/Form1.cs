namespace Viewer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region Public Constructors

        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.DashboardSource = new System.Uri("Dashboard.xml", System.UriKind.Relative);
        }

        #endregion Public Constructors
    }
}