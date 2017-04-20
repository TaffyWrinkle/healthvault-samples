﻿using System.Threading.Tasks;
using System.Windows.Input;
using HealthVault.Sample.Xamarin.Core.Services;
using HealthVault.Sample.Xamarin.Core.Views;
using Microsoft.HealthVault.Client;
using Xamarin.Forms;

namespace HealthVault.Sample.Xamarin.Core.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private readonly IHealthVaultSodaConnection connection;

        public MainPageViewModel(
            IHealthVaultSodaConnection connection,
            INavigationService navigationService, 
            IPlatformResourceProvider resourceProvider) : 
            base(navigationService, resourceProvider)
        {
            this.connection = connection;
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            await connection.AuthenticateAsync();

            var personInfo = await connection.GetPersonInfoAsync();

            var menuPage = new MenuPage()
            {
                BindingContext = new MenuViewModel(NavigationService, ResourceProvider)
            };
            NavigationService.Navigate(menuPage);
        }

        public ICommand LoginCommand { get; }
    }
}