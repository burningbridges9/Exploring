using System;

namespace Factories.Factory.Product
{
    public class Bicycle : ICourier
    {
        public void Deliver() => Console.WriteLine($"Deliver by {nameof(Bicycle)}");
    }
    public class Moto : ICourier
    {
        public void Deliver() => Console.WriteLine($"Deliver by {nameof(Moto)}");
    }
    public class Auto : ICourier
    {
        public void Deliver() => Console.WriteLine($"Deliver by {nameof(Auto)}");
    }
    public class Ship : ICourier
    {
        public void Deliver() => Console.WriteLine($"Deliver by {nameof(Ship)}");
    }
    public class Plane : ICourier
    {
        public void Deliver() => Console.WriteLine($"Deliver by {nameof(Plane)}");
    }
}
