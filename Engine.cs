using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Engine : IEquatable<Engine?>
    {
        public override string ToString()
        {
            return $"Engine {Power}";
        }
        public Engine(int power)
        {
            Power = power;
        }

        public int Power { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Engine);
        }

        public bool Equals(Engine? other)
        {
            return other is not null &&
                   Power == other.Power;
        }

        public static bool operator ==(Engine? left, Engine? right)
        {
            return EqualityComparer<Engine>.Default.Equals(left, right);
        }

        public static bool operator !=(Engine? left, Engine? right)
        {
            return !(left == right);
        }
    }
    class Wheel : IEquatable<Wheel?>
    {
        public override string ToString()
        {
            return $"Wheel{Radius}";
        }
        public Wheel(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Wheel);
        }

        public bool Equals(Wheel? other)
        {
            return other is not null &&
                   Radius == other.Radius;
        }
    }
}
