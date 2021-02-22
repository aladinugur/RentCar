using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemorycar());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------------");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Id: "+car.Id+" "+car.Description);

            }
        
        }
    }
}
