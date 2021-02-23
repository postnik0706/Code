using System;

namespace Packt.Shared
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"Business class";
        }
    }

    public class FirstClassPassenger
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First class with {AirMiles:N0} air miles";
        }
    }

    public class CoachClassPassender
    {
        public double CarryOnKg { get; set; }
        public override string ToString()
        {
            return $"Coach Class with {CarryOnKg:N2} KG carry on";
        }
    }
}
