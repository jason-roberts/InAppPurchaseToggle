using InAppPurchaseToggle;
namespace MoqaLate.Autogenerated
{
public partial class StoreGatewayMoqaLate : IStoreGateway
{


// -------------- IsPurchased ------------ 

private bool _isPurchasedReturnValue;

        private int _isPurchasedNumberOfTimesCalled;

        public string IsPurchasedParameter_inAppOfferName_LastCalledWith;
        
        public virtual void IsPurchasedSetReturnValue(bool value)
        {
            _isPurchasedReturnValue = value;
        }    


        public virtual bool IsPurchasedWasCalled()
{
   return _isPurchasedNumberOfTimesCalled > 0;
}


public virtual bool IsPurchasedWasCalled(int times)
{
   return _isPurchasedNumberOfTimesCalled == times;
}


public virtual int IsPurchasedTimesCalled()
{
   return _isPurchasedNumberOfTimesCalled;
}


public virtual bool IsPurchasedWasCalledWith(string inAppOfferName){
return (
inAppOfferName.Equals(IsPurchasedParameter_inAppOfferName_LastCalledWith) );
}
 

             public bool IsPurchased(string inAppOfferName)
        {
            _isPurchasedNumberOfTimesCalled++;            

            IsPurchasedParameter_inAppOfferName_LastCalledWith = inAppOfferName;

            return _isPurchasedReturnValue;
        }}
}