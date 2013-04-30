namespace SampleApplication
{
    public class Coin : InAppPurchaseToggle.RepeatPurchaseToggleBase
    {
        protected override int SetAvailableStoreInstances()
        {
            return 100;
        }

        protected override InAppPurchaseToggle.IRepeatPurchaseToggleNameInstanceFormatter SetNameInstanceFormatter()
        {
            return new InAppPurchaseToggle.NameNumberFormatter();            
        }
    }

    class MyClass
    {
         void DemoCode()
         {
             var t = new Coin();

             int totalInstancesAvailable = t.AvailableStoreInstances;

             int nextUnpurchased = t.GetNextLowestUnpurchasedInstance();

             int totalInstancesPurchasedSoFar = t.GetTotalPurchased();

             bool userPurchasedAllInstances = t.IsAllPurchased();

             bool isThirtySecondInstancePurchased = t.IsInstancePurchased(32);
         }
    }
}
