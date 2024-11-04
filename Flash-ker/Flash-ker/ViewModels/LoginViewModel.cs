using Flash_ker.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Flash_ker.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _text;
        private string _description;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Navigate to AboutPage using a different navigation stack
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}