using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestGitHUb2.Services;
using TestGitHUb2.Views;

namespace TestGitHUb2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
