using Factories.Factory.Creator;
using Factories.Factory.Product;

namespace Factories.Factory
{
    class FactoryTest
    {
        public static void Test()
        {
            MakeDelivery(creator: new BicycleCreator());
            MakeDelivery(creator: new MotoCreator());
            MakeDelivery(creator: new ShipCreator());
            MakeDelivery(creator: new PlaneCreator());
            MakeDelivery(creator: new AutoCreator());
        }

        static void MakeDelivery(ICourierCreator creator)
        {
            ICourier courier = creator.CreateCourier();
            courier.Deliver();
            // do other things w/ courier
        }
    }
}
