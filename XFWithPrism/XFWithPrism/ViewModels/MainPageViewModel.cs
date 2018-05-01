using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFWithPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "Main Page";

            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }

        void Navigate()
        {
            NavigationParameters parameters = new NavigationParameters();
            parameters.Add("message", "Secondary Page");

            _navigationService.NavigateAsync("AnotherPage", parameters);
        }
    }
}
