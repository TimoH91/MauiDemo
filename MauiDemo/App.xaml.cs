namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MinhaPagina());

            navPage.Background = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            var navPage2 = new NavigationPage(new StackLayoutPageDemo());
            var navPage3 = new NavigationPage(new GridLayoutDemo());

            MainPage = new NavigationPage(new FlexLayoutDemo());
            
        }
    }
}
