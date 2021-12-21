using Momo.Services;
using Momo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Momo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //NavigationPage navigation = new NavigationPage( new NavigationDemo());
            //navigation.BackgroundColor = Color.Green;
            //navigation.BarTextColor = Color.White;
            //DependencyService.Register<MockDataStore>();
            MainPage = new NonNavigation();
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
