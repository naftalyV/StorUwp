using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Stor.Infra;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Stor.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private readonly IDataManager _dataManager;
        private readonly IDialogService _dialogService;
        private readonly INavigationService _navService;
        public ObservableCollection<Car> Cars { get; set; }
        public ICommand InsertCommand { get; set; }
        public RelayCommand<Car> CarSelectedCommand { get; set; }

        public MainViewModel(IDataManager dataManager, INavigationService navService, IDialogService dialogService)
        {


            _dataManager = dataManager;
            _dialogService = dialogService;
            _navService = navService;
            Cars = new ObservableCollection<Car>(_dataManager.GetAll());
            RaisePropertyChanged(nameof(Cars));


            InsertCommand = new RelayCommand(() =>
            {
                var NewCar = new Car() {  Firm = "Mazda", Model = "M5" };
                _dataManager.Insert(NewCar);
                Cars.Add(NewCar);

            });

            CarSelectedCommand = new RelayCommand<Car>((c) =>
            {
                dialogService.ShowMessageBox($"Selected car: {c.Model}", "Info");
                // navService.NavigateTo("CarDetails", c);
            });
        }
    }
}
