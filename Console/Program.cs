using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }
        static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDAL());
            var result=carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(result.Success);
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}