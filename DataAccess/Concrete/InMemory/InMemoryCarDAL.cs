using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDAL : ICarDAL
    {
        List<Car> _cars;
        List<Brand> _brand;
        List<Color> _color;
        public InMemoryCarDAL()
        {
            _cars = new List<Car>
            {
                new Car { Id=1, BrandId=1, ColorId=1, ModelYear=2002, DailyPrice=500, Description="12 Saat Kullanımlı Kiralık Aracımız"},
                new Car { Id=2, BrandId=1, ColorId=2, ModelYear=2012, DailyPrice=700, Description="Şehirler arası kullanımı yasak olan Kiralık Aracımız"},
                new Car { Id=3, BrandId=2, ColorId=3, ModelYear=2022, DailyPrice=1500, Description="Tiktak Kiralık Aracımız"},
                new Car { Id=4, BrandId=3, ColorId=2, ModelYear=2022, DailyPrice=1000, Description="Kehribar Kiralık Aracımız"},
            };

            _brand = new List<Brand>
            {
                new Brand { Id=1, Name="Wolkswagen"},
                new Brand { Id=2, Name="BMW"},
                new Brand { Id=3, Name="Tofaş"},
            };

            _color = new List<Color>
            {
                new Color { Id=1, Name="Beyaz"},
                new Color { Id=2, Name="Siyah"},
                new Color { Id=3, Name="Kırmızı"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carsToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.Description = car.Description;
        }
    }
}
