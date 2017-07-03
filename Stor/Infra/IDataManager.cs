using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stor.Infra
{
    public interface IDataManager
    {
        List<Car> GetAll();
        Car GetById(int Id);
        void Insert(Car NewCar);
    }
}
