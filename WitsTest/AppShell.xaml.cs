namespace WitsTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            GoToAsync("//main");
        }
    }
}
