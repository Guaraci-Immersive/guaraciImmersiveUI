namespace GuaraciImmersive
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("DashboardPage", typeof(Views.DashboardPage));
        }
    }
}
