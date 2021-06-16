using System;

namespace CarLib
{
    public class Car
    {
        private string horsePower;
        private string numberOfSeats;
        private string fuelType;

        public Car() { }

        public Car(string horsePower, string numberOfSeats, string fuelType)
        {
            this.HorsePower = horsePower;
            this.NumberOfSeats = numberOfSeats;
            this.FuelType = fuelType;
        }

        public string HorsePower
        {
            get => this.horsePower;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"{nameof(Car)}:{nameof(HorsePower)}");
                }

                this.horsePower = value;
            }
        }
        public string NumberOfSeats
        {
            get => this.numberOfSeats;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"{nameof(Car)}:{nameof(NumberOfSeats)}");
                }

                this.numberOfSeats = value;
            }
        }

        public string FuelType
        {
            get => this.fuelType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"{nameof(Car)}:{nameof(FuelType)}");
                }

                this.fuelType = value;
            }
        }

        public override string ToString()
        {
            return $"{this.HorsePower} {this.NumberOfSeats} {this.FuelType}";
        }
    }
}
