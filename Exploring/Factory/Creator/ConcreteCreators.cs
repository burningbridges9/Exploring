using Factories.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.Factory.Creator
{
    public class BicycleCreator : ICourierCreator
    {
        public ICourier CreateCourier()
        {
            Console.WriteLine($"Create {nameof(Bicycle)} by {nameof(BicycleCreator)}");
            return new Bicycle();
        }
    }
    public class MotoCreator : ICourierCreator
    {
        public ICourier CreateCourier()
        {
            Console.WriteLine($"Create {nameof(Moto)} by {nameof(MotoCreator)}");
            return new Moto();
        }
    }
    public class AutoCreator : ICourierCreator
    {
        public ICourier CreateCourier()
        {
            Console.WriteLine($"Create {nameof(Auto)} by {nameof(AutoCreator)}");
            return new Auto();
        }
    }
    public class ShipCreator : ICourierCreator
    {
        public ICourier CreateCourier()
        {
            Console.WriteLine($"Create {nameof(Ship)} by {nameof(ShipCreator)}");
            return new Ship();
        }
    }
    public class PlaneCreator : ICourierCreator
    {
        public ICourier CreateCourier()
        {
            Console.WriteLine($"Create {nameof(Plane)} by {nameof(PlaneCreator)}");
            return new Plane();
        }
    }
}
