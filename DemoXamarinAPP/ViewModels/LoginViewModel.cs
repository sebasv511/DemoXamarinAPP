using DemoXamarinAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoXamarinAPP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private string _username;
        private string _password;
        private string _alertText;
        private bool _alertVisible;        

        public string UserName { get => _username; set => SetProperty(ref _username, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public string AlertText { get => _alertText; set => SetProperty(ref _alertText, value); }
        public bool AlertVisible { get => _alertVisible; set => SetProperty(ref _alertVisible, value); }        

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            if (ValidateFields())
            {
                App.Current.Properties["name"] = _username;
                ClearFields();
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                _alertText = "Debe ingresar el nombre de usuario";                
                _alertVisible = true;
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                _alertText = "Debe ingresar la contraseña";                
                _alertVisible = true;
            }
            return true;
        }

        private void ClearFields()
        {
            _username = string.Empty;
            _password = string.Empty;
            _alertVisible = false;
        }
    }
}
