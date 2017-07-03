using Stor.Infra;
using Stor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stor
{
    class DataManager : IDataManager
    {
        public List<Car> GetAll()
        {
            using (var db = new CarsContext())
            {
                return db.Cars.Select(c => c).ToList();
            }
        }

        public Car GetById(int Id)
        {
            using (var db = new CarsContext())
            {
                return db.Cars.SingleOrDefault(c => c.Id == Id);
            }
        }

        public void Insert(Car NewCar)
        {
            using (var db = new CarsContext())
            {
                db.Cars.Add(NewCar);
                db.SaveChanges();
            }

        }
    }
}
