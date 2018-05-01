using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFWithPrism.ViewModels
{
    public class AnotherPageViewModel : ViewModelBase, INavigationAware
    {
        public AnotherPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            Title = (string)parameters["message"];
        }  
    }
}
