using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stor.ViewModel
{
    class CarDetailsViewModel: ViewModelBase
    {
        private Car _SelectedCar;
        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set
            {
                _SelectedCar = value;
                RaisePropertyChanged();
            }
        }

        public CarDetailsViewModel()
        {

        }
    }
}
