using Factories.Factory.Product;

namespace Factories.Factory.Creator
{
    public interface ICourierCreator
    {
        ICourier CreateCourier(); 
    }
}
