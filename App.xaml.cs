using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//export font
[assembly : ExportFont("PalanquinDark-Regular.ttf",Alias = "myFavFont")]
namespace TicTacToeGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
