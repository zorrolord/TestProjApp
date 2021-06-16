using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new();

            Console.WriteLine("Please enter your desired Fueltype:");
            if(string.IsNullOrEmpty(car.FuelType = Console.ReadLine()))
            {
                throw new Exception($"{nameof(car.FuelType)} cannot be empty");
            }


            Console.WriteLine("Please enter your desired amount of Horsepower");
            try
            {
                car.Horsepower = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Console.WriteLine("Please enter your desired amount of Seats");
            try
            {
                car.NumberOfSeats = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Console.WriteLine("Your new car will have:");
            Console.WriteLine($"Fueltype: {car.FuelType}, Horsepower: {car.Horsepower}, Number of seats: {car.NumberOfSeats}");
        }
    }
}
