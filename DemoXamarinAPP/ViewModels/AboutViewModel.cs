using DemoXamarinAPP.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinAPP.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string _welcomeText;
        public string WelcomeText { get => _welcomeText; set => SetProperty(ref _welcomeText, value); }

        public AboutViewModel()
        {            
            Title = "About";
            _welcomeText = "Bienvenido " + Application.Current.Properties["name"].ToString();
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}