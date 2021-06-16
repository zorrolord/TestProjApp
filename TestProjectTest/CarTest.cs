using CarLib;
using System;
using Xunit;

namespace TestProjectTest
{
    public class CarTest
    {
        static string fuelType = "benzine";
        static string numberOfSeats = "4";
        static string horsePower = "150";

        [Fact]
        public void CreateConstructor_Passing()
        {
            Car c = new();

            Assert.NotNull(c);
            //Assert.Equal($"", p.ToString());
        }

        [Fact]
        public void CreateConstructorWithArguments_Passing()
        {
            Car c = new(horsePower, numberOfSeats, fuelType);

            Assert.Equal(horsePower, c.HorsePower);
            Assert.Equal(numberOfSeats, c.NumberOfSeats);
            Assert.Equal(fuelType, c.FuelType);

            Assert.Equal($"{horsePower} {numberOfSeats} {fuelType}", c.ToString());
        }

        [Fact]
        public void CreateConstructorWithProperties_Passing()
        {
            Car c = new()
            {
                HorsePower = horsePower,
                NumberOfSeats = numberOfSeats,
                FuelType = fuelType
            };

            Assert.Equal(horsePower, c.HorsePower);
            Assert.Equal(numberOfSeats, c.NumberOfSeats);
            Assert.Equal(fuelType, c.FuelType);

            Assert.Equal($"{horsePower} {numberOfSeats} {fuelType}", c.ToString());
        }
    }
}
