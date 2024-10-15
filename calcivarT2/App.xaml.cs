using calcivarT2.Views;

namespace calcivarT2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VLogin());
        }
    }
}
