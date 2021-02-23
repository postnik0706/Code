using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        public void OlderTest()
        {
            object[] passengers = {
                new FirstClassPassenger { AirMiles = 1_419 },
                new FirstClassPassenger {AirMiles = 16_652},
                new BusinessClassPassenger(),
                new CoachClassPassender { CarryOnKg = 25.7 },
                new CoachClassPassender {CarryOnKg = 0}
            };

            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        >= 35_000 => 1500M,
                        >= 15_000 => 1750M,
                        _ => 2000M
                    },
                    BusinessClassPassenger => 1000M,
                    CoachClassPassender p when p.CarryOnKg < 10.0 => 500M,
                    CoachClassPassender => 650M,
                    _ => 800M
                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

            var jeff = new ImmutablePerson
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };
            // jeff.FirstName = "Geoff";

            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Red"
            };

            var repaintedCar = car with 
            {
                Color = "Silver"
            };

            WriteLine($"Original color {car.Color}, new color {repaintedCar.Color}");
            var oscar = new ImmutableAnimal("Oscar", "Labrador");
            var (who, what) = oscar;
            WriteLine($"{who} is {what}");
        }

        static void Main(string[] args)
        {
            Person harry = new Person("Harry");
            harry.Shout = Person_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }

        private static void Person_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
