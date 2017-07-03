using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Stor.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stor.ViewModel
{
    class ViewModelLocator
    {

            public ViewModelLocator()
        {
        ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CarDetailsViewModel>();
            SimpleIoc.Default.Register<IDataManager, DataManager>();
            SimpleIoc.Default.Register<IDialogService, DialogService>();

            var navService = new NavigationService();
            navService.Configure(nameof(MainPage), typeof(MainPage));
          //  navService.Configure(nameof(CarDetails), typeof(CarDetails));

            SimpleIoc.Default.Register<INavigationService>(() => navService);


        }
        public MainViewModel MainVM
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public CarDetailsViewModel CustomerDetailsVM
        {
            get { return ServiceLocator.Current.GetInstance<CarDetailsViewModel>(); }
        }
    }
}
